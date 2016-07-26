//----------------------------------------------------------------------------
//  Copyright (C) 2004-2016 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Cvb;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.VideoSurveillance;
using System.Collections.Generic;
using System.IO;

namespace VideoSurveilance
{
    using StorageClient;
    using System.Text;

    public partial class VideoSurveilance : Form
    {
        public const int MiddleLine = 240;

        public static string CSV_PATH = "SAMoutput.csv";
        public static string VerboseCsvPath = "SAMoutput_verbose.csv";

        private static Capture _cameraCapture;

        private static BackgroundSubtractor _fgDetector;
        private static CvBlobDetector _blobDetector;
        private static CvTracks _tracker;

        private bool IsCompareMode = false;

        private string FileLocation;
        private Point? LeftCoordinate = null;
        private Point? RightCoordinate = null;

        private TableStorageClient tableClient;

        private bool IsCaptureHeight = false;

        // Number of frames that a blob must appear before we save it
        public const int FrameThreshold = 90;

        // If a blob is offscreen for more than this threshold, create a new object instead
        public const int InactiveFrameThreshold = 60;

        // If a blob has disappeared for a time, we want to consider it a new blob
        // This dictionary keeps track of those mappings
        private Dictionary<int, int> blobMap = new Dictionary<int, int>();

        // Blobs for comparing human to machine results
        private Dictionary<int, ComparisonBlob> humanBlobs = new Dictionary<int, ComparisonBlob>();
        private Dictionary<int, ComparisonBlob> machineBlobs = new Dictionary<int, ComparisonBlob>();

        // Filters for comparing human to machine results
        private int? minFrameFilter = null;
        private int? maxFrameFilter = null;
        private bool showEnteringPeople = true;
        private bool showExitingPeople = true;
        private bool showMachineResults = true;
        private bool showHumanResults = true;
        private List<int> highlightedHumanBlobs = new List<int>();
        private List<int> highlightedMachineBlobs = new List<int>(); 

        /// <summary>
        /// Blob id to show detailed information for
        /// </summary>
        private int? IdToTrack = null;

        /// <summary>
        /// Whether to draw the highlight box only for the tracked id
        /// </summary>
        private bool drawBoxOnlyForTrackedId = false;

        /// <summary>
        /// Index of frame being processed
        /// </summary>
        private int currentFrame = 0;

        /// <summary>
        /// Used for assigning unique new ids to blobs
        /// </summary>
        private int newIdOffset = 0;

        public static Dictionary<int, MovingBlob> movingblobs = new Dictionary<int, MovingBlob>();
        public static List<MovingBlob> retiredblobs = new List<MovingBlob>();

        public VideoSurveilance()
        {
            tableClient = new TableStorageClient(Constants.StorageConnectionString);
            InitializeComponent();
        }

        void Run()
        {
            _fgDetector = new BackgroundSubtractorMOG2(history:1000,varThreshold:64, shadowDetection:true);
            _blobDetector = new CvBlobDetector();
            _tracker = new CvTracks();

            Application.Idle += ProcessFrame;
        }

