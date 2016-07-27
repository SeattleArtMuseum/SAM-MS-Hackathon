using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GleamTech.VideoUltimate;

namespace SamHackVideoAnnotator
{
    public partial class FrameTracker : Form
    {
        private VideoFrameReader reader;

        private List<Person> People = new List<Person>();
        private List<PictureBox> PeoplePicture = new List<PictureBox>();
        private List<Label> PeopleLabels = new List<Label>();
        private List<Label> PeopleLabelIndexes = new List<Label>();

        public bool inPersonCreateMode = false;

        public Point? newPersonTopLeft = null;
        public Point? newPersonBottomRight = null;

        public int? currentPerson = null;

        public int curFrame = 0;

        public FrameTracker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.curFrame = 0;

                // Remove everything except for the existing controls
                for (int i = this.peoplePanel.Controls.Count - 1; i >= 3; i--)
                {
                    this.peoplePanel.Controls.RemoveAt(i);
                }

                this.People = new List<Person>();
                this.PeopleLabelIndexes = new List<Label>();
                this.PeopleLabels = new List<Label>();

                reader = new VideoFrameReader(dialog.FileName);
                reader.Read();
                var frame = reader.GetFrame();
                this.picture.Image = frame;
                this.picture.Width = frame.Width;
                this.picture.Height = frame.Height;
            }
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            // Advance the video by 15 frames
            for (int i = 0; i < 15; i++)
            {
                if (reader.Read())
                {
                    reader.GetFrame();
                    curFrame++;
                }
                else
                {
                    // End of video
                    break;
                }
            }

