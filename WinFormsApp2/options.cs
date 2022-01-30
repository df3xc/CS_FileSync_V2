﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_FileSync
{
    public partial class option_class : Form
    {
        /// <summary>
        /// if true copy video files (mp4) to destination
        /// </summary>

        public Boolean copy_videos = true;

        /// <summary>
        ///  if true copy audio files (mp3) to destination
        /// </summary>
        /// 

        public Boolean copy_audios = true;

        public Boolean copy_OneDrive = true;

        /// <summary>
        /// skip all directories starting with a dot
        /// </summary>

        public Boolean skip_dot_dirs = true;

        public Boolean skip_artifacts = true;

        public option_class()
        {
            InitializeComponent();
            cbOneDrive.Checked = copy_OneDrive;
            cbSkip.Checked = skip_dot_dirs;
            cbSkipArtifacts.Checked = skip_artifacts;

            copy_audios = Settings.Default.copy_mp3;
            cbAudios.Checked = copy_audios;
            copy_videos = Settings.Default.copy_mp4;
            cbVideos.Checked = copy_videos;
        }

        private void options_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.copy_mp3 = cbAudios.Checked;
            Settings.Default.copy_mp4 = cbVideos.Checked;
            Settings.Default.Save();
            e.Cancel = true;
            this.Hide();
        }

        private void cbVideos_CheckedChanged(object sender, EventArgs e)
        {
            copy_videos = cbVideos.Checked;
        }

        private void cbAudios_CheckedChanged(object sender, EventArgs e)
        {
            copy_audios = cbAudios.Checked;
        }

        private void cbOneDrive_CheckedChanged(object sender, EventArgs e)
        {
            copy_OneDrive = cbOneDrive.Checked;
        }

        private void cbSkip_CheckedChanged(object sender, EventArgs e)
        {
            skip_dot_dirs = cbSkip.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
