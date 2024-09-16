namespace CS_FileSync
{
    partial class Form1
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
            this.btnSourcePath = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDestPath = new System.Windows.Forms.Button();
            this.tbSourcePath = new System.Windows.Forms.TextBox();
            this.tbDestPath = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.tbCopy = new System.Windows.Forms.TextBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbAction = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnGetRemove = new System.Windows.Forms.Button();
            this.btnDirSize = new System.Windows.Forms.Button();
            this.btnEmptyDirs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oprionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSkipped = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFiles = new System.Windows.Forms.TextBox();
            this.cbAppendSourcePath = new System.Windows.Forms.CheckBox();
            this.cbDestDrive = new System.Windows.Forms.ComboBox();
            this.tbExceptions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbExists = new System.Windows.Forms.TextBox();
            this.cbBreak = new System.Windows.Forms.CheckBox();
            this.cbVerbose = new System.Windows.Forms.CheckBox();
            this.tbRemoved = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSourcePath.Location = new System.Drawing.Point(63, 79);
            this.btnSourcePath.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(184, 55);
            this.btnSourcePath.TabIndex = 0;
            this.btnSourcePath.Text = "source";
            this.toolTip1.SetToolTip(this.btnSourcePath, "optionally drag folder to textbox");
            this.btnSourcePath.UseVisualStyleBackColor = false;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logBox.Location = new System.Drawing.Point(63, 440);
            this.logBox.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(1769, 876);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            this.toolTip1.SetToolTip(this.logBox, "copy or replace files in destination path");
            // 
            // btnDestPath
            // 
            this.btnDestPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDestPath.Location = new System.Drawing.Point(63, 151);
            this.btnDestPath.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDestPath.Name = "btnDestPath";
            this.btnDestPath.Size = new System.Drawing.Size(184, 55);
            this.btnDestPath.TabIndex = 2;
            this.btnDestPath.Text = "destination";
            this.toolTip1.SetToolTip(this.btnDestPath, "optionally drag folder to textbox");
            this.btnDestPath.UseVisualStyleBackColor = false;
            this.btnDestPath.Click += new System.EventHandler(this.btnDestPath_Click);
            // 
            // tbSourcePath
            // 
            this.tbSourcePath.AllowDrop = true;
            this.tbSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSourcePath.Location = new System.Drawing.Point(271, 86);
            this.tbSourcePath.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbSourcePath.Name = "tbSourcePath";
            this.tbSourcePath.Size = new System.Drawing.Size(1560, 41);
            this.tbSourcePath.TabIndex = 3;
            this.tbSourcePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbSourcePath_DragDrop);
            this.tbSourcePath.DragOver += new System.Windows.Forms.DragEventHandler(this.tbSourcePath_DragOver);
            // 
            // tbDestPath
            // 
            this.tbDestPath.AllowDrop = true;
            this.tbDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDestPath.Location = new System.Drawing.Point(271, 158);
            this.tbDestPath.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbDestPath.Name = "tbDestPath";
            this.tbDestPath.Size = new System.Drawing.Size(1566, 41);
            this.tbDestPath.TabIndex = 4;
            this.tbDestPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbDestPath_DragDrop);
            this.tbDestPath.DragOver += new System.Windows.Forms.DragEventHandler(this.tbDestPath_DragOver);
            // 
            // btnSync
            // 
            this.btnSync.BackColor = System.Drawing.Color.Gold;
            this.btnSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSync.Location = new System.Drawing.Point(271, 214);
            this.btnSync.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(282, 73);
            this.btnSync.TabIndex = 5;
            this.btnSync.Text = "sync to destination";
            this.toolTip1.SetToolTip(this.btnSync, "Copy or replace files in destination folder. \r\nSource folder is not changed");
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // tbCopy
            // 
            this.tbCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCopy.Location = new System.Drawing.Point(1877, 564);
            this.tbCopy.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(106, 37);
            this.tbCopy.TabIndex = 6;
            // 
            // tbReplace
            // 
            this.tbReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReplace.Location = new System.Drawing.Point(1877, 772);
            this.tbReplace.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(106, 37);
            this.tbReplace.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1873, 524);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "copied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1871, 731);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "replaced";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.SpringGreen;
            this.progressBar1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.progressBar1.Location = new System.Drawing.Point(64, 354);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1768, 55);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            // 
            // tbAction
            // 
            this.tbAction.BackColor = System.Drawing.Color.Gold;
            this.tbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAction.Location = new System.Drawing.Point(64, 1353);
            this.tbAction.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbAction.Name = "tbAction";
            this.tbAction.Size = new System.Drawing.Size(1767, 44);
            this.tbAction.TabIndex = 11;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gold;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(866, 213);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(346, 71);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "remove from destination";
            this.toolTip1.SetToolTip(this.btnRemove, "Remove files from destination which\r\ndo not longer exist in source path.");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGetRemove
            // 
            this.btnGetRemove.BackColor = System.Drawing.Color.Gold;
            this.btnGetRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetRemove.Location = new System.Drawing.Point(569, 213);
            this.btnGetRemove.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnGetRemove.Name = "btnGetRemove";
            this.btnGetRemove.Size = new System.Drawing.Size(288, 71);
            this.btnGetRemove.TabIndex = 20;
            this.btnGetRemove.Text = "check files removed";
            this.toolTip1.SetToolTip(this.btnGetRemove, "List files from destination which\r\ndo not longer exist in source path.");
            this.btnGetRemove.UseVisualStyleBackColor = false;
            this.btnGetRemove.Click += new System.EventHandler(this.btnGetRemove_Click);
            // 
            // btnDirSize
            // 
            this.btnDirSize.BackColor = System.Drawing.Color.Gold;
            this.btnDirSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDirSize.Location = new System.Drawing.Point(1558, 212);
            this.btnDirSize.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnDirSize.Name = "btnDirSize";
            this.btnDirSize.Size = new System.Drawing.Size(279, 72);
            this.btnDirSize.TabIndex = 21;
            this.btnDirSize.Text = "show directory size";
            this.toolTip1.SetToolTip(this.btnDirSize, "Show size of source path");
            this.btnDirSize.UseVisualStyleBackColor = false;
            this.btnDirSize.Click += new System.EventHandler(this.btnDirSize_Click);
            // 
            // btnEmptyDirs
            // 
            this.btnEmptyDirs.BackColor = System.Drawing.Color.Gold;
            this.btnEmptyDirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmptyDirs.Location = new System.Drawing.Point(1227, 213);
            this.btnEmptyDirs.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnEmptyDirs.Name = "btnEmptyDirs";
            this.btnEmptyDirs.Size = new System.Drawing.Size(315, 71);
            this.btnEmptyDirs.TabIndex = 30;
            this.btnEmptyDirs.Text = "remove empty dirs";
            this.toolTip1.SetToolTip(this.btnEmptyDirs, "Remove files from destination which\r\ndo not longer exist in source path.");
            this.btnEmptyDirs.UseVisualStyleBackColor = false;
            this.btnEmptyDirs.Click += new System.EventHandler(this.btnEmptyDirs_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(2088, 46);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 44);
            this.exitToolStripMenuItem.Text = "e&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oprionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.optionsToolStripMenuItem.Text = "&options";
            // 
            // oprionsToolStripMenuItem
            // 
            this.oprionsToolStripMenuItem.Name = "oprionsToolStripMenuItem";
            this.oprionsToolStripMenuItem.Size = new System.Drawing.Size(227, 44);
            this.oprionsToolStripMenuItem.Text = "&options";
            this.oprionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1873, 976);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "skipped";
            // 
            // tbSkipped
            // 
            this.tbSkipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSkipped.Location = new System.Drawing.Point(1877, 1017);
            this.tbSkipped.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbSkipped.Name = "tbSkipped";
            this.tbSkipped.Size = new System.Drawing.Size(106, 37);
            this.tbSkipped.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1873, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "files";
            // 
            // tbFiles
            // 
            this.tbFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFiles.Location = new System.Drawing.Point(1877, 463);
            this.tbFiles.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.Size = new System.Drawing.Size(106, 37);
            this.tbFiles.TabIndex = 15;
            // 
            // cbAppendSourcePath
            // 
            this.cbAppendSourcePath.AutoSize = true;
            this.cbAppendSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAppendSourcePath.Location = new System.Drawing.Point(63, 304);
            this.cbAppendSourcePath.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cbAppendSourcePath.Name = "cbAppendSourcePath";
            this.cbAppendSourcePath.Size = new System.Drawing.Size(285, 35);
            this.cbAppendSourcePath.TabIndex = 19;
            this.cbAppendSourcePath.Text = "append source path";
            this.cbAppendSourcePath.UseVisualStyleBackColor = true;
            // 
            // cbDestDrive
            // 
            this.cbDestDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDestDrive.FormattingEnabled = true;
            this.cbDestDrive.Location = new System.Drawing.Point(64, 229);
            this.cbDestDrive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbDestDrive.Name = "cbDestDrive";
            this.cbDestDrive.Size = new System.Drawing.Size(184, 45);
            this.cbDestDrive.TabIndex = 24;
            this.cbDestDrive.SelectedIndexChanged += new System.EventHandler(this.cbDestDrive_SelectedIndexChanged);
            // 
            // tbExceptions
            // 
            this.tbExceptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbExceptions.Location = new System.Drawing.Point(1877, 1111);
            this.tbExceptions.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbExceptions.Name = "tbExceptions";
            this.tbExceptions.Size = new System.Drawing.Size(106, 37);
            this.tbExceptions.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1872, 1071);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "Exceptions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1872, 624);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "exists";
            // 
            // tbExists
            // 
            this.tbExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbExists.Location = new System.Drawing.Point(1877, 665);
            this.tbExists.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbExists.Name = "tbExists";
            this.tbExists.Size = new System.Drawing.Size(106, 37);
            this.tbExists.TabIndex = 28;
            // 
            // cbBreak
            // 
            this.cbBreak.AutoSize = true;
            this.cbBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBreak.Location = new System.Drawing.Point(528, 304);
            this.cbBreak.Margin = new System.Windows.Forms.Padding(2);
            this.cbBreak.Name = "cbBreak";
            this.cbBreak.Size = new System.Drawing.Size(108, 35);
            this.cbBreak.TabIndex = 31;
            this.cbBreak.Text = "abort";
            this.cbBreak.UseVisualStyleBackColor = true;
            // 
            // cbVerbose
            // 
            this.cbVerbose.AutoSize = true;
            this.cbVerbose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVerbose.Location = new System.Drawing.Point(366, 304);
            this.cbVerbose.Margin = new System.Windows.Forms.Padding(2);
            this.cbVerbose.Name = "cbVerbose";
            this.cbVerbose.Size = new System.Drawing.Size(143, 35);
            this.cbVerbose.TabIndex = 32;
            this.cbVerbose.Text = "verbose";
            this.cbVerbose.UseVisualStyleBackColor = true;
            // 
            // tbRemoved
            // 
            this.tbRemoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRemoved.Location = new System.Drawing.Point(1877, 872);
            this.tbRemoved.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbRemoved.Name = "tbRemoved";
            this.tbRemoved.Size = new System.Drawing.Size(106, 37);
            this.tbRemoved.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1873, 832);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "removed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(2088, 1437);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRemoved);
            this.Controls.Add(this.cbVerbose);
            this.Controls.Add(this.cbBreak);
            this.Controls.Add(this.btnEmptyDirs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbExists);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbExceptions);
            this.Controls.Add(this.cbDestDrive);
            this.Controls.Add(this.btnDirSize);
            this.Controls.Add(this.btnGetRemove);
            this.Controls.Add(this.cbAppendSourcePath);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSkipped);
            this.Controls.Add(this.tbAction);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbCopy);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.tbDestPath);
            this.Controls.Add(this.tbSourcePath);
            this.Controls.Add(this.btnDestPath);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.btnSourcePath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "My File Sync V2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSourcePath;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDestPath;
        private System.Windows.Forms.TextBox tbSourcePath;
        private System.Windows.Forms.TextBox tbDestPath;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.TextBox tbCopy;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbAction;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSkipped;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox cbAppendSourcePath;
        private System.Windows.Forms.Button btnGetRemove;
        private System.Windows.Forms.Button btnDirSize;
        private System.Windows.Forms.ComboBox cbDestDrive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbExceptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbExists;
        private System.Windows.Forms.Button btnEmptyDirs;
        private System.Windows.Forms.CheckBox cbBreak;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oprionsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbVerbose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRemoved;
    }
}

