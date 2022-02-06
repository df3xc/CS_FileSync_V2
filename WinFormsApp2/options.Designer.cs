namespace CS_FileSync
{
    partial class option_class
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
            this.cbVideos = new System.Windows.Forms.CheckBox();
            this.cbAudios = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbOneDrive = new System.Windows.Forms.CheckBox();
            this.cbSkip = new System.Windows.Forms.CheckBox();
            this.cbSkipArtifacts = new System.Windows.Forms.CheckBox();
            this.tbIgnorePaths = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbVideos
            // 
            this.cbVideos.AutoSize = true;
            this.cbVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVideos.Location = new System.Drawing.Point(34, 33);
            this.cbVideos.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cbVideos.Name = "cbVideos";
            this.cbVideos.Size = new System.Drawing.Size(361, 46);
            this.cbVideos.TabIndex = 0;
            this.cbVideos.Text = "copy videos (mp4)";
            this.cbVideos.UseVisualStyleBackColor = true;
            this.cbVideos.CheckedChanged += new System.EventHandler(this.cbVideos_CheckedChanged);
            // 
            // cbAudios
            // 
            this.cbAudios.AutoSize = true;
            this.cbAudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAudios.Location = new System.Drawing.Point(577, 37);
            this.cbAudios.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cbAudios.Name = "cbAudios";
            this.cbAudios.Size = new System.Drawing.Size(363, 46);
            this.cbAudios.TabIndex = 3;
            this.cbAudios.Text = "copy audios (mp3)";
            this.cbAudios.UseVisualStyleBackColor = true;
            this.cbAudios.CheckedChanged += new System.EventHandler(this.cbAudios_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(785, 415);
            this.btnOk.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(214, 71);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbOneDrive
            // 
            this.cbOneDrive.AutoSize = true;
            this.cbOneDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbOneDrive.Location = new System.Drawing.Point(34, 131);
            this.cbOneDrive.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cbOneDrive.Name = "cbOneDrive";
            this.cbOneDrive.Size = new System.Drawing.Size(304, 46);
            this.cbOneDrive.TabIndex = 6;
            this.cbOneDrive.Text = "copy OneDrive";
            this.cbOneDrive.UseVisualStyleBackColor = true;
            this.cbOneDrive.CheckedChanged += new System.EventHandler(this.cbOneDrive_CheckedChanged);
            // 
            // cbSkip
            // 
            this.cbSkip.AutoSize = true;
            this.cbSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSkip.Location = new System.Drawing.Point(1070, 38);
            this.cbSkip.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cbSkip.Name = "cbSkip";
            this.cbSkip.Size = new System.Drawing.Size(548, 46);
            this.cbSkip.TabIndex = 7;
            this.cbSkip.Text = "skip AppData and Downloads";
            this.cbSkip.UseVisualStyleBackColor = true;
            this.cbSkip.CheckedChanged += new System.EventHandler(this.cbSkip_CheckedChanged);
            // 
            // cbSkipArtifacts
            // 
            this.cbSkipArtifacts.AutoSize = true;
            this.cbSkipArtifacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSkipArtifacts.Location = new System.Drawing.Point(577, 131);
            this.cbSkipArtifacts.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.cbSkipArtifacts.Name = "cbSkipArtifacts";
            this.cbSkipArtifacts.Size = new System.Drawing.Size(344, 46);
            this.cbSkipArtifacts.TabIndex = 8;
            this.cbSkipArtifacts.Text = "skip *.o *.lst *.bak";
            this.cbSkipArtifacts.UseVisualStyleBackColor = true;
            // 
            // tbIgnorePaths
            // 
            this.tbIgnorePaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIgnorePaths.Location = new System.Drawing.Point(34, 306);
            this.tbIgnorePaths.Name = "tbIgnorePaths";
            this.tbIgnorePaths.Size = new System.Drawing.Size(1747, 49);
            this.tbIgnorePaths.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(916, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "ingnore paths which contain (separete with semicolon)";
            // 
            // option_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1818, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIgnorePaths);
            this.Controls.Add(this.cbSkipArtifacts);
            this.Controls.Add(this.cbSkip);
            this.Controls.Add(this.cbOneDrive);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbAudios);
            this.Controls.Add(this.cbVideos);
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "option_class";
            this.Text = "options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.options_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.CheckBox cbVideos;
        public System.Windows.Forms.CheckBox cbAudios;
        public System.Windows.Forms.CheckBox cbOneDrive;
        public System.Windows.Forms.CheckBox cbSkip;
        public System.Windows.Forms.CheckBox cbSkipArtifacts;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbIgnorePaths;
    }
}