            if (reader.Read())
            {
                var frame = reader.GetFrame();
                this.picture.Image = frame;
                this.picture.Width = frame.Width;
                this.picture.Height = frame.Height;
                foreach (var label in PeopleLabels)
                {
                    label.Text = "Not Set";
                }
            }
        }

        private void cmdNewPerson_Click(object sender, EventArgs e)
        {
            this.inPersonCreateMode = true;
            this.cmdCancelNew.Enabled = true;
            this.cmdNewPerson.Enabled = false;
            this.newPersonTopLeft = null;
            this.newPersonBottomRight = null;
        }

        private void cmdCancelNew_Click(object sender, EventArgs e)
        {
            this.inPersonCreateMode = false;
            this.cmdCancelNew.Enabled = false;
            this.cmdNewPerson.Enabled = true;
        }

        private void picture_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.inPersonCreateMode)
            {
                if (this.newPersonTopLeft == null)
                {
                    this.newPersonTopLeft = new Point(e.X, e.Y);
                }
                else
                {
                    this.newPersonBottomRight = new Point(e.X, e.Y);

                    int topLeftX = this.newPersonTopLeft.Value.X > this.newPersonBottomRight.Value.X ?
                        this.newPersonBottomRight.Value.X : this.newPersonTopLeft.Value.X;
                    int topLeftY = this.newPersonTopLeft.Value.Y > this.newPersonBottomRight.Value.Y ?
                        this.newPersonBottomRight.Value.Y : this.newPersonTopLeft.Value.Y;
                    int bottomRightX = this.newPersonTopLeft.Value.X < this.newPersonBottomRight.Value.X ?
                        this.newPersonBottomRight.Value.X : this.newPersonTopLeft.Value.X;
                    int bottomRightY = this.newPersonTopLeft.Value.Y < this.newPersonBottomRight.Value.Y ?
                        this.newPersonBottomRight.Value.Y : this.newPersonTopLeft.Value.Y;

                    Person person = new Person();
                    person.Index = this.People.Count;
                    Rectangle crop = new Rectangle(topLeftX, topLeftY, bottomRightX - topLeftX, bottomRightY - topLeftY);
                    Bitmap bmp = new Bitmap(crop.Width, crop.Height);
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawImage(picture.Image, 0, 0, crop, GraphicsUnit.Pixel);
                    g.Dispose();
                    person.Image = bmp;
                    this.People.Add(person);

                    this.inPersonCreateMode = false;
                    this.cmdCancelNew.Enabled = false;
                    this.cmdNewPerson.Enabled = true;

                    PictureBox p = new PictureBox();
                    p.Image = person.Image;
                    p.Width = 50;
                    p.Height = 50;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    int index = this.People.Count - 1;
                    p.Left = 25;
                    p.Top = 50 + (index * 50);
                    p.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeopleClick);

                    Label label = new Label();
                    label.Text = "Not Set";
                    label.Left = p.Left + 100;
                    label.Top = p.Top + 10;

                    Label indexLabel = new Label();
                    indexLabel.Text = (index + 1).ToString();
                    indexLabel.Left = 10;
                    indexLabel.Top = label.Top;

                    this.peoplePanel.Controls.Add(p);
                    this.peoplePanel.Controls.Add(label);
                    this.peoplePanel.Controls.Add(indexLabel);
                    this.PeopleLabels.Add(label);
                    this.PeoplePicture.Add(p);
                    this.PeopleLabelIndexes.Add(indexLabel);
                }
            }
            else if (this.currentPerson != null)
            {
                // Register the position 
                Person p = this.People[this.currentPerson.Value];
                if (!p.Positions.ContainsKey(curFrame))
                {
                    p.Positions.Add(curFrame, new Point(e.X, e.Y));
                }
                else
                {
                    p.Positions[curFrame] = new Point(e.X, e.Y);
                }

                this.PeopleLabels[this.currentPerson.Value].Text = $"{e.X}, {e.Y}";
                this.currentPerson = null;
                this.lblSelected.Visible = false;
            }
        }

        private void HandleKey(object sender, KeyPressEventArgs args)
        {
            if (args.KeyChar >= 49 && args.KeyChar <= 57)
            {
                int index = args.KeyChar - 49;
                if (this.People.Count > index)
                {
                    this.SelectPerson(index);
                }
            }

            Console.WriteLine(args.KeyChar);
        }

        private void PeopleClick(object sender, MouseEventArgs args)
        {
            int index = this.PeoplePicture.IndexOf((PictureBox)sender);
            this.SelectPerson(index);
        }

        private void SelectPerson(int index)
        {
            this.currentPerson = index;
            this.lblSelected.Visible = true;
            this.lblSelected.Top = this.PeopleLabels[index].Top;
            this.lblSelected.Left = 0;
        }

        private void FrameTracker_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\mbentley\Documents\SculptureParkCamera 5.mp4"))
            {
                reader = new VideoFrameReader(@"C:\Users\mbentley\Documents\SculptureParkCamera 5.mp4");
                reader.Read();
                var frame = reader.GetFrame();
                this.picture.Image = frame;
                this.picture.Width = frame.Width;
                this.picture.Height = frame.Height;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Csv file (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    writer.WriteLine("Person,Frame,X,Y");

                    foreach (var person in this.People)
                    {
                        foreach (var position in person.Positions)
                        {
                            writer.WriteLine($"{person.Index},{position.Key},{position.Value.X},{position.Value.Y}");
                        }
                    }
                }
            }
        }

        private void cmdPrevFrame_Click(object sender, EventArgs e)
        {
            if (this.curFrame > 0)
            {
                curFrame -= 15;
                int seconds = curFrame / 15;
                reader.Seek(seconds);

                if (reader.Read())
                {
                    var frame = reader.GetFrame();
                    this.picture.Image = frame;
                    this.picture.Width = frame.Width;
                    this.picture.Height = frame.Height;
                    foreach (var label in PeopleLabels)
                    {
                        label.Text = "Not Set";
                    }
                }
            }
        }
    }

    public class Person
    {
        public Dictionary<int, Point> Positions { get; set; }

        public Bitmap Image { get; set; }

        public int Index { get; set; }

        public Person()
        {
            this.Positions = new Dictionary<int, Point>();
            this.Image = null;
        }
    }
}
