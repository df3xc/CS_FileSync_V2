using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using GuiThread;

/*
 * Right click on References. Select “Add Reference…” from the context menu. 
 * On the left of the Reference Manager, choose Browse and find the following file: 
 * 
 * select "All Files (*.*)
 * 
 * C:\Program Files (x86)\Windows Kits\10\UnionMetadata\10.0.22000.0\Metadata.winmd
 * C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETCore\v4.5\System.Runtime.WindowsRuntime.dll
 * 
 */

namespace CS_FileSync
{
    public partial class Form1 : Form
    {

        public string sourceRootPath;
        public string destPath;
        public string destDrive = "";
        public string output;

        public Boolean stopped = false;
        public Boolean threadRunning = false;
        public int exceptions = 0;

        statistic_class statistic = new statistic_class();
        private guiThreadClass gt = new guiThreadClass();

        option_class opt = new option_class();

        List<file_info_class> sourceFileList = new List<file_info_class>();

        List<directory_info_class> DirectoryList = new List<directory_info_class>();
        List<directory_info_class> FilterDirectoryList = new List<directory_info_class>();

        /// <summary>
        /// collect the paths in destination that were used. 
        /// Needed to search for files to  be removed
        /// </summary>

        List<string> usedDestPaths = new List<string>();

        List<file_info_class> filesToRemove = new List<file_info_class>();

        Boolean sync_finished = false;

        #region init

        public Form1()
        {
            InitializeComponent();
            int z;

            z = tbAction.Location.Y;
            //this.Size.Height = 400;

            tbSourcePath.Text = Settings.Default.sourcePath;
            tbDestPath.Text = Settings.Default.destPath;
            sourceRootPath = tbSourcePath.Text;
            destPath = tbDestPath.Text;

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                cbDestDrive.Items.Add(d.Name);
            }


        }

        private void log(string text)
        {
            gt.RichTextBoxWrite(logBox,text);
            Application.DoEvents();
        }

        private void notify(string text)
        {
            gt.RichTextBoxWrite(logBox, text);
            tbAction.Text = text;
            Application.DoEvents();
        }

        private void showStatistic()
        {
            tbFiles.Text = statistic.count_files.ToString();
            tbCopy.Text = statistic.count_copy.ToString();
            tbExists.Text = statistic.count_exists.ToString();
            tbReplace.Text = statistic.count_replace.ToString();
            tbSkipped.Text = statistic.count_skipped.ToString();
            tbExceptions.Text = statistic.count_exceptions.ToString();
            Application.DoEvents();
        }

        private void showFiles(List<file_info_class> files)
        {
            foreach (file_info_class i in files)
            {
                log(i.fileInfo.Name);
            }
        }

        #endregion

        /// <summary>
        /// select source path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSourcePath_Click(object sender, EventArgs e)
        {
            if (cbDestDrive.SelectedIndex == -1)
            {
                MessageBox.Show("Select destination drive", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            destDrive = cbDestDrive.SelectedItem.ToString();

            if (folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
            {
                sourceRootPath = folderBrowserDialog1.SelectedPath;
                tbSourcePath.Text = sourceRootPath;
                Settings.Default.sourcePath = tbSourcePath.Text;
                Settings.Default.Save();

                destPath = sourceRootPath.Remove(0, 3);
                destPath = destDrive + destPath;
                tbDestPath.Text = destPath;
                Settings.Default.destPath = tbDestPath.Text;
                Settings.Default.Save();

            }
        }

        private void cbDestDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            destDrive = cbDestDrive.SelectedItem.ToString();

            if (sourceRootPath != string.Empty)
            { 
            destPath = sourceRootPath.Remove(0, 3);
            destPath = destDrive + destPath;
            tbDestPath.Text = destPath;
            Settings.Default.destPath = tbDestPath.Text;
            Settings.Default.Save();
            }
        }

        /// <summary>
        /// select destination path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDestPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
            {
                destPath = folderBrowserDialog1.SelectedPath;
                tbDestPath.Text = destPath;
                Settings.Default.destPath = tbDestPath.Text;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// get a list of files to be removed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeFiles();
        }

        /// <summary>
        /// remove files from destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGetRemove_Click(object sender, EventArgs e)
        {
            cbBreak.Checked = false;
            getFilesToRemove();
        }

        /// <summary>
        /// remove empty directories from destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnEmptyDirs_Click(object sender, EventArgs e)
        {
            notify("Delete empty directories in " + tbDestPath.Text + "\n");
            cbBreak.Checked = false;
            deleteEmptyDirectory(tbDestPath.Text);
            notify("finisched \n");
        }

        /// <summary>
        /// synchronise source to destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSync_Click(object sender, EventArgs e)
        {
            cbBreak.Checked = false;
            sync_to_destination();
        }

        /// <summary>
        /// show size of directories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDirSize_Click(object sender, EventArgs e)
        {
            statistic.Clear();
            sourceRootPath = tbSourcePath.Text;
            sourceFileList = GetAllFiles(sourceRootPath, "*.*");

            foreach (directory_info_class d in DirectoryList)
            {
                d.size = d.size / (1024 * 1024);

                if (d.size > 100)
                {
                    FilterDirectoryList.Add(d);
                }

            }

            directory_form Dir = new directory_form();
            Dir.dataGridView1.DataSource = FilterDirectoryList;
            Dir.Show();

            tbAction.Text = " Finished show directory size  ";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.destPath = tbDestPath.Text;
            Settings.Default.sourcePath = tbSourcePath.Text;
            Settings.Default.Save();
        }


    #region drag_drop

        private void tbSourcePath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (System.IO.Directory.Exists(files[0]))
                {
                    this.tbSourcePath.Text = files[0];
                    sourceRootPath = tbSourcePath.Text;
                    Settings.Default.sourcePath = tbSourcePath.Text;
                    Settings.Default.Save();
                }
            }
        }

        private void tbSourcePath_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void tbDestPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (System.IO.Directory.Exists(files[0]))
                {
                    this.tbDestPath.Text = files[0];
                    destPath = tbDestPath.Text;
                    Settings.Default.destPath = tbDestPath.Text;
                    Settings.Default.Save();
                }
            }
        }

        private void tbDestPath_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opt.ShowDialog();
        }
    }


    #endregion

}
