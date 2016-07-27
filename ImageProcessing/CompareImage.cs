using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSurveilance
{
    using Emgu.CV;
    using Emgu.CV.Structure;
    using Emgu.Util;


    public partial class CompareImage : Form
    {
        Capture _capture; //capture device

        Image<Bgr, Byte> Frame; //current Frame from camera
        Image<Bgr, Byte> Previous_Frame; //Previiousframe aquired
        Image<Bgr, Byte> Difference; //Difference between the two frames

        double ContourThresh = 0.003; //stores alpha for thread access
        int Threshold = 60; //stores threshold for thread access


        public CompareImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// What to do with each frame aquired from the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (Frame == null) //we need at least one fram to work out running average so acquire one before doing anything
            {
                //display the frame aquired
                Frame = _capture.RetrieveBgrFrame(); //we could use RetrieveGrayFrame if we didn't care about displaying colour image
                DisplayImage(Frame.ToBitmap(), CurrentFrame); //display the image using thread safe call
                Previous_Frame = Frame.Copy(); //copy the frame to act as the previous
            }
            else
            {
                //acquire the frame
                Frame = _capture.RetrieveBgrFrame(); //aquire a frame

                Difference = Previous_Frame.AbsDiff(Frame); //find the absolute difference 
                /*Play with the value 60 to set a threshold for movement*/
                Difference = Difference.ThresholdBinary(new Bgr(Threshold, Threshold, Threshold), new Bgr(255, 255, 255)); //if value > 60 set to 255, 0 otherwise 
                DisplayImage(Difference.ToBitmap(), resultbox); //display the absolute difference 

                Previous_Frame = Frame.Copy(); //copy the frame to act as the previous frame

                #region Draw the contours of difference
                //this is tasken from the ShapeDetection Example
                using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
                                                              //detect the contours and loop through each of them
                    for (Contour<Point> contours = Difference.Convert<Gray, Byte>().FindContours(
                          Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                          Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST,
                          storage);
                       contours != null;
                       contours = contours.HNext)
                    {
                        //Create a contour for the current variable for us to work with
                        Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);

                        //Draw the detected contour on the image
                        if (currentContour.Area > ContourThresh) //only consider contours with area greater than 100 as default then take from form control
                        {
                            Frame.Draw(currentContour.BoundingRectangle, new Bgr(Color.Red), 2);
                        }
                    }
                #endregion

                DisplayImage(Frame.ToBitmap(), CurrentFrame); //display the image using thread safe call
                DisplayImage(Previous_Frame.ToBitmap(), PreviousFrame); //display the previous image using thread safe call



            }
        }

        /// <summary>
        /// Thread safe method to display image in a picturebox that is set to automatic sizing
        /// </summary>
        /// <param name="Image"></param>
        private delegate void DisplayImageDelegate(Bitmap Image, PictureBox Control);
        private void DisplayImage(Bitmap Image, PictureBox Control)
        {
            if (CurrentFrame.InvokeRequired)
            {
                try
                {
                    DisplayImageDelegate DI = new DisplayImageDelegate(DisplayImage);
                    this.BeginInvoke(DI, new object[] { Image, Control });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                Control.Image = Image;
            }
        }

        //Form controls
        /// <summary>
        /// Updates the lbl associate with threshold value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Threshold_Value_Scroll(object sender, EventArgs e)
        {
            Threshold = Threshold_Value.Value;
            Theshold_LBL.Text = "Movement Threshold: " + Threshold.ToString();
        }
        /// <summary>
        /// Updates the lbl associate with Alpha value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Contour_Value_Scroll(object sender, EventArgs e)
        {
            ContourThresh = ContourThresh_Value.Value;
            Contour_lbl.Text = "Movement Threshold: " + ContourThresh.ToString();
        }

        /// <summary>
        /// Ensure that the Camera Setting are reset if the form is just clossed and the camera is released
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            if (_capture != null)
            {
                if (_capture.GrabProcessState == System.Threading.ThreadState.Running) _capture.Stop();
                _capture.Dispose();
            }
        }

        private void CompareImage_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            //start a capture using the default device 
            _capture = new Capture();  //set up cature
            _capture.ImageGrabbed += ProcessFrame; //set up capture event handler
            _capture.Start(); //start aquasition
        }
    }
}