        public void LoadVideo()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(this.eventName.Text))
                {
                    MessageBox.Show("Please enter an event name.");
                    return;
                }
                
                 
               if (File.Exists(this.FileLocation))
                {
                    _cameraCapture = new Capture(this.FileLocation);
                }
                else
                {
                    MessageBox.Show("Please select a video file first.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        public static int frameCount = 0;

        public static double CurrentTime()
        {
            return frameCount / 10.0;
        }

        private Mat previousframe;

        void ProcessFrame(object sender, EventArgs e)
        {
            textBox1.Text = Math.Round(CurrentTime() % 60).ToString();
            frameCount++;
            Mat frame = _cameraCapture.QueryFrame();
            if (frame == null)// || frameCount == (121 * 10)) // Exit after 121 frames to match verbose output
            {
                OutputResults();
                return;
            }

            previousframe = frame;
            System.Threading.Thread.Sleep(1); // 15 is 2x speed

            Mat smoothedFrame = new Mat();
            CvInvoke.GaussianBlur(frame, smoothedFrame, new Size(3, 3), 1); //filter out noises
                                                                            //frame._SmoothGaussian(3); 

            Mat foregroundMask = new Mat();
            _fgDetector.Apply(smoothedFrame, foregroundMask);
            var motion = foregroundMask.GetData().Average(b => b + 0);
            //textBox1.Text = motion.ToString();
            if (motion > 25)
            {
                imageBox1.Image = frame;
                imageBox2.Image = foregroundMask;
                return;
            }//give up if the frame is too noisy

            CvBlobs blobs = new CvBlobs();
            _blobDetector.Detect(foregroundMask.ToImage<Gray, byte>(), blobs);
            blobs.FilterByArea(500, int.MaxValue);

            float scale = (frame.Width + frame.Width) / 2.0f;
            _tracker.Update(blobs, 0.01 * scale, 5, 50);

            if (_tracker.Count == 0)
            {
                // ids reset, so move everything to retiredblobs and clear movingblobs and map
                retiredblobs.AddRange(movingblobs.Values);
                movingblobs = new Dictionary<int, MovingBlob>();
                blobMap = new Dictionary<int, int>();
            }

            UpdateBlobs(frame);

            if (this.IdToTrack != null)
            {
                if (movingblobs.ContainsKey(this.IdToTrack.Value))
                {
                    var blob = movingblobs[this.IdToTrack.Value];
                    this.txtIdDetails.Text =
                        string.Format(
                            $"{blob.id}: lastFrame: {blob.lastFrame}, currentFrame: {currentFrame}, lastPos: {blob.xend},{blob.yend}");
                }
            }

            DrawBlobs(frame);
            currentFrame++;
            imageBox1.Image = frame;
            imageBox2.Image = foregroundMask;
        }

        private void UpdateBlobs(Mat frame)
        {
            foreach (var pair in _tracker)
            {
                CvTrack blob = pair.Value;

                if (movingblobs.ContainsKey((int)blob.Id))
                {
                    var saved = movingblobs[(int)blob.Id];
                    if (blobMap.ContainsKey(saved.id))
                    {
                        saved = movingblobs[blobMap[saved.id]];
                    }

                    // If it's been more than 4 seconds since this blob last appeared, then
                    // it's probably a new item. We need to map it to the latest blob.
                    if (currentFrame - saved.lastFrame > InactiveFrameThreshold)
                    {
                        saved = CreateMovingBlob(blob, currentFrame, true);
                        if (saved == null)
                        {
                            // It wasn't legal to create this new version of the object
                            continue;
                        }
                    }

                    // Figure out if any of the current blobs have moved an illegal distance between frames
                    // If they did, then this indicates that this should actually be treated as a new object
                    if (
                        MovingBlob.Distance(new Point((int)saved.xend, (int)saved.yend),
                            new Point((int)blob.Centroid.X, (int)blob.Centroid.Y)) > 50)
                    {
                        saved = this.CreateMovingBlob(blob, currentFrame, true);
                        if (saved == null)
                        {
                            // It wasn't legal to create this new version of this object
                            continue;
                        }
                    }

                    // Don't draw the box if we've said we're only drawing it for the tracked id
                    if (!this.drawBoxOnlyForTrackedId || (this.IdToTrack.HasValue && saved.id == this.IdToTrack.Value))
                    {
                        CvInvoke.Rectangle(frame, blob.BoundingBox, new MCvScalar(255.0, 255.0, 255.0), 2);
                    }

                    CvInvoke.PutText(frame, saved.id.ToString()
                        , new Point((int)Math.Round(blob.Centroid.X), (int)Math.Round(blob.Centroid.Y)), FontFace.HersheyPlain, 1.0, new MCvScalar(0, 0, 0));

                    if (this.IdToTrack != null && this.IdToTrack.Value == saved.id)
                    {
                        this.txtTrackOutput.Text +=
                            string.Format(
                                $"{saved.id}: End: {saved.xend.ToString("N0")},{saved.yend.ToString("N0")}, Avg Size: {saved.averagesize.ToString("N0")}, Distance: {saved.distance.ToString("N0")}, Frame: {currentFrame}\n");
                    }

                    saved.xend = blob.Centroid.X;
                    saved.yend = blob.Centroid.Y;
                    saved.path.Add(new Tuple<Point, double>(new Point((int)Math.Round(blob.Centroid.X), (int)Math.Round(blob.Centroid.Y)), CurrentTime()));
                    saved.AddToAverage(blob.BoundingBox.Height * blob.BoundingBox.Width);
                    saved.frames += 1;
                    saved.lastFrame = currentFrame;

                    if (saved.frames >= FrameThreshold)
                    {
                        //CvInvoke.Line(previousframe, new Point((int)saved.xstart, (int)saved.ystart),
                        //    new Point((int)saved.xend, (int)saved.yend), new MCvScalar(0.0, 255.0, 0.0), 3);
                        //CvInvoke.PutText(previousframe, saved.distance.ToString("n0"),
                        //    new Point((int) saved.xend + 20, (int) saved.yend + 20), FontFace.HersheyPlain, 1,
                        //    new MCvScalar());
                    }
                }
                else
                {
                    CreateMovingBlob(blob, currentFrame);
                }
            }
        }

        private void DrawBlobs(Mat frame)
        {
            foreach (var movingblob in movingblobs)
            {
                // movingblob.Value.CleanPath();
                for (int i = 0; i < movingblob.Value.path.Count - 1; i++)
                {
                    var ageWidth = AgeFade(movingblob.Value.path[i].Item2);
                    if (ageWidth > 0)
                    {
                        CvInvoke.Line(frame, movingblob.Value.path[i].Item1, movingblob.Value.path[i + 1].Item1, new MCvScalar(0.0, 255.0, 0.0), ageWidth);
                    }
                }
                var momentum = movingblob.Value.Momentum();
                if (movingblob.Value.path.Count > 2)
                {
                    CvInvoke.Line(frame, movingblob.Value.path.Last().Item1, momentum, new MCvScalar(255.0, 0, 255.0), 1);
                }
            }
        }

        private void OutputResults()
        {
            EventTable eventTable = new EventTable(Guid.NewGuid(), "Event Name" + DateTime.Now.Second);
            tableClient.InsertRecord("Event", eventTable);

            retiredblobs.AddRange(movingblobs.Values);
            var validblobs = retiredblobs.Where(b => b.crossedY((Point)this.LeftCoordinate, (Point)this.RightCoordinate) && b.path.Count > Constants.MinPathCountPoints);
            //!b.IsTooBig());
            if (validblobs.Count() != 0)
            {
                var expected = new List<Tuple<bool, int>>
                {
                    new Tuple<bool, int>(true, 480),
                    new Tuple<bool, int>(false, 240),
                    new Tuple<bool, int>(false, 255),
                    new Tuple<bool, int>(true, 390),
                    new Tuple<bool, int>(true, 390),
                    new Tuple<bool, int>(true, 390),
                    new Tuple<bool, int>(false, 450),
                    new Tuple<bool, int>(false, 750),
                    new Tuple<bool, int>(false, 795),
                    new Tuple<bool, int>(false, 840),
                    new Tuple<bool, int>(false, 900),
                    new Tuple<bool, int>(false, 1125),
                    new Tuple<bool, int>(false, 1110),
                    new Tuple<bool, int>(false, 1170),
                    new Tuple<bool, int>(false, 1215),
                    new Tuple<bool, int>(false, 1215),
                    new Tuple<bool, int>(false, 1335),
                    new Tuple<bool, int>(true, 1395),
                    new Tuple<bool, int>(true, 1545),
                    new Tuple<bool, int>(false, 1575),
                    new Tuple<bool, int>(false, 1725),
                    new Tuple<bool, int>(false, 1740),
                    new Tuple<bool, int>(false, 1725),
                    new Tuple<bool, int>(false, 1785),
                    new Tuple<bool, int>(false, 1770),
                    new Tuple<bool, int>(false, 1770),
                    new Tuple<bool, int>(false, 1770)
                };
                var entered = expected.Where(e => !e.Item1);
                var exited = expected.Except(entered);

                var foundEntered = validblobs.Where(b => b.up);
                var foundExited = validblobs.Except(foundEntered);

                var foundGroupEntered = foundEntered.Select(f => CountPeople(f.averagesize)).Sum();
                var foundGroupExited = foundExited.Select(f => CountPeople(f.averagesize)).Sum();

                var score = Math.Pow(entered.Count() - foundEntered.Count(), 2) + Math.Pow(exited.Count() - foundExited.Count(), 2);
                var groupscore = Math.Pow(entered.Count() - foundGroupEntered, 2) + Math.Pow(exited.Count() - foundGroupExited, 2);

                using (var csv = new StreamWriter(CSV_PATH))
                {
                    foreach (var blob in validblobs)
                    {
                        ActionTable actionTable = new ActionTable(eventTable.PartitionKey, DateTime.Now);
                        tableClient.InsertRecord("Action", actionTable);
                        csv.WriteLine((blob.up ? "Entered," : "Exited,") +
                            blob.CrossedTime(240) + "," + blob.averagesize);
                    }
                }

                var largestSize = validblobs.OrderByDescending(b => b.averagesize).First().averagesize;
                Random random = new Random();
                foreach (var blob in validblobs)
                {
                    var normalSize = (int)Math.Max(10 * blob.averagesize / largestSize, 1);
                    int r = random.Next(256);
                    int g = random.Next(256);
                    int b = random.Next(256);

                    if (blob.up)
                    {
                        CvInvoke.Line(previousframe, blob.path.First().Item1, blob.path.Last().Item1, new MCvScalar(r, g, b), normalSize);
                    }
                    else
                    {
                        CvInvoke.Line(previousframe, blob.path.First().Item1, blob.path.Last().Item1, new MCvScalar(r, g, b), normalSize);
                    }
                }
            }

            // Write verbose output so that we can re-plot items
            using (StreamWriter writer = new StreamWriter(VerboseCsvPath))
            {
                writer.WriteLine("Id,X,Y,Frame,IsUp,AverageSize");
                foreach (var blob in validblobs)
                {
                    foreach (var path in blob.path)
                    {
                        writer.WriteLine($"{blob.id},{path.Item1.X},{path.Item1.Y},{path.Item2},{blob.up},{blob.averagesize}");
                    }
                }
            }

            imageBox1.Image = previousframe;
            Application.Idle -= ProcessFrame;
            return;
        }

        private double CountPeople(double averagesize)
        {
            return Math.Sqrt(averagesize) / 1000 + averagesize / 8000;//result of basic ml
        }

        private MovingBlob CreateMovingBlob(CvTrack blob, int currentFrame, bool updateMap = false)
        {
            var movingBlob = new MovingBlob
            {
                id = (int)blob.Id,
                xstart = blob.Centroid.X,
                ystart = blob.Centroid.Y,
                xend = blob.Centroid.X,
                yend = blob.Centroid.Y,
                averagesize = blob.BoundingBox.Height * blob.BoundingBox.Width,
                frames = 1,
                lastFrame = currentFrame
            };

            // It's not valid for a new person to appear in the middle of the image, so filter those out
            if (movingBlob.averagesize < (150 * 150))
            //if (true || movingBlob.ystart < 100 || movingBlob.ystart > 350)
            {
                if (updateMap)
                {
                    // Create a new id
                    movingBlob.id = 10000 + newIdOffset;
                    newIdOffset++;

                    // Update the map
                    if (!blobMap.ContainsKey((int)blob.Id))
                    {
                        blobMap.Add((int)blob.Id, movingBlob.id);
                    }
                    else
                    {
                        blobMap[(int)blob.Id] = movingBlob.id;
                    }
                }

                movingblobs.Add(movingBlob.id, movingBlob);
                return movingBlob;
            }

            return null;
        }

        private void imageBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.IsCaptureHeight)
            {
                this.messaging.Text = "People who cross this line will be counted.  If this is correct, press continue.  Otherwise click again.";
                this.messaging.Refresh();

                Mat drawFrame = _cameraCapture.QueryFrame();

                MCvScalar color = new MCvScalar(255, 0, 0);

                if (this.LeftCoordinate == null)
                {
                    this.LeftCoordinate = new Point(e.X, e.Y);
                    CvInvoke.Line(drawFrame, (Point)this.LeftCoordinate, new Point(e.X + 5, e.Y), color, 10);
                }
                else
                {
                    this.RightCoordinate = new Point(e.X, e.Y);
                    CvInvoke.Line(drawFrame, (Point)this.LeftCoordinate, (Point)this.RightCoordinate, color, 10);
                    this.continueButton.Show();
                }

                this.resetButton.Show();
                imageBox1.Image = drawFrame;
                imageBox1.Refresh();

            }
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            txtPosition.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void cmdTrackOk_Click(object sender, EventArgs e)
        {
            int idOut;
            if (int.TryParse(this.txtId.Text, out idOut))
            {
                IdToTrack = idOut;
            }
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtTrackOutput.Text);
        }

