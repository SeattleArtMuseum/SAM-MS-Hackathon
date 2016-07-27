using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GleamTech.VideoUltimate;

namespace SamHackVideoAnnotator
{
    public partial class SimpleAnnotator : Form
    {
        public List<string> PeopleEvents = new List<string>();

        public SimpleAnnotator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var videoFrameReader = new VideoFrameReader(@"C:\Users\mbentley\Documents\SculptureParkCamera5.mp4"))
            {
                if (videoFrameReader.Read())
                {
                    using (var frame = videoFrameReader.GetFrame())
                        frame.Save(@"C:\Users\mbentley\Documents\Visual Studio 2015\Projects\SamHack\video\out\Frame1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void cmdEnter_Click(object sender, EventArgs e)
        {
            string output = "Enter," + player.Ctlcontrols.currentPosition;
            PeopleEvents.Add(output);
            txtOutput.Text += output + "\n";
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            string output = "Exit," + player.Ctlcontrols.currentPosition;
            PeopleEvents.Add(output);
            txtOutput.Text += output + "\n";
        }

        private void cmdUndo_Click(object sender, EventArgs e)
        {
            if (this.PeopleEvents.Count > 0)
            {
                this.PeopleEvents.RemoveAt(this.PeopleEvents.Count - 1);
                this.txtOutput.Text = string.Join("\n", this.PeopleEvents);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Csv file (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    writer.WriteLine("Event,Timestamp");
                    writer.WriteLine(this.txtOutput.Text);
                }
            }
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                player.URL = dialog.FileName;
                this.PeopleEvents = new List<string>();
                this.txtOutput.Text = "";
            }
        }

        private void cmdApplyPlayback_Click(object sender, EventArgs e)
        {            
            player.settings.rate = Double.Parse(txtPlaybackSpeed.Text);
        }
    }
}
