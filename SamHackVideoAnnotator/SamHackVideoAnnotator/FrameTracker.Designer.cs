namespace SamHackVideoAnnotator
{
    partial class FrameTracker
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
            this.peoplePanel = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.cmdCancelNew = new System.Windows.Forms.Button();
            this.cmdNewPerson = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.cmdNext = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.cmdPrevFrame = new System.Windows.Forms.Button();
            this.peoplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // peoplePanel
            // 
            this.peoplePanel.AutoScroll = true;
            this.peoplePanel.Controls.Add(this.lblSelected);
            this.peoplePanel.Controls.Add(this.cmdCancelNew);
            this.peoplePanel.Controls.Add(this.cmdNewPerson);
            this.peoplePanel.Location = new System.Drawing.Point(791, 12);
            this.peoplePanel.Name = "peoplePanel";
            this.peoplePanel.Size = new System.Drawing.Size(281, 427);
            this.peoplePanel.TabIndex = 0;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(186, 131);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(13, 13);
            this.lblSelected.TabIndex = 5;
            this.lblSelected.Text = ">";
            this.lblSelected.Visible = false;
            // 
            // cmdCancelNew
            // 
            this.cmdCancelNew.Enabled = false;
            this.cmdCancelNew.Location = new System.Drawing.Point(132, 3);
            this.cmdCancelNew.Name = "cmdCancelNew";
            this.cmdCancelNew.Size = new System.Drawing.Size(113, 37);
            this.cmdCancelNew.TabIndex = 4;
            this.cmdCancelNew.Text = "Cancel New";
            this.cmdCancelNew.UseVisualStyleBackColor = true;
            this.cmdCancelNew.Click += new System.EventHandler(this.cmdCancelNew_Click);
            // 
            // cmdNewPerson
            // 
            this.cmdNewPerson.Location = new System.Drawing.Point(13, 3);
            this.cmdNewPerson.Name = "cmdNewPerson";
            this.cmdNewPerson.Size = new System.Drawing.Size(113, 37);
            this.cmdNewPerson.TabIndex = 3;
            this.cmdNewPerson.Text = "&Add Person";
            this.cmdNewPerson.UseVisualStyleBackColor = true;
            this.cmdNewPerson.Click += new System.EventHandler(this.cmdNewPerson_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(370, 512);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(113, 37);
            this.cmdOpen.TabIndex = 1;
            this.cmdOpen.Text = "Open Video";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(8, 512);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(113, 37);
            this.cmdNext.TabIndex = 2;
            this.cmdNext.Text = "&Next Frame";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(489, 512);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(113, 37);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Save Results";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(8, 15);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(777, 424);
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_Click);
            // 
            // cmdPrevFrame
            // 
            this.cmdPrevFrame.Location = new System.Drawing.Point(127, 512);
            this.cmdPrevFrame.Name = "cmdPrevFrame";
            this.cmdPrevFrame.Size = new System.Drawing.Size(113, 37);
            this.cmdPrevFrame.TabIndex = 5;
            this.cmdPrevFrame.Text = "&Prev Frame";
            this.cmdPrevFrame.UseVisualStyleBackColor = true;
            this.cmdPrevFrame.Click += new System.EventHandler(this.cmdPrevFrame_Click);
            // 
            // FrameTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.cmdPrevFrame);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.peoplePanel);
            this.KeyPreview = true;
            this.Name = "FrameTracker";
            this.Text = "FrameTracker";
            this.Load += new System.EventHandler(this.FrameTracker_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleKey);
            this.peoplePanel.ResumeLayout(false);
            this.peoplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel peoplePanel;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.Button cmdNext;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button cmdNewPerson;
        private System.Windows.Forms.Button cmdCancelNew;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button cmdPrevFrame;
    }
}