        public int AgeFade(double time)
        {
            var age = CurrentTime() - time;
            if (age < 3)
            {
                return (int)(4 - age);
            }
            return 0;
        }

        private void cmdStartVideo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.FileLocation) || String.IsNullOrWhiteSpace(this.eventName.Text))
            {
                MessageBox.Show("Please select a file and event name first ");
                return;
            }
            LoadVideo();

            Mat frame = _cameraCapture.QueryFrame();
            imageBox1.Image = frame;
            IsCaptureHeight = true;
            this.messaging.Text = "Next we'll define the entrance to the park.  Click on the image twice.  Once on the left side of the entrance, and next on the right side";
            this.messaging.Refresh();
            imageBox1.Refresh();
        }

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select VideoSurveilance Output";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string predictedOutput = dialog.FileName;
                dialog.Title = "Select Annotated Output";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string humanOutput = dialog.FileName;
                    this.humanBlobs = new Dictionary<int, ComparisonBlob>();
                    this.machineBlobs = new Dictionary<int, ComparisonBlob>();

                    // Read the human predictions
                    foreach (var line in File.ReadAllLines(humanOutput).Skip(1))
                    {
                        string[] columns = line.Split(',');
                        int index = Int32.Parse(columns[0]);
                        int frame = Int32.Parse(columns[1]);
                        int x = Int32.Parse(columns[2]);
                        int y = Int32.Parse(columns[3]);

                        if (!humanBlobs.ContainsKey(index))
                        {
                            ComparisonBlob blob = new ComparisonBlob();
                            blob.Index = index;
                            humanBlobs.Add(index, blob);
                        }

                        ComparisonBlob humanBlob = humanBlobs[index];
                        humanBlob.Path.Add(new Tuple<Point, double>(new Point(x, y), frame));
                    }

                    foreach (var blob in humanBlobs.Values)
                    {
                        if (blob.Path.First().Item1.Y < blob.Path.Last().Item1.Y)
                        {
                            blob.IsUp = false;
                        }
                        else
                        {
                            blob.IsUp = true;
                        }
                    }

                    // Read the machine predictions
                    foreach (var line in File.ReadAllLines(predictedOutput).Skip(1))
                    {
                        string[] columns = line.Split(',');
                        int index = Int32.Parse(columns[0]);
                        int x = Int32.Parse(columns[1]);
                        int y = Int32.Parse(columns[2]);
                        double frame = Double.Parse(columns[3]);
                        frame = frame * 10;
                        bool isUp = Boolean.Parse(columns[4]);
                        double averageSize = Double.Parse(columns[5]);

                        if (!machineBlobs.ContainsKey(index))
                        {
                            ComparisonBlob blob = new ComparisonBlob();
                            blob.Index = index;
                            blob.IsUp = isUp;
                            blob.AverageSize = averageSize;
                            machineBlobs.Add(index, blob);
                        }

                        ComparisonBlob machineBlob = machineBlobs[index];
                        machineBlob.Path.Add(new Tuple<Point, double>(new Point(x, y), frame));
                    }

                    this.PlotCompareResults();

                }
            }
        }

        private void PlotCompareResults()
        {
            Mat drawFrame = _cameraCapture.QueryFrame();

            int minFrame = Int32.MinValue;
            int maxFrame = Int32.MaxValue;
            if (this.minFrameFilter != null)
            {
                minFrame = this.minFrameFilter.Value;
            }

            if (this.maxFrameFilter != null)
            {
                maxFrame = this.maxFrameFilter.Value;
            }

            List<string> outputItemList = new List<string>();

            int humanEnter = 0;
            int humanExit = 0;
            int machineEnter = 0;
            int machineExit = 0;
            double machineEnterGuess = 0;
            double machineExitGuess = 0;

            // Plot the results
            if (showHumanResults)
            {
                foreach (var blob in humanBlobs.Values)
                {
                    bool added = false;
                    if (blob.IsValid)
                    {
                        int thickness = 2;
                        MCvScalar color = new MCvScalar();
                        if (blob.IsUp)
                        {
                            color = new MCvScalar(255, 0, 0);
                        }
                        else
                        {
                            color = new MCvScalar(100, 0, 0);
                        }

                        if (this.highlightedHumanBlobs.Contains(blob.Index))
                        {
                            thickness = 4;
                            color = new MCvScalar(0, 255, 255);
                        }

                        if (blob.IsUp && !this.showExitingPeople)
                        {
                            continue;
                        }

                        if (!blob.IsUp && !this.showEnteringPeople)
                        {
                            continue;
                        }

                        for (int i = 0; i < blob.Path.Count - 1; i++)
                        {
                            var firstPoint = blob.Path[i].Item1;
                            var lastPoint = blob.Path[i + 1].Item1;

                            if (blob.MinFrame >= minFrame && blob.MaxFrame <= maxFrame)
                            {
                                if (!added)
                                {
                                    if (blob.IsUp)
                                    {
                                        humanExit++;
                                    }
                                    else
                                    {
                                        humanEnter++;
                                    }

                                    outputItemList.Add(
                                        $"Human,{blob.Index}, IsUp: {blob.IsUp}, Top: {blob.TopTime}, Bottom: {blob.BottomTime}, Cross: {blob.CrossTime}");

                                    added = true;
                                }

                                CvInvoke.Line(drawFrame, firstPoint, lastPoint, color, thickness);

                                // Make the ends extra thick
                                if (i == 0)
                                {
                                    var offsetPoint = new Point(firstPoint.X + 1, firstPoint.Y + 1);
                                    CvInvoke.Line(drawFrame, firstPoint, offsetPoint, color, 10);
                                }
                                else if (i == blob.Path.Count - 2)
                                {
                                    var offsetPoint = new Point(lastPoint.X + 1, lastPoint.Y + 1);
                                    CvInvoke.Line(drawFrame, lastPoint, offsetPoint, color, 10);
                                }
                            }
                        }
                    }
                }
            }

            if (showMachineResults)
            {
                foreach (var blob in machineBlobs.Values)
                {
                    bool added = false;
                    MCvScalar color = new MCvScalar();
                    int thickness = 2;
                    if (blob.IsUp)
                    {
                        color = new MCvScalar(0, 255, 0);
                    }
                    else
                    {
                        color = new MCvScalar(0, 100, 0);
                    }

                    if (this.highlightedMachineBlobs.Contains(blob.Index))
                    {
                        color = new MCvScalar(0, 255, 255);
                        thickness = 4;
                    }

                    if (blob.IsUp && !this.showExitingPeople)
                    {
                        continue;
                    }

                    if (!blob.IsUp && !this.showEnteringPeople)
                    {
                        continue;
                    }

                    for (int i = 0; i < blob.Path.Count - 1; i++)
                    {
                        var firstPoint = blob.Path[i].Item1;
                        var lastPoint = blob.Path[i + 1].Item1;

                        if (blob.MinFrame >= minFrame && blob.MaxFrame <= maxFrame)
                        {
                            if (!added)
                            {
                                outputItemList.Add(
                                    $"Machine,{blob.Index}, IsUp: {blob.IsUp}, Top: {blob.TopTime}, Bottom: {blob.BottomTime}, Cross: {blob.CrossTime}");

                                if (blob.IsUp)
                                {
                                    machineExit++;
                                    machineExitGuess += CountPeople(blob.AverageSize);
                                }
                                else
                                {
                                    machineEnter++;
                                    machineEnterGuess += CountPeople(blob.AverageSize);
                                }

                                added = true;
                            }

                            CvInvoke.Line(drawFrame, firstPoint, lastPoint, color, thickness);

                            // Make the ends extra thick
                            if (i == 0)
                            {
                                var offsetPoint = new Point(firstPoint.X + 1, firstPoint.Y + 1);
                                CvInvoke.Line(drawFrame, firstPoint, offsetPoint, color, 10);
                            }
                            else if (i == blob.Path.Count - 2)
                            {
                                var offsetPoint = new Point(lastPoint.X + 1, lastPoint.Y + 1);
                                CvInvoke.Line(drawFrame, lastPoint, offsetPoint, color, 10);
                            }
                        }
                    }
                }
            }

            imageBox1.Image = drawFrame;
            this.txtCompareSummary.Text =
                $"Enter: {humanEnter} (humans), {machineEnter} (machines), {machineEnterGuess} (machines blob adjustment)"
                + Environment.NewLine
                + $"Exit: {humanExit} (humans, {machineExit} (machines), {machineExitGuess} (machines blob adjustment)";

            this.lstCompare.Items.Clear();
            foreach (var item in outputItemList)
            {
                this.lstCompare.Items.Add(item);
            }

            lblMinFrame.Visible = true;
            lblMaxFrame.Visible = true;
            txtMinFrame.Visible = true;
            txtMaxFrame.Visible = true;
            cmdApplyFrameFilter.Visible = true;
            txtCompareSummary.Visible = true;
            chkEnterFilter.Visible = true;
            chkExitFilter.Visible = true;
            lblMachineEnter.Visible = true;
            lblMachineExit.Visible = true;
            lblHumanEnter.Visible = true;
            lblHumanExit.Visible = true;
            lstCompare.Visible = true;
            cmdHighlight.Visible = true;
            chkMachineFilter.Visible = true;
            chkHuman.Visible = true;
            this.cmdCopyItems.Visible = true;
        }

        private void cmdApplyFrameFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMinFrame.Text))
            {
                this.minFrameFilter = null;
            }
            else
            {
                this.minFrameFilter = Int32.Parse(this.txtMinFrame.Text);
            }

            if (string.IsNullOrWhiteSpace(this.txtMaxFrame.Text))
            {
                this.maxFrameFilter = null;
            }
            else
            {
                this.maxFrameFilter = Int32.Parse(this.txtMaxFrame.Text);
            }

            this.showEnteringPeople = this.chkEnterFilter.Checked;
            this.showExitingPeople = this.chkExitFilter.Checked;
            this.showMachineResults = this.chkMachineFilter.Checked;
            this.showHumanResults = this.chkHuman.Checked;

            this.PlotCompareResults();
        }

        private void cmdHighlight_Click(object sender, EventArgs e)
        {
            this.highlightedHumanBlobs = new List<int>();
            this.highlightedMachineBlobs = new List<int>();

            foreach (var item in this.lstCompare.SelectedItems)
            {
                var stringItem = item.ToString();
                string[] columns = stringItem.Split(',');
                int index = Int32.Parse(columns[1]);
                if (stringItem.Contains("Human"))
                {
                    this.highlightedHumanBlobs.Add(index);
                }
                else
                {
                    this.highlightedMachineBlobs.Add(index);
                }
            }

            this.PlotCompareResults();
        }

        private void cmdCopyItems_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            foreach (var item in this.lstCompare.SelectedItems)
            {
                items.Add(item.ToString());
            }

            Clipboard.SetText(string.Join(Environment.NewLine, items));
        }

        private void BrowseForFile(object sender, EventArgs e)
        {
            OpenFileDialog browseFileDialog = new OpenFileDialog();
            DialogResult userClickedOK = browseFileDialog.ShowDialog();
            this.FileLocation = browseFileDialog.FileName;
            this.fileNameTextBox.Text = browseFileDialog.FileName;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if(this.RightCoordinate != null && this.LeftCoordinate != null)
            {
                this.messaging.Text = String.Empty;
                this.IsCaptureHeight = false;
                this.continueButton.Hide();
                this.resetButton.Hide();
                Run();
            }
            else
            {
                MessageBox.Show("Please click the image before continuing");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.LeftCoordinate = null;
            this.RightCoordinate = null;

            Mat drawFrame = _cameraCapture.QueryFrame();
            imageBox1.Image = drawFrame;
            imageBox1.Refresh();

            this.continueButton.Hide();
        }
    }

    public class ComparisonBlob
    {
        public int Index { get; set; }

        public List<Tuple<Point, double>> Path { get; set; }

        public bool IsUp { get; set; }

        private double? minFrame = null;
        private double? maxFrame = null;

        public double AverageSize
        {
            get;
            set;
        }

        public double MinFrame
        {
            get
            {
                if (minFrame == null)
                {

                    List<double> frames = new List<double>();
                    foreach (var path in this.Path)
                    {
                        frames.Add(path.Item2);
                    }

                    minFrame = frames.Min();
                }

                return minFrame.Value;
            }
        }

        public double MaxFrame
        {
            get
            {
                if (maxFrame == null)
                {
                    List<double> frames = new List<double>();
                    foreach (var path in this.Path)
                    {
                        frames.Add(path.Item2);
                    }

                    maxFrame = frames.Max();
                }

                return maxFrame.Value;
            }
        }


        public bool IsValid
        {
            get
            {
                if (Path.Count < 2)
                {
                    return false;
                }

                return Path.First().Item1.Y > 300 ^ Path.Last().Item1.Y > 300;
            }
        }

        public double TopTime
        {
            get
            {
                if (this.IsUp)
                {
                    return this.Path.Last().Item2;
                }
                else
                {
                    return this.Path.First().Item2;
                }
            }
        }

        public double BottomTime
        {
            get
            {
                if (!this.IsUp)
                {
                    return this.Path.Last().Item2;
                }
                else
                {
                    return this.Path.First().Item2;
                }

            }
        }

        public double CrossTime
        {
            get
            {
                if (this.IsUp)
                {
                    foreach (var path in this.Path)
                    {
                        if (path.Item1.Y < VideoSurveilance.MiddleLine)
                        {
                            return path.Item2;
                        }
                    }

                    return 0;
                }
                else
                {
                    foreach (var path in this.Path)
                    {
                        if (path.Item1.Y > VideoSurveilance.MiddleLine)
                        {
                            return path.Item2;
                        }
                    }

                    return 0;
                }
            }
        }

        public ComparisonBlob()
        {
            this.Path = new List<Tuple<Point, double>>();
        }
    }

    public class MovingBlob
    {
        public int id;
        public double xstart;
        public double ystart;
        public double xend;
        public double yend;
        public double averagesize;
        public int frames;
        public List<Tuple<Point, double>> path = new List<Tuple<Point, double>>();
        public int lastFrame;

        public double distance
        {
            get
            {
                if (path == null || path.Count == 0)
                {
                    return 0;
                }
                return Distance(path.First().Item1, path.Last().Item1);
            }
        }

        public static double Distance(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }

        public bool crossedY(Point left, Point right)
        {
            if (path.Count < 2)
            {
                return false;
            }

            // TODO: Replace this logic
            return path.First().Item1.Y > 240 ^ path.Last().Item1.Y > 240;

            //throw;
            //return true;// path.First().Item1.Y > height ^ path.Last().Item1.Y > height;
        }

        /// <summary>
        /// If this blob is over 50x50, filter it out
        /// </summary>
        /// <returns></returns>
        public bool IsTooBig()
        {
            if (this.averagesize >= (50 * 50))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool up
        {
            get
            {
                // Average the first 1/4 and the last 1/4
                var first = path.Take(path.Count / 4);
                List<double> firstY = new List<double>();
                var last = path.Skip(3 * (path.Count / 4));
                List<double> secondY = new List<double>();
                foreach (var element in first)
                {
                    firstY.Add(element.Item1.Y);
                }

                foreach (var element in last)
                {
                    secondY.Add(element.Item1.Y);
                }

                return firstY.Average() > secondY.Average();
            }
        }

        public void AddToAverage(double next)
        {
            averagesize -= averagesize / frames;
            averagesize += next / frames;
        }

        public void CleanPath(double distance = 100)
        {
            for (int i = path.Count - 1; i >= 1; i--)
            {
                if (Distance(path[i].Item1, path[i - 1].Item1) > distance)
                {
                    path.Remove(path[i]);
                }
            }
        }

        public double CrossedTime(int height)
        {
            // TOOO: Change this on merge
            Point point = new Point();

            if (!crossedY(point, point))
            {
                throw new Exception("Crossed time is undefined");
            }
            return (up ? path.First(p => p.Item1.Y > height) : path.First(p => p.Item1.Y < height)).Item2;
        }

        public Point Momentum()
        {
            if (path == null || path.Count == 0)
            {
                return new Point();
            }
            if (path.Count == 1)
            {
                return path.Last().Item1;
            }
            var previous = path[path.Count - 2].Item1;
            var diff = path.Last().Item1.Subtract(previous);
            var diffs = new List<Point>();

            for (int i = 0; i < 5; i++)
            {
                if (path.Count - i - 2 > 0)
                {
                    diffs.Add(path[path.Count - i - 1].Item1.Subtract(path[path.Count - i - 2].Item1));
                }
            }

            return path.Last().Item1.Add(diffs.Select(d => d.Multiply(3)).Average());
        }
    }

    public static class Extensions
    {
        public static Point Add(this Point p1, Point p2)
        {
            return new Point
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }

        public static Point Subtract(this Point p1, Point p2)
        {
            return new Point
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
        }

        public static Point Multiply(this Point p1, double scalar)
        {
            return new Point
            {
                X = (int)(p1.X * scalar),
                Y = (int)(p1.Y * scalar)
            };
        }

        public static Point Average(this IEnumerable<Point> list)
        {
            var toreturn = new Point(0, 0);
            foreach (var point in list)
            {
                toreturn = toreturn.Add(point);
            }
            return toreturn.Multiply(1.0 / list.Count());
        }
    }
}