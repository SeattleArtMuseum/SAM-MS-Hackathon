namespace SamHackVideoAnnotator
{
    partial class SimpleAnnotator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleAnnotator));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmdEnter = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.cmdUndo = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaybackSpeed = new System.Windows.Forms.TextBox();
            this.cmdApplyPlayback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 12);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(485, 272);
            this.player.TabIndex = 1;
            // 
            // cmdEnter
            // 
            this.cmdEnter.Location = new System.Drawing.Point(12, 303);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(147, 39);
            this.cmdEnter.TabIndex = 2;
            this.cmdEnter.Text = "E&nter Park";
            this.cmdEnter.UseVisualStyleBackColor = true;
            this.cmdEnter.Click += new System.EventHandler(this.cmdEnter_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(174, 303);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(147, 39);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "E&xit Park";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(503, 12);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(290, 370);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "";
            // 
            // cmdUndo
            // 
            this.cmdUndo.Location = new System.Drawing.Point(337, 303);
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.Size = new System.Drawing.Size(147, 39);
            this.cmdUndo.TabIndex = 6;
            this.cmdUndo.Text = "Undo (&Z)";
            this.cmdUndo.UseVisualStyleBackColor = true;
            this.cmdUndo.Click += new System.EventHandler(this.cmdUndo_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(12, 400);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(147, 39);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(174, 400);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(147, 39);
            this.cmdOpen.TabIndex = 8;
            this.cmdOpen.Text = "Open Video";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Playback Speed:";
            // 
            // txtPlaybackSpeed
            // 
            this.txtPlaybackSpeed.Location = new System.Drawing.Point(128, 359);
            this.txtPlaybackSpeed.Name = "txtPlaybackSpeed";
            this.txtPlaybackSpeed.Size = new System.Drawing.Size(31, 20);
            this.txtPlaybackSpeed.TabIndex = 10;
            this.txtPlaybackSpeed.Text = "1";
            // 
            // cmdApplyPlayback
            // 
            this.cmdApplyPlayback.Location = new System.Drawing.Point(175, 352);
            this.cmdApplyPlayback.Name = "cmdApplyPlayback";
            this.cmdApplyPlayback.Size = new System.Drawing.Size(70, 29);
            this.cmdApplyPlayback.TabIndex = 11;
            this.cmdApplyPlayback.Text = "Apply";
            this.cmdApplyPlayback.UseVisualStyleBackColor = true;
            this.cmdApplyPlayback.Click += new System.EventHandler(this.cmdApplyPlayback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 451);
            this.Controls.Add(this.cmdApplyPlayback);
            this.Controls.Add(this.txtPlaybackSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdUndo);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdEnter);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "SAM Video Annotator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button cmdEnter;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button cmdUndo;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaybackSpeed;
        private System.Windows.Forms.Button cmdApplyPlayback;
    }
}

