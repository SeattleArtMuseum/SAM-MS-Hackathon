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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventName2 = new System.Windows.Forms.TextBox();
            this.eventName = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.cmdStartVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
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
            this.splitContainer1.Size = new System.Drawing.Size(1120, 552);
            this.splitContainer1.SplitterDistance = 551;
            this.splitContainer1.TabIndex = 0;
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 167);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(551, 385);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseClick);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.eventName2);
            this.panel1.Controls.Add(this.eventName);
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.fileNameTextBox);
            this.panel1.Controls.Add(this.cmdStartVideo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 167);
            this.panel1.TabIndex = 0;
            // 
            // eventName2
            // 
            this.eventName2.Location = new System.Drawing.Point(118, 58);
            this.eventName2.Name = "eventName2";
            this.eventName2.Size = new System.Drawing.Size(149, 20);
            this.eventName2.TabIndex = 26;
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Location = new System.Drawing.Point(12, 59);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(106, 13);
            this.eventName.TabIndex = 25;
            this.eventName.Text = "2) Enter Event Name";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(273, 8);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(90, 30);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse Video";
            this.browse.Click += new System.EventHandler(this.BrowseForFile);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(118, 12);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.fileNameTextBox.TabIndex = 24;
            // 
            // cmdStartVideo
            // 
            this.cmdStartVideo.Location = new System.Drawing.Point(118, 97);
            this.cmdStartVideo.Name = "cmdStartVideo";
            this.cmdStartVideo.Size = new System.Drawing.Size(82, 30);
            this.cmdStartVideo.TabIndex = 8;
            this.cmdStartVideo.Text = "Annotate";
            this.cmdStartVideo.UseVisualStyleBackColor = true;
            this.cmdStartVideo.Click += new System.EventHandler(this.cmdStartVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1) Select Video Folder";
            // 
            // cmdStopFrame
            // 
            this.cmdStopFrame.Location = new System.Drawing.Point(505, 111);
            this.cmdStopFrame.Name = "cmdStopFrame";
            this.cmdStopFrame.Size = new System.Drawing.Size(54, 30);
            this.cmdStopFrame.TabIndex = 33;
            this.cmdStopFrame.Text = "Ok";
            this.cmdStopFrame.UseVisualStyleBackColor = true;
            this.cmdStopFrame.Visible = false;
            this.cmdStopFrame.Click += new System.EventHandler(this.cmdStopFrame_Click);
            // 
            // txtStopFrame
            // 
            this.txtStopFrame.Location = new System.Drawing.Point(465, 113);
            this.txtStopFrame.Name = "txtStopFrame";
            this.txtStopFrame.Size = new System.Drawing.Size(34, 20);
            this.txtStopFrame.TabIndex = 32;
            this.txtStopFrame.Visible = false;
            // 
            // cmdCompare
            // 
            this.cmdCompare.Location = new System.Drawing.Point(453, 400);
            this.cmdCompare.Name = "cmdCompare";
            this.cmdCompare.Size = new System.Drawing.Size(109, 30);
            this.cmdCompare.TabIndex = 9;
            this.cmdCompare.Text = "Compare Results";
            this.cmdCompare.UseVisualStyleBackColor = true;
            this.cmdCompare.Visible = false;
            this.cmdCompare.Click += new System.EventHandler(this.cmdCompare_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Stop at Frame:";
            this.label5.Visible = false;
            // 
            // cmdSkipToFrame
            // 
            this.cmdSkipToFrame.Location = new System.Drawing.Point(327, 109);
            this.cmdSkipToFrame.Name = "cmdSkipToFrame";
            this.cmdSkipToFrame.Size = new System.Drawing.Size(54, 30);
            this.cmdSkipToFrame.TabIndex = 30;
            this.cmdSkipToFrame.Text = "Go";
            this.cmdSkipToFrame.UseVisualStyleBackColor = true;
            this.cmdSkipToFrame.Visible = false;
            this.cmdSkipToFrame.Click += new System.EventHandler(this.cmdSkipToFrame_Click);
            // 
            // txtSkipToFrame
            // 
            this.txtSkipToFrame.Location = new System.Drawing.Point(287, 115);
            this.txtSkipToFrame.Name = "txtSkipToFrame";
            this.txtSkipToFrame.Size = new System.Drawing.Size(34, 20);
            this.txtSkipToFrame.TabIndex = 29;
            this.txtSkipToFrame.Visible = false;
            // 
            // lblSkipToFrame
            // 
            this.lblSkipToFrame.AutoSize = true;
            this.lblSkipToFrame.Location = new System.Drawing.Point(206, 116);
            this.lblSkipToFrame.Name = "lblSkipToFrame";
            this.lblSkipToFrame.Size = new System.Drawing.Size(75, 13);
            this.lblSkipToFrame.TabIndex = 28;
            this.lblSkipToFrame.Text = "Skip to Frame:";
            this.lblSkipToFrame.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(6, 167);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 27;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(113, 167);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 26;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // messaging
            // 
            this.messaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messaging.Location = new System.Drawing.Point(3, 58);
            this.messaging.Multiline = true;
            this.messaging.Name = "messaging";
            this.messaging.Size = new System.Drawing.Size(560, 109);
            this.messaging.TabIndex = 25;
            this.messaging.Visible = false;
            // 
            // chkHuman
            // 
            this.chkHuman.AutoSize = true;
            this.chkHuman.Checked = true;
            this.chkHuman.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHuman.Location = new System.Drawing.Point(445, 225);
            this.chkHuman.Name = "chkHuman";
            this.chkHuman.Size = new System.Drawing.Size(60, 17);
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
            this.chkMachineFilter.Location = new System.Drawing.Point(381, 225);
            this.chkMachineFilter.Name = "chkMachineFilter";
            this.chkMachineFilter.Size = new System.Drawing.Size(67, 17);
            this.chkMachineFilter.TabIndex = 24;
            this.chkMachineFilter.Text = "Machine";
            this.chkMachineFilter.UseVisualStyleBackColor = true;
            this.chkMachineFilter.Visible = false;
            // 
            // cmdCopyItems
            // 
            this.cmdCopyItems.Location = new System.Drawing.Point(430, 364);
            this.cmdCopyItems.Name = "cmdCopyItems";
            this.cmdCopyItems.Size = new System.Drawing.Size(63, 30);
            this.cmdCopyItems.TabIndex = 23;
            this.cmdCopyItems.Text = "Copy";
            this.cmdCopyItems.UseVisualStyleBackColor = true;
            this.cmdCopyItems.Visible = false;
            this.cmdCopyItems.Click += new System.EventHandler(this.cmdCopyItems_Click);
            // 
            // lstCompare
            // 
            this.lstCompare.FormattingEnabled = true;
            this.lstCompare.Location = new System.Drawing.Point(3, 302);
            this.lstCompare.Name = "lstCompare";
            this.lstCompare.ScrollAlwaysVisible = true;
            this.lstCompare.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCompare.Size = new System.Drawing.Size(556, 56);
            this.lstCompare.TabIndex = 22;
            this.lstCompare.Visible = false;
            // 
            // cmdHighlight
            // 
            this.cmdHighlight.Location = new System.Drawing.Point(499, 364);
            this.cmdHighlight.Name = "cmdHighlight";
            this.cmdHighlight.Size = new System.Drawing.Size(63, 30);
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
            this.lblMachineExit.Location = new System.Drawing.Point(98, 373);
            this.lblMachineExit.Name = "lblMachineExit";
            this.lblMachineExit.Size = new System.Drawing.Size(69, 13);
            this.lblMachineExit.TabIndex = 20;
            this.lblMachineExit.Text = "Human Enter";
            this.lblMachineExit.Visible = false;
            // 
            // lblMachineEnter
            // 
            this.lblMachineEnter.AutoSize = true;
            this.lblMachineEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMachineEnter.Location = new System.Drawing.Point(98, 396);
            this.lblMachineEnter.Name = "lblMachineEnter";
            this.lblMachineEnter.Size = new System.Drawing.Size(61, 13);
            this.lblMachineEnter.TabIndex = 19;
            this.lblMachineEnter.Text = "Human Exit";
            this.lblMachineEnter.Visible = false;
            // 
            // lblHumanExit
            // 
            this.lblHumanExit.AutoSize = true;
            this.lblHumanExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHumanExit.Location = new System.Drawing.Point(3, 373);
            this.lblHumanExit.Name = "lblHumanExit";
            this.lblHumanExit.Size = new System.Drawing.Size(76, 13);
            this.lblHumanExit.TabIndex = 18;
            this.lblHumanExit.Text = "Machine Enter";
            this.lblHumanExit.Visible = false;
            // 
            // lblHumanEnter
            // 
            this.lblHumanEnter.AutoSize = true;
            this.lblHumanEnter.ForeColor = System.Drawing.Color.Lime;
            this.lblHumanEnter.Location = new System.Drawing.Point(3, 396);
            this.lblHumanEnter.Name = "lblHumanEnter";
            this.lblHumanEnter.Size = new System.Drawing.Size(68, 13);
            this.lblHumanEnter.TabIndex = 17;
            this.lblHumanEnter.Text = "Machine Exit";
            this.lblHumanEnter.Visible = false;
            // 
            // chkExitFilter
            // 
            this.chkExitFilter.AutoSize = true;
            this.chkExitFilter.Checked = true;
            this.chkExitFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExitFilter.Location = new System.Drawing.Point(332, 225);
            this.chkExitFilter.Name = "chkExitFilter";
            this.chkExitFilter.Size = new System.Drawing.Size(43, 17);
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
            this.chkEnterFilter.Location = new System.Drawing.Point(284, 225);
            this.chkEnterFilter.Name = "chkEnterFilter";
            this.chkEnterFilter.Size = new System.Drawing.Size(51, 17);
            this.chkEnterFilter.TabIndex = 15;
            this.chkEnterFilter.Text = "Enter";
            this.chkEnterFilter.UseVisualStyleBackColor = true;
            this.chkEnterFilter.Visible = false;
            // 
            // cmdApplyFrameFilter
            // 
            this.cmdApplyFrameFilter.Location = new System.Drawing.Point(505, 213);
            this.cmdApplyFrameFilter.Name = "cmdApplyFrameFilter";
            this.cmdApplyFrameFilter.Size = new System.Drawing.Size(54, 30);
            this.cmdApplyFrameFilter.TabIndex = 14;
            this.cmdApplyFrameFilter.Text = "Apply";
            this.cmdApplyFrameFilter.UseVisualStyleBackColor = true;
            this.cmdApplyFrameFilter.Visible = false;
            this.cmdApplyFrameFilter.Click += new System.EventHandler(this.cmdApplyFrameFilter_Click);
            // 
            // txtMaxFrame
            // 
            this.txtMaxFrame.Location = new System.Drawing.Point(239, 226);
            this.txtMaxFrame.Name = "txtMaxFrame";
            this.txtMaxFrame.Size = new System.Drawing.Size(29, 20);
            this.txtMaxFrame.TabIndex = 13;
            this.txtMaxFrame.Visible = false;
            // 
            // txtMinFrame
            // 
            this.txtMinFrame.Location = new System.Drawing.Point(101, 226);
            this.txtMinFrame.Name = "txtMinFrame";
            this.txtMinFrame.Size = new System.Drawing.Size(29, 20);
            this.txtMinFrame.TabIndex = 12;
            this.txtMinFrame.Visible = false;
            // 
            // lblMaxFrame
            // 
            this.lblMaxFrame.AutoSize = true;
            this.lblMaxFrame.Location = new System.Drawing.Point(136, 229);
            this.lblMaxFrame.Name = "lblMaxFrame";
            this.lblMaxFrame.Size = new System.Drawing.Size(100, 13);
            this.lblMaxFrame.TabIndex = 11;
            this.lblMaxFrame.Text = "Max Frame (10 fps):";
            this.lblMaxFrame.Visible = false;
            // 
            // lblMinFrame
            // 
            this.lblMinFrame.AutoSize = true;
            this.lblMinFrame.Location = new System.Drawing.Point(3, 229);
            this.lblMinFrame.Name = "lblMinFrame";
            this.lblMinFrame.Size = new System.Drawing.Size(97, 13);
            this.lblMinFrame.TabIndex = 10;
            this.lblMinFrame.Text = "Min Frame (10 fps):";
            this.lblMinFrame.Visible = false;
            // 
            // txtCompareSummary
            // 
            this.txtCompareSummary.Location = new System.Drawing.Point(2, 249);
            this.txtCompareSummary.Multiline = true;
            this.txtCompareSummary.Name = "txtCompareSummary";
            this.txtCompareSummary.Size = new System.Drawing.Size(560, 45);
            this.txtCompareSummary.TabIndex = 9;
            this.txtCompareSummary.Visible = false;
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(3, 420);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(54, 30);
            this.cmdCopy.TabIndex = 8;
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Visible = false;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // txtTrackOutput
            // 
            this.txtTrackOutput.Location = new System.Drawing.Point(6, 456);
            this.txtTrackOutput.Multiline = true;
            this.txtTrackOutput.Name = "txtTrackOutput";
            this.txtTrackOutput.Size = new System.Drawing.Size(560, 93);
            this.txtTrackOutput.TabIndex = 6;
            this.txtTrackOutput.Visible = false;
            // 
            // txtIdDetails
            // 
            this.txtIdDetails.Location = new System.Drawing.Point(3, 199);
            this.txtIdDetails.Name = "txtIdDetails";
            this.txtIdDetails.Size = new System.Drawing.Size(560, 20);
            this.txtIdDetails.TabIndex = 5;
            this.txtIdDetails.Visible = false;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(3, 173);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(560, 20);
            this.txtPosition.TabIndex = 4;
            this.txtPosition.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.Location = new System.Drawing.Point(0, 48);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(565, 504);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 48);
            this.panel2.TabIndex = 0;
            // 
            // chkOnlyBox
            // 
            this.chkOnlyBox.AutoSize = true;
            this.chkOnlyBox.Location = new System.Drawing.Point(279, 12);
            this.chkOnlyBox.Name = "chkOnlyBox";
            this.chkOnlyBox.Size = new System.Drawing.Size(137, 17);
            this.chkOnlyBox.TabIndex = 8;
            this.chkOnlyBox.Text = "Draw Box Only For This";
            this.chkOnlyBox.UseVisualStyleBackColor = true;
            this.chkOnlyBox.Visible = false;
            // 
            // cmdTrackOk
            // 
            this.cmdTrackOk.Location = new System.Drawing.Point(422, 4);
            this.cmdTrackOk.Name = "cmdTrackOk";
            this.cmdTrackOk.Size = new System.Drawing.Size(54, 30);
            this.cmdTrackOk.TabIndex = 7;
            this.cmdTrackOk.Text = "Ok";
            this.cmdTrackOk.UseVisualStyleBackColor = true;
            this.cmdTrackOk.Visible = false;
            this.cmdTrackOk.Click += new System.EventHandler(this.cmdTrackOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Track Id:";
            this.label3.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(209, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(59, 20);
            this.txtId.TabIndex = 5;
            this.txtId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Forground Mask";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "3) Annotate Videos";
            // 
            // VideoSurveilance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 552);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VideoSurveilance";
            this.Text = "VideoSurveilance";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}
