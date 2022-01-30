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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSourcePath.Location = new System.Drawing.Point(82, 101);
            this.btnSourcePath.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(241, 71);
            this.btnSourcePath.TabIndex = 0;
            this.btnSourcePath.Text = "source";
            this.toolTip1.SetToolTip(this.btnSourcePath, "optionally drag folder to textbox");
            this.btnSourcePath.UseVisualStyleBackColor = false;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(82, 564);
            this.logBox.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(2312, 1121);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            this.toolTip1.SetToolTip(this.logBox, "copy or replace files in destination path");
            // 
            // btnDestPath
            // 
            this.btnDestPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDestPath.Location = new System.Drawing.Point(82, 193);
            this.btnDestPath.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnDestPath.Name = "btnDestPath";
            this.btnDestPath.Size = new System.Drawing.Size(241, 71);
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
            this.tbSourcePath.Location = new System.Drawing.Point(355, 110);
            this.tbSourcePath.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbSourcePath.Name = "tbSourcePath";
            this.tbSourcePath.Size = new System.Drawing.Size(2039, 49);
            this.tbSourcePath.TabIndex = 3;
            this.tbSourcePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbSourcePath_DragDrop);
            this.tbSourcePath.DragOver += new System.Windows.Forms.DragEventHandler(this.tbSourcePath_DragOver);
            // 
            // tbDestPath
            // 
            this.tbDestPath.AllowDrop = true;
            this.tbDestPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDestPath.Location = new System.Drawing.Point(355, 202);
            this.tbDestPath.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbDestPath.Name = "tbDestPath";
            this.tbDestPath.Size = new System.Drawing.Size(2047, 49);
            this.tbDestPath.TabIndex = 4;
            this.tbDestPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbDestPath_DragDrop);
            this.tbDestPath.DragOver += new System.Windows.Forms.DragEventHandler(this.tbDestPath_DragOver);
            // 
            // btnSync
            // 
            this.btnSync.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSync.Location = new System.Drawing.Point(355, 274);
            this.btnSync.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(369, 93);
            this.btnSync.TabIndex = 5;
            this.btnSync.Text = "sync to destination";
            this.toolTip1.SetToolTip(this.btnSync, "Copy or replace files in destination folder. \r\nSource folder is not changed");
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // tbCopy
            // 
            this.tbCopy.Location = new System.Drawing.Point(2454, 723);
            this.tbCopy.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(137, 47);
            this.tbCopy.TabIndex = 6;
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(2454, 989);
            this.tbReplace.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(137, 47);
            this.tbReplace.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2449, 671);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "copied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2447, 936);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "replaced";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.SpringGreen;
            this.progressBar1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.progressBar1.Location = new System.Drawing.Point(84, 454);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(2312, 71);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            // 
            // tbAction
            // 
            this.tbAction.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAction.Location = new System.Drawing.Point(84, 1754);
            this.tbAction.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbAction.Name = "tbAction";
            this.tbAction.Size = new System.Drawing.Size(2310, 45);
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
            this.btnRemove.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(1132, 273);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(453, 91);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "remove from destination";
            this.toolTip1.SetToolTip(this.btnRemove, "Remove files from destination which\r\ndo not longer exist in source path.");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGetRemove
            // 
            this.btnGetRemove.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnGetRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetRemove.Location = new System.Drawing.Point(744, 273);
            this.btnGetRemove.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnGetRemove.Name = "btnGetRemove";
            this.btnGetRemove.Size = new System.Drawing.Size(377, 91);
            this.btnGetRemove.TabIndex = 20;
            this.btnGetRemove.Text = "check files removed";
            this.toolTip1.SetToolTip(this.btnGetRemove, "List files from destination which\r\ndo not longer exist in source path.");
            this.btnGetRemove.UseVisualStyleBackColor = false;
            this.btnGetRemove.Click += new System.EventHandler(this.btnGetRemove_Click);
            // 
            // btnDirSize
            // 
            this.btnDirSize.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDirSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDirSize.Location = new System.Drawing.Point(2037, 272);
            this.btnDirSize.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnDirSize.Name = "btnDirSize";
            this.btnDirSize.Size = new System.Drawing.Size(365, 92);
            this.btnDirSize.TabIndex = 21;
            this.btnDirSize.Text = "show directory size";
            this.toolTip1.SetToolTip(this.btnDirSize, "Show size of source path");
            this.btnDirSize.UseVisualStyleBackColor = false;
            this.btnDirSize.Click += new System.EventHandler(this.btnDirSize_Click);
            // 
            // btnEmptyDirs
            // 
            this.btnEmptyDirs.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEmptyDirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmptyDirs.Location = new System.Drawing.Point(1605, 273);
            this.btnEmptyDirs.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnEmptyDirs.Name = "btnEmptyDirs";
            this.btnEmptyDirs.Size = new System.Drawing.Size(412, 91);
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
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(17, 7, 0, 7);
            this.menuStrip1.Size = new System.Drawing.Size(2640, 59);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oprionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(143, 45);
            this.optionsToolStripMenuItem.Text = "&options";
            // 
            // oprionsToolStripMenuItem
            // 
            this.oprionsToolStripMenuItem.Name = "oprionsToolStripMenuItem";
            this.oprionsToolStripMenuItem.Size = new System.Drawing.Size(285, 54);
            this.oprionsToolStripMenuItem.Text = "options";
            this.oprionsToolStripMenuItem.Click += new System.EventHandler(this.oprionsToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2449, 1250);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 41);
            this.label3.TabIndex = 14;
            this.label3.Text = "skipped";
            // 
            // tbSkipped
            // 
            this.tbSkipped.Location = new System.Drawing.Point(2455, 1303);
            this.tbSkipped.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbSkipped.Name = "tbSkipped";
            this.tbSkipped.Size = new System.Drawing.Size(137, 47);
            this.tbSkipped.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2449, 540);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 41);
            this.label4.TabIndex = 16;
            this.label4.Text = "files";
            // 
            // tbFiles
            // 
            this.tbFiles.Location = new System.Drawing.Point(2454, 593);
            this.tbFiles.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.Size = new System.Drawing.Size(137, 47);
            this.tbFiles.TabIndex = 15;
            // 
            // cbAppendSourcePath
            // 
            this.cbAppendSourcePath.AutoSize = true;
            this.cbAppendSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAppendSourcePath.Location = new System.Drawing.Point(82, 389);
            this.cbAppendSourcePath.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cbAppendSourcePath.Name = "cbAppendSourcePath";
            this.cbAppendSourcePath.Size = new System.Drawing.Size(355, 43);
            this.cbAppendSourcePath.TabIndex = 19;
            this.cbAppendSourcePath.Text = "append source path";
            this.cbAppendSourcePath.UseVisualStyleBackColor = true;
            // 
            // cbDestDrive
            // 
            this.cbDestDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDestDrive.FormattingEnabled = true;
            this.cbDestDrive.Location = new System.Drawing.Point(84, 294);
            this.cbDestDrive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDestDrive.Name = "cbDestDrive";
            this.cbDestDrive.Size = new System.Drawing.Size(128, 54);
            this.cbDestDrive.TabIndex = 24;
            // 
            // tbExceptions
            // 
            this.tbExceptions.Location = new System.Drawing.Point(2455, 1424);
            this.tbExceptions.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbExceptions.Name = "tbExceptions";
            this.tbExceptions.Size = new System.Drawing.Size(137, 47);
            this.tbExceptions.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2448, 1372);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 41);
            this.label5.TabIndex = 27;
            this.label5.Text = "Exceptions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2448, 799);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 41);
            this.label6.TabIndex = 29;
            this.label6.Text = "exists";
            // 
            // tbExists
            // 
            this.tbExists.Location = new System.Drawing.Point(2454, 852);
            this.tbExists.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.tbExists.Name = "tbExists";
            this.tbExists.Size = new System.Drawing.Size(137, 47);
            this.tbExists.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(2640, 1952);
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
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
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
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oprionsToolStripMenuItem;
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
    }
}

