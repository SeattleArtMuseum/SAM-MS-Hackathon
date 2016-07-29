namespace VideoSurveilance
{
    using System.Windows.Forms;

    partial class VideoSurveilance
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmdPlayVideoFromOutput = new System.Windows.Forms.Button();
            this.lstVideoOutput = new System.Windows.Forms.ListBox();
            this.animation = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventEndDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.eventStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eventName2 = new System.Windows.Forms.TextBox();
            this.eventName = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.cmdStartVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SkipButton = new System.Windows.Forms.Button();
            this.cmdStopFrame = new System.Windows.Forms.Button();
            this.txtStopFrame = new System.Windows.Forms.TextBox();
            this.cmdCompare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSkipToFrame = new System.Windows.Forms.Button();
            this.txtSkipToFrame = new System.Windows.Forms.TextBox();
            this.lblSkipToFrame = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.messaging = new System.Windows.Forms.TextBox();
            this.chkHuman = new System.Windows.Forms.CheckBox();
            this.chkMachineFilter = new System.Windows.Forms.CheckBox();
            this.cmdCopyItems = new System.Windows.Forms.Button();
            this.lstCompare = new System.Windows.Forms.ListBox();
            this.cmdHighlight = new System.Windows.Forms.Button();
            this.lblMachineExit = new System.Windows.Forms.Label();
            this.lblMachineEnter = new System.Windows.Forms.Label();
            this.lblHumanExit = new System.Windows.Forms.Label();
            this.lblHumanEnter = new System.Windows.Forms.Label();
            this.chkExitFilter = new System.Windows.Forms.CheckBox();
            this.chkEnterFilter = new System.Windows.Forms.CheckBox();
            this.cmdApplyFrameFilter = new System.Windows.Forms.Button();
            this.txtMaxFrame = new System.Windows.Forms.TextBox();
            this.txtMinFrame = new System.Windows.Forms.TextBox();
            this.lblMaxFrame = new System.Windows.Forms.Label();
            this.lblMinFrame = new System.Windows.Forms.Label();
            this.txtCompareSummary = new System.Windows.Forms.TextBox();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.txtTrackOutput = new System.Windows.Forms.TextBox();
            this.txtIdDetails = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkOnlyBox = new System.Windows.Forms.CheckBox();
            this.cmdTrackOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.cmdPlayVideoFromOutput);
            this.splitContainer1.Panel1.Controls.Add(this.lstVideoOutput);
            this.splitContainer1.Panel1.Controls.Add(this.animation);
            this.splitContainer1.Panel1.Controls.Add(this.imageBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SkipButton);
            this.splitContainer1.Panel2.Controls.Add(this.cmdStopFrame);
            this.splitContainer1.Panel2.Controls.Add(this.txtStopFrame);
            this.splitContainer1.Panel2.Controls.Add(this.cmdCompare);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.cmdSkipToFrame);
            this.splitContainer1.Panel2.Controls.Add(this.txtSkipToFrame);
            this.splitContainer1.Panel2.Controls.Add(this.lblSkipToFrame);
            this.splitContainer1.Panel2.Controls.Add(this.resetButton);
            this.splitContainer1.Panel2.Controls.Add(this.continueButton);
            this.splitContainer1.Panel2.Controls.Add(this.messaging);
            this.splitContainer1.Panel2.Controls.Add(this.chkHuman);
            this.splitContainer1.Panel2.Controls.Add(this.chkMachineFilter);
            this.splitContainer1.Panel2.Controls.Add(this.cmdCopyItems);
            this.splitContainer1.Panel2.Controls.Add(this.lstCompare);
            this.splitContainer1.Panel2.Controls.Add(this.cmdHighlight);
            this.splitContainer1.Panel2.Controls.Add(this.lblMachineExit);
            this.splitContainer1.Panel2.Controls.Add(this.lblMachineEnter);
            this.splitContainer1.Panel2.Controls.Add(this.lblHumanExit);
            this.splitContainer1.Panel2.Controls.Add(this.lblHumanEnter);
            this.splitContainer1.Panel2.Controls.Add(this.chkExitFilter);
            this.splitContainer1.Panel2.Controls.Add(this.chkEnterFilter);
            this.splitContainer1.Panel2.Controls.Add(this.cmdApplyFrameFilter);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaxFrame);
            this.splitContainer1.Panel2.Controls.Add(this.txtMinFrame);
            this.splitContainer1.Panel2.Controls.Add(this.lblMaxFrame);
            this.splitContainer1.Panel2.Controls.Add(this.lblMinFrame);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompareSummary);
            this.splitContainer1.Panel2.Controls.Add(this.cmdCopy);
            this.splitContainer1.Panel2.Controls.Add(this.txtTrackOutput);
            this.splitContainer1.Panel2.Controls.Add(this.txtIdDetails);
            this.splitContainer1.Panel2.Controls.Add(this.txtPosition);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.imageBox2);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(2232, 1061);
            this.splitContainer1.SplitterDistance = 1096;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 446);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 4;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 408);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(759, 35);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // cmdPlayVideoFromOutput
            // 
            this.cmdPlayVideoFromOutput.Location = new System.Drawing.Point(623, 634);
            this.cmdPlayVideoFromOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdPlayVideoFromOutput.Name = "cmdPlayVideoFromOutput";
            this.cmdPlayVideoFromOutput.Size = new System.Drawing.Size(104, 38);
            this.cmdPlayVideoFromOutput.TabIndex = 39;
            this.cmdPlayVideoFromOutput.Text = "Play Video";
            this.cmdPlayVideoFromOutput.UseVisualStyleBackColor = true;
            this.cmdPlayVideoFromOutput.Visible = false;
            this.cmdPlayVideoFromOutput.Click += new System.EventHandler(this.cmdPlayVideoFromOutput_Click_1);
            // 
            // lstVideoOutput
            // 
            this.lstVideoOutput.FormattingEnabled = true;
            this.lstVideoOutput.ItemHeight = 25;
            this.lstVideoOutput.Location = new System.Drawing.Point(0, 556);
            this.lstVideoOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVideoOutput.Name = "lstVideoOutput";
            this.lstVideoOutput.ScrollAlwaysVisible = true;
            this.lstVideoOutput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstVideoOutput.Size = new System.Drawing.Size(725, 54);
            this.lstVideoOutput.TabIndex = 38;
            this.lstVideoOutput.Visible = false;
            // 
            // animation
            // 
            this.animation.Location = new System.Drawing.Point(16, 270);
            this.animation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.animation.Name = "animation";
            this.animation.Size = new System.Drawing.Size(351, 268);
            this.animation.TabIndex = 33;
            this.animation.TabStop = false;
            this.animation.Visible = false;
            // 
            // imageBox1
            // 
            this.imageBox1.BackgroundImage = global::VideoSurveilance.Properties.Resources.MS_Hard_Pavement;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 396);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1096, 665);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseClick);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eventEndDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.eventStartDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.eventName2);
            this.panel1.Controls.Add(this.eventName);
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.fileNameTextBox);
            this.panel1.Controls.Add(this.cmdStartVideo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 396);
            this.panel1.TabIndex = 0;
            // 
            // eventEndDate
            // 
            this.eventEndDate.Location = new System.Drawing.Point(259, 239);
            this.eventEndDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.eventEndDate.Name = "eventEndDate";
            this.eventEndDate.Size = new System.Drawing.Size(364, 31);
            this.eventEndDate.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "4) Event End Date";
            // 
            // eventStartDate
            // 
            this.eventStartDate.Location = new System.Drawing.Point(259, 189);
            this.eventStartDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.eventStartDate.Name = "eventStartDate";
            this.eventStartDate.Size = new System.Drawing.Size(364, 31);
            this.eventStartDate.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "3) Event Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "5) Annotate Videos";
            // 
            // eventName2
            // 
            this.eventName2.Location = new System.Drawing.Point(259, 111);
            this.eventName2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.eventName2.Name = "eventName2";
            this.eventName2.Size = new System.Drawing.Size(295, 31);
            this.eventName2.TabIndex = 26;
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Location = new System.Drawing.Point(24, 114);
            this.eventName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(211, 25);
            this.eventName.TabIndex = 25;
            this.eventName.Text = "2) Enter Event Name";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(572, 11);
            this.browse.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(180, 58);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse Video";
            this.browse.Click += new System.EventHandler(this.BrowseForFile);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(259, 25);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(295, 31);
            this.fileNameTextBox.TabIndex = 24;
            // 
            // cmdStartVideo
            // 
            this.cmdStartVideo.Location = new System.Drawing.Point(259, 296);
            this.cmdStartVideo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdStartVideo.Name = "cmdStartVideo";
            this.cmdStartVideo.Size = new System.Drawing.Size(164, 58);
            this.cmdStartVideo.TabIndex = 8;
            this.cmdStartVideo.Text = "Annotate";
            this.cmdStartVideo.UseVisualStyleBackColor = true;
            this.cmdStartVideo.Click += new System.EventHandler(this.cmdStartVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1) Select Video Folder";
            // 
            // SkipButton
            // 
            this.SkipButton.Location = new System.Drawing.Point(445, 321);
            this.SkipButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(149, 44);
            this.SkipButton.TabIndex = 34;
            this.SkipButton.Text = "Skip";
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Visible = false;
            this.SkipButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdStopFrame
            // 
            this.cmdStopFrame.Location = new System.Drawing.Point(1011, 214);
            this.cmdStopFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdStopFrame.Name = "cmdStopFrame";
            this.cmdStopFrame.Size = new System.Drawing.Size(108, 58);
            this.cmdStopFrame.TabIndex = 33;
            this.cmdStopFrame.Text = "Ok";
            this.cmdStopFrame.UseVisualStyleBackColor = true;
            this.cmdStopFrame.Visible = false;
            this.cmdStopFrame.Click += new System.EventHandler(this.cmdStopFrame_Click);
            // 
            // txtStopFrame
            // 
            this.txtStopFrame.Location = new System.Drawing.Point(931, 218);
            this.txtStopFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStopFrame.Name = "txtStopFrame";
            this.txtStopFrame.Size = new System.Drawing.Size(64, 31);
            this.txtStopFrame.TabIndex = 32;
            this.txtStopFrame.Visible = false;
            // 
            // cmdCompare
            // 
            this.cmdCompare.Location = new System.Drawing.Point(907, 769);
            this.cmdCompare.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdCompare.Name = "cmdCompare";
            this.cmdCompare.Size = new System.Drawing.Size(219, 58);
            this.cmdCompare.TabIndex = 9;
            this.cmdCompare.Text = "Compare Results";
            this.cmdCompare.UseVisualStyleBackColor = true;
            this.cmdCompare.Visible = false;
            this.cmdCompare.Click += new System.EventHandler(this.cmdCompare_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(773, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Stop at Frame:";
            this.label5.Visible = false;
            // 
            // cmdSkipToFrame
            // 
            this.cmdSkipToFrame.Location = new System.Drawing.Point(653, 210);
            this.cmdSkipToFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdSkipToFrame.Name = "cmdSkipToFrame";
            this.cmdSkipToFrame.Size = new System.Drawing.Size(108, 58);
            this.cmdSkipToFrame.TabIndex = 30;
            this.cmdSkipToFrame.Text = "Go";
            this.cmdSkipToFrame.UseVisualStyleBackColor = true;
            this.cmdSkipToFrame.Visible = false;
            this.cmdSkipToFrame.Click += new System.EventHandler(this.cmdSkipToFrame_Click);
            // 
            // txtSkipToFrame
            // 
            this.txtSkipToFrame.Location = new System.Drawing.Point(573, 221);
            this.txtSkipToFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSkipToFrame.Name = "txtSkipToFrame";
            this.txtSkipToFrame.Size = new System.Drawing.Size(64, 31);
            this.txtSkipToFrame.TabIndex = 29;
            this.txtSkipToFrame.Visible = false;
            // 
            // lblSkipToFrame
            // 
            this.lblSkipToFrame.AutoSize = true;
            this.lblSkipToFrame.Location = new System.Drawing.Point(412, 222);
            this.lblSkipToFrame.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSkipToFrame.Name = "lblSkipToFrame";
            this.lblSkipToFrame.Size = new System.Drawing.Size(151, 25);
            this.lblSkipToFrame.TabIndex = 28;
            this.lblSkipToFrame.Text = "Skip to Frame:";
            this.lblSkipToFrame.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 321);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(149, 44);
            this.resetButton.TabIndex = 27;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(227, 321);
            this.continueButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(149, 44);
            this.continueButton.TabIndex = 26;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // messaging
            // 
            this.messaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messaging.Location = new System.Drawing.Point(5, 111);
            this.messaging.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.messaging.Multiline = true;
            this.messaging.Name = "messaging";
            this.messaging.ReadOnly = true;
            this.messaging.Size = new System.Drawing.Size(1116, 206);
            this.messaging.TabIndex = 25;
            this.messaging.Visible = false;
            // 
            // chkHuman
            // 
            this.chkHuman.AutoSize = true;
            this.chkHuman.Checked = true;
            this.chkHuman.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHuman.Location = new System.Drawing.Point(891, 432);
            this.chkHuman.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkHuman.Name = "chkHuman";
            this.chkHuman.Size = new System.Drawing.Size(112, 29);
            this.chkHuman.TabIndex = 25;
            this.chkHuman.Text = "Human";
            this.chkHuman.UseVisualStyleBackColor = true;
            this.chkHuman.Visible = false;
            // 
            // chkMachineFilter
            // 
            this.chkMachineFilter.AutoSize = true;
            this.chkMachineFilter.Checked = true;
            this.chkMachineFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMachineFilter.Location = new System.Drawing.Point(763, 432);
            this.chkMachineFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkMachineFilter.Name = "chkMachineFilter";
            this.chkMachineFilter.Size = new System.Drawing.Size(126, 29);
            this.chkMachineFilter.TabIndex = 24;
            this.chkMachineFilter.Text = "Machine";
            this.chkMachineFilter.UseVisualStyleBackColor = true;
            this.chkMachineFilter.Visible = false;
            // 
            // cmdCopyItems
            // 
            this.cmdCopyItems.Location = new System.Drawing.Point(860, 700);
            this.cmdCopyItems.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdCopyItems.Name = "cmdCopyItems";
            this.cmdCopyItems.Size = new System.Drawing.Size(125, 58);
            this.cmdCopyItems.TabIndex = 23;
            this.cmdCopyItems.Text = "Copy";
            this.cmdCopyItems.UseVisualStyleBackColor = true;
            this.cmdCopyItems.Visible = false;
            this.cmdCopyItems.Click += new System.EventHandler(this.cmdCopyItems_Click);
            // 
            // lstCompare
            // 
            this.lstCompare.FormattingEnabled = true;
            this.lstCompare.ItemHeight = 25;
            this.lstCompare.Location = new System.Drawing.Point(5, 581);
            this.lstCompare.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstCompare.Name = "lstCompare";
            this.lstCompare.ScrollAlwaysVisible = true;
            this.lstCompare.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCompare.Size = new System.Drawing.Size(1108, 104);
            this.lstCompare.TabIndex = 22;
            this.lstCompare.Visible = false;
            // 
            // cmdHighlight
            // 
            this.cmdHighlight.Location = new System.Drawing.Point(997, 700);
            this.cmdHighlight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdHighlight.Name = "cmdHighlight";
            this.cmdHighlight.Size = new System.Drawing.Size(125, 58);
            this.cmdHighlight.TabIndex = 21;
            this.cmdHighlight.Text = "Highlight";
            this.cmdHighlight.UseVisualStyleBackColor = true;
            this.cmdHighlight.Visible = false;
            this.cmdHighlight.Click += new System.EventHandler(this.cmdHighlight_Click);
            // 
            // lblMachineExit
            // 
            this.lblMachineExit.AutoSize = true;
            this.lblMachineExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMachineExit.Location = new System.Drawing.Point(196, 718);
            this.lblMachineExit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMachineExit.Name = "lblMachineExit";
            this.lblMachineExit.Size = new System.Drawing.Size(137, 25);
            this.lblMachineExit.TabIndex = 20;
            this.lblMachineExit.Text = "Human Enter";
            this.lblMachineExit.Visible = false;
            // 
            // lblMachineEnter
            // 
            this.lblMachineEnter.AutoSize = true;
            this.lblMachineEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMachineEnter.Location = new System.Drawing.Point(196, 761);
            this.lblMachineEnter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMachineEnter.Name = "lblMachineEnter";
            this.lblMachineEnter.Size = new System.Drawing.Size(122, 25);
            this.lblMachineEnter.TabIndex = 19;
            this.lblMachineEnter.Text = "Human Exit";
            this.lblMachineEnter.Visible = false;
            // 
            // lblHumanExit
            // 
            this.lblHumanExit.AutoSize = true;
            this.lblHumanExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHumanExit.Location = new System.Drawing.Point(5, 718);
            this.lblHumanExit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHumanExit.Name = "lblHumanExit";
            this.lblHumanExit.Size = new System.Drawing.Size(151, 25);
            this.lblHumanExit.TabIndex = 18;
            this.lblHumanExit.Text = "Machine Enter";
            this.lblHumanExit.Visible = false;
            // 
            // lblHumanEnter
            // 
            this.lblHumanEnter.AutoSize = true;
            this.lblHumanEnter.ForeColor = System.Drawing.Color.Lime;
            this.lblHumanEnter.Location = new System.Drawing.Point(5, 761);
            this.lblHumanEnter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHumanEnter.Name = "lblHumanEnter";
            this.lblHumanEnter.Size = new System.Drawing.Size(136, 25);
            this.lblHumanEnter.TabIndex = 17;
            this.lblHumanEnter.Text = "Machine Exit";
            this.lblHumanEnter.Visible = false;
            // 
            // chkExitFilter
            // 
            this.chkExitFilter.AutoSize = true;
            this.chkExitFilter.Checked = true;
            this.chkExitFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExitFilter.Location = new System.Drawing.Point(664, 432);
            this.chkExitFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkExitFilter.Name = "chkExitFilter";
            this.chkExitFilter.Size = new System.Drawing.Size(80, 29);
            this.chkExitFilter.TabIndex = 16;
            this.chkExitFilter.Text = "Exit";
            this.chkExitFilter.UseVisualStyleBackColor = true;
            this.chkExitFilter.Visible = false;
            // 
            // chkEnterFilter
            // 
            this.chkEnterFilter.AutoSize = true;
            this.chkEnterFilter.Checked = true;
            this.chkEnterFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnterFilter.Location = new System.Drawing.Point(568, 432);
            this.chkEnterFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkEnterFilter.Name = "chkEnterFilter";
            this.chkEnterFilter.Size = new System.Drawing.Size(95, 29);
            this.chkEnterFilter.TabIndex = 15;
            this.chkEnterFilter.Text = "Enter";
            this.chkEnterFilter.UseVisualStyleBackColor = true;
            this.chkEnterFilter.Visible = false;
            // 
            // cmdApplyFrameFilter
            // 
            this.cmdApplyFrameFilter.Location = new System.Drawing.Point(1011, 410);
            this.cmdApplyFrameFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdApplyFrameFilter.Name = "cmdApplyFrameFilter";
            this.cmdApplyFrameFilter.Size = new System.Drawing.Size(108, 58);
            this.cmdApplyFrameFilter.TabIndex = 14;
            this.cmdApplyFrameFilter.Text = "Apply";
            this.cmdApplyFrameFilter.UseVisualStyleBackColor = true;
            this.cmdApplyFrameFilter.Visible = false;
            this.cmdApplyFrameFilter.Click += new System.EventHandler(this.cmdApplyFrameFilter_Click);
            // 
            // txtMaxFrame
            // 
            this.txtMaxFrame.Location = new System.Drawing.Point(477, 435);
            this.txtMaxFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaxFrame.Name = "txtMaxFrame";
            this.txtMaxFrame.Size = new System.Drawing.Size(55, 31);
            this.txtMaxFrame.TabIndex = 13;
            this.txtMaxFrame.Visible = false;
            // 
            // txtMinFrame
            // 
            this.txtMinFrame.Location = new System.Drawing.Point(203, 435);
            this.txtMinFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMinFrame.Name = "txtMinFrame";
            this.txtMinFrame.Size = new System.Drawing.Size(55, 31);
            this.txtMinFrame.TabIndex = 12;
            this.txtMinFrame.Visible = false;
            // 
            // lblMaxFrame
            // 
            this.lblMaxFrame.AutoSize = true;
            this.lblMaxFrame.Location = new System.Drawing.Point(272, 440);
            this.lblMaxFrame.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaxFrame.Name = "lblMaxFrame";
            this.lblMaxFrame.Size = new System.Drawing.Size(205, 25);
            this.lblMaxFrame.TabIndex = 11;
            this.lblMaxFrame.Text = "Max Frame (10 fps):";
            this.lblMaxFrame.Visible = false;
            // 
            // lblMinFrame
            // 
            this.lblMinFrame.AutoSize = true;
            this.lblMinFrame.Location = new System.Drawing.Point(5, 440);
            this.lblMinFrame.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMinFrame.Name = "lblMinFrame";
            this.lblMinFrame.Size = new System.Drawing.Size(199, 25);
            this.lblMinFrame.TabIndex = 10;
            this.lblMinFrame.Text = "Min Frame (10 fps):";
            this.lblMinFrame.Visible = false;
            // 
            // txtCompareSummary
            // 
            this.txtCompareSummary.Location = new System.Drawing.Point(4, 479);
            this.txtCompareSummary.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCompareSummary.Multiline = true;
            this.txtCompareSummary.Name = "txtCompareSummary";
            this.txtCompareSummary.Size = new System.Drawing.Size(1116, 83);
            this.txtCompareSummary.TabIndex = 9;
            this.txtCompareSummary.Visible = false;
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(5, 808);
            this.cmdCopy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(108, 58);
            this.cmdCopy.TabIndex = 8;
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Visible = false;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // txtTrackOutput
            // 
            this.txtTrackOutput.Location = new System.Drawing.Point(12, 878);
            this.txtTrackOutput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTrackOutput.Multiline = true;
            this.txtTrackOutput.Name = "txtTrackOutput";
            this.txtTrackOutput.Size = new System.Drawing.Size(1116, 175);
            this.txtTrackOutput.TabIndex = 6;
            this.txtTrackOutput.Visible = false;
            // 
            // txtIdDetails
            // 
            this.txtIdDetails.Location = new System.Drawing.Point(5, 382);
            this.txtIdDetails.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdDetails.Name = "txtIdDetails";
            this.txtIdDetails.Size = new System.Drawing.Size(1116, 31);
            this.txtIdDetails.TabIndex = 5;
            this.txtIdDetails.Visible = false;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(5, 332);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(1116, 31);
            this.txtPosition.TabIndex = 4;
            this.txtPosition.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 282);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1116, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.Location = new System.Drawing.Point(0, 92);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(1128, 969);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkOnlyBox);
            this.panel2.Controls.Add(this.cmdTrackOk);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 92);
            this.panel2.TabIndex = 0;
            // 
            // chkOnlyBox
            // 
            this.chkOnlyBox.AutoSize = true;
            this.chkOnlyBox.Location = new System.Drawing.Point(557, 22);
            this.chkOnlyBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkOnlyBox.Name = "chkOnlyBox";
            this.chkOnlyBox.Size = new System.Drawing.Size(271, 29);
            this.chkOnlyBox.TabIndex = 8;
            this.chkOnlyBox.Text = "Draw Box Only For This";
            this.chkOnlyBox.UseVisualStyleBackColor = true;
            this.chkOnlyBox.Visible = false;
            // 
            // cmdTrackOk
            // 
            this.cmdTrackOk.Location = new System.Drawing.Point(844, 8);
            this.cmdTrackOk.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmdTrackOk.Name = "cmdTrackOk";
            this.cmdTrackOk.Size = new System.Drawing.Size(108, 58);
            this.cmdTrackOk.TabIndex = 7;
            this.cmdTrackOk.Text = "Ok";
            this.cmdTrackOk.UseVisualStyleBackColor = true;
            this.cmdTrackOk.Visible = false;
            this.cmdTrackOk.Click += new System.EventHandler(this.cmdTrackOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Track Id:";
            this.label3.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(419, 19);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(113, 31);
            this.txtId.TabIndex = 5;
            this.txtId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Forground Mask";
            this.label2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 32;
            // 
            // VideoSurveilance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2232, 1061);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VideoSurveilance";
            this.Text = "VideoSurveilance";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private Emgu.CV.UI.ImageBox imageBox1;
      private System.Windows.Forms.Label label1;
      private Emgu.CV.UI.ImageBox imageBox2;
      private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPosition;
        private TextBox txtIdDetails;
        private Button cmdTrackOk;
        private Label label3;
        private TextBox txtId;
        private TextBox txtTrackOutput;
        private Button cmdCopy;
        private Button cmdCompare;
        private Button cmdStartVideo;
        private Button cmdApplyFrameFilter;
        private TextBox txtMaxFrame;
        private TextBox txtMinFrame;
        private Label lblMaxFrame;
        private Label lblMinFrame;
        private TextBox txtCompareSummary;
        private CheckBox chkExitFilter;
        private CheckBox chkEnterFilter;
        private Label lblMachineExit;
        private Label lblMachineEnter;
        private Label lblHumanExit;
        private Label lblHumanEnter;
        private Button cmdHighlight;
        private ListBox lstCompare;
        private Button cmdCopyItems;
        private TextBox fileNameTextBox;
        private Button browse;
        private TextBox messaging;
        private Button continueButton;
        private Button resetButton;
        private CheckBox chkHuman;
        private CheckBox chkMachineFilter;
        private CheckBox chkOnlyBox;
        private Button cmdSkipToFrame;
        private TextBox txtSkipToFrame;
        private Label lblSkipToFrame;
        private Button cmdStopFrame;
        private TextBox txtStopFrame;
        private Label label5;
        private TextBox eventName2;
        private Label eventName;
        private Label label4;
        private Label label6;
        private DateTimePicker eventEndDate;
        private Label label7;
        private DateTimePicker eventStartDate;
        private Label label8;
        private Button SkipButton;
        private ProgressBar progressBar1;
        private Label label9;
        private PictureBox animation;
        private ListBox lstVideoOutput;
        private Button cmdPlayVideoFromOutput;
    }
}
