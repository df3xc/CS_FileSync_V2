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
        /// create a list of files to be removed from destination
        /// </summary>

        private void getFilesToRemove()
        {
            List<file_info_class> fileList = new List<file_info_class>();
            string sourcePath = "";
            string sourceName = "";
            string fileName = "";
            Boolean found = false;

            filesToRemove.Clear();
            statistic.Clear();

            tbAction.Text = "Search files to be removed";
            Application.DoEvents();

            destPath = tbDestPath.Text;

            log(" read all filennames in " + destPath + "\n");
            fileList = GetAllFiles(destPath, "*.*");
            tbAction.Text = "Start analysis of files";

            found = false;
            foreach (file_info_class s in fileList)
            {

                sourceName = s.fileInfo.FullName;
                sourcePath = tbSourcePath.Text;
                fileName = sourceName.Remove(0, 3);
                fileName = sourcePath.Substring(0, 3) + fileName;

                if (File.Exists(fileName))
                {
                    //log(" FOUND " + sourceName + "\n");
                    found = true;
                }
                else
                {
                    log(" TO BE REMOVED " + sourceName + "\n");
                    filesToRemove.Add(s);
                }

                Application.DoEvents();

            }


            log("\n List of files to be removed . File count " + filesToRemove.Count + "\n");

            foreach (file_info_class s in fileList)
            {

                string directory = "";
                directory = s.fileInfo.DirectoryName;

                if (Directory.GetFiles(directory).Length == 0)
                {
                    log(" Deleting empty directory \n");
                }

            }

            tbAction.Text = "DONE : Search files to be removed";
            Application.DoEvents();
        }

        /// <summary>
        /// select source path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSourcePath_Click(object sender, EventArgs e)
        {
            if (cbDestDrive.SelectedIndex == -1)
            {
                MessageBox.Show("Select destination drive","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Hand);
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

        private void btnReadFiles_Click(object sender, EventArgs e)
        {
            logBox.Clear();
            sourceFileList.Clear();
            statistic.Clear();

            sourceRootPath = tbSourcePath.Text;
            destPath = tbDestPath.Text;
            sourceFileList = GetAllFiles(sourceRootPath, "*.*");
            tbAction.Text = " Finished createdl list of source files ";
            log("Number of files found : " + sourceFileList.Count);
            progressBar1.Value = 0;
        }

        /// <summary>
        /// synchonise files to destination
        /// </summary>

        private void sync_to_destination()
        {
            logBox.Clear();
            sourceFileList.Clear();
            statistic.Clear();

            sourceRootPath = tbSourcePath.Text;
            destPath = tbDestPath.Text;
            tbAction.Text = " list all files in source path ";
            sourceFileList = GetAllFiles(sourceRootPath, "*.*");

            tbAction.Text = " start synchronising ";
            synchroniseFiles(sourceFileList, destPath);

            tbAction.Text = " Finished synchronising ";
            sync_finished = true;
            progressBar1.Value = 0;
        }

        /// <summary>
        /// synchronise source to destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSync_Click(object sender, EventArgs e)
        {
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

        private void oprionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opt.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int count = 0;

            tbAction.Text = " ... removing files ";
            foreach (file_info_class file in filesToRemove)
            {
                log(" deleting " + file.fileInfo.FullName + "\n");
                File.Delete(file.fileInfo.FullName);
                count++;
            }
            tbAction.Text = count.ToString() + " Files removed ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getFilesToRemove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log("Delete empty directories in " + tbDestPath.Text + "\n");
            deleteEmptyDirectory(tbDestPath.Text);
            log("finisched \n");
        }
    }


    #endregion

}
