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
            this.label2 = new System.Windows.Forms.Label();
            this.cbAudios = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbOneDrive = new System.Windows.Forms.CheckBox();
            this.cbSkip = new System.Windows.Forms.CheckBox();
            this.cbSkipArtifacts = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbVideos
            // 
            this.cbVideos.AutoSize = true;
            this.cbVideos.Location = new System.Drawing.Point(32, 28);
            this.cbVideos.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cbVideos.Name = "cbVideos";
            this.cbVideos.Size = new System.Drawing.Size(203, 36);
            this.cbVideos.TabIndex = 0;
            this.cbVideos.Text = "copy videos";
            this.cbVideos.UseVisualStyleBackColor = true;
            this.cbVideos.CheckedChanged += new System.EventHandler(this.cbVideos_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "mp4";
            // 
            // cbAudios
            // 
            this.cbAudios.AutoSize = true;
            this.cbAudios.Location = new System.Drawing.Point(32, 105);
            this.cbAudios.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cbAudios.Name = "cbAudios";
            this.cbAudios.Size = new System.Drawing.Size(205, 36);
            this.cbAudios.TabIndex = 3;
            this.cbAudios.Text = "copy audios";
            this.cbAudios.UseVisualStyleBackColor = true;
            this.cbAudios.CheckedChanged += new System.EventHandler(this.cbAudios_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "mp3";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(150, 634);
            this.btnOk.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(201, 54);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbOneDrive
            // 
            this.cbOneDrive.AutoSize = true;
            this.cbOneDrive.Location = new System.Drawing.Point(32, 181);
            this.cbOneDrive.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cbOneDrive.Name = "cbOneDrive";
            this.cbOneDrive.Size = new System.Drawing.Size(240, 36);
            this.cbOneDrive.TabIndex = 6;
            this.cbOneDrive.Text = "copy OneDrive";
            this.cbOneDrive.UseVisualStyleBackColor = true;
            this.cbOneDrive.CheckedChanged += new System.EventHandler(this.cbOneDrive_CheckedChanged);
            // 
            // cbSkip
            // 
            this.cbSkip.AutoSize = true;
            this.cbSkip.Location = new System.Drawing.Point(32, 256);
            this.cbSkip.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cbSkip.Name = "cbSkip";
            this.cbSkip.Size = new System.Drawing.Size(425, 36);
            this.cbSkip.TabIndex = 7;
            this.cbSkip.Text = "skip AppData and Downloads";
            this.cbSkip.UseVisualStyleBackColor = true;
            this.cbSkip.CheckedChanged += new System.EventHandler(this.cbSkip_CheckedChanged);
            // 
            // cbSkipArtifacts
            // 
            this.cbSkipArtifacts.AutoSize = true;
            this.cbSkipArtifacts.Location = new System.Drawing.Point(32, 331);
            this.cbSkipArtifacts.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cbSkipArtifacts.Name = "cbSkipArtifacts";
            this.cbSkipArtifacts.Size = new System.Drawing.Size(273, 36);
            this.cbSkipArtifacts.TabIndex = 8;
            this.cbSkipArtifacts.Text = "skip *.o *.lst *.bak";
            this.cbSkipArtifacts.UseVisualStyleBackColor = true;
            // 
            // option_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(554, 761);
            this.Controls.Add(this.cbSkipArtifacts);
            this.Controls.Add(this.cbSkip);
            this.Controls.Add(this.cbOneDrive);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAudios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVideos);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "option_class";
            this.Text = "options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.options_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbVideos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAudios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbOneDrive;
        private System.Windows.Forms.CheckBox cbSkip;
        private System.Windows.Forms.CheckBox cbSkipArtifacts;
    }
}