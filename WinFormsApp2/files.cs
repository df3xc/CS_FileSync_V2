using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using jonas;

namespace CS_FileSync
{

    public partial class Form1 : Form
    {

        Boolean fileIsAvailable = false;

        /// <summary>
        /// ignore directories 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>

        private Boolean skipDirectory (string path)
        {

            string[] skip;

            skip = opt.tbIgnorePaths.Text.Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in skip)
            {
                string p = "\\" + s;

               if (path.Contains(p))
                {
                    if (cbVerbose.Checked) log("#### skip dir: " + path + "\n");
                    return (true);
                }
            }

            if (opt.skip_dot_dirs == true && path.Contains("\\AppData"))
            {
                if (cbVerbose.Checked) log("#### skip dir: " + path + "\n");
                return (true);
            }

            if (opt.skip_dot_dirs == true && path.Contains("\\Downloads"))
            {
                if (cbVerbose.Checked) log("#### skip dir: " + path + "\n");
                return (true);
            }

            if (opt.skip_dot_dirs == true && path.Contains("\\obj"))
            {
                if (cbVerbose.Checked) log("#### skip dir: " + path + "\n");
                return (true);
            }

            return false;
        }

        /// <summary>
        /// ignore files
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>

        Boolean skipFiles (string path)
        {
            if (opt.skip_dot_dirs == true && path.Contains("\\."))
            {
                statistic.count_skipped++;
                return(true);
            }

            if (opt.copy_videos == false && path.EndsWith(".mp4"))
            {
                statistic.count_skipped++;
                return (true);
            }

            if (opt.copy_audios == false && path.EndsWith(".mp3"))
            {
                statistic.count_skipped++;
                return (true);
            }
            if (opt.skip_artifacts == true && path.EndsWith(".lst"))
            {
                statistic.count_skipped++;
                return (true);
            }

            if (opt.skip_artifacts == true && path.EndsWith(".bak"))
            {
                statistic.count_skipped++;
                return (true);
            }

            if (opt.skip_artifacts == true && path.EndsWith(".o"))
            {
                statistic.count_skipped++;
                return (true);
            }
            return false;
        }


        /// <summary>
        /// return all file infos from path (top directory only)
        /// skip specific directories and file types
        /// </summary>
        /// <param name="path"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>

        private List<file_info_class> GetFileInfos(string path, string pattern)
        {
            List<file_info_class> _sourceList = new List<file_info_class>();
            string[] filePaths;

            directory_info_class d = new directory_info_class();

            d.path = path;
            d.size = 0;

            try
            {

                if (skipDirectory(path) == true) return (sourceFileList);

                filePaths = Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly);

                foreach (string s in filePaths)
                {
                    try
                    {
                        if (skipFiles(s) == true) continue;

                        file_info_class info = new file_info_class();
                        info.fileInfo = new FileInfo(s);
                        _sourceList.Add(info);

                        statistic.count_files++;
                        Application.DoEvents();

                        d.size = d.size + info.fileInfo.Length;

                        showStatistic();
                        Application.DoEvents();

                    }
                    catch (Exception ex)
                    {
                        log(ex.Message);
                        statistic.count_exceptions++;
                    }
                }

                DirectoryList.Add(d);

            }
            catch (Exception ex)
            {
                log(ex.Message);
                statistic.count_exceptions++;
            }

            return (_sourceList);
        }

        /// <summary>
        /// recursively walk through all directories in path.
        /// return all file infos
        /// </summary>
        /// <param name="path"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>

        private List<file_info_class> GetAllFiles(string path, string pattern)
        {
            List<file_info_class> fileList = new List<file_info_class>();

            try
            {
                Application.DoEvents();

                if (cbBreak.Checked==true)
                {
                    return fileList;
                }

                fileList.AddRange(GetFileInfos(path, pattern));
                foreach (var directory in Directory.GetDirectories(path))
                {
                    fileList.AddRange(GetAllFiles(directory, pattern));
                }
            }
            catch (UnauthorizedAccessException) { }

            return fileList;
        }

        /// <summary>
        /// return a list of all files in path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>

        private List<file_info_class> searchFiles(string path)
        {
            string[] filePaths;
            List<file_info_class> _sourceList = new List<file_info_class>();
            cbBreak.Checked = false;
            filePaths = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);

            //filePaths = Directory.GetDirectories(path);

            foreach (string s in filePaths)
            {
                file_info_class info = new file_info_class();
                info.fileInfo = new FileInfo(s);
                _sourceList.Add(info);
            }

            return (_sourceList);
        }

        /// <summary>
        /// copy a single file to destination
        /// </summary>
        /// <param name="finfo"></param>
        /// <param name="dest"></param>

        public void copyfile(file_info_class finfo, string dest)
        {
            try
            {
                FileAttributes attributes;

                //              finfo.fileInfo.CopyTo(finfo.destFullName, true);

                attributes = File.GetAttributes(finfo.fileInfo.FullName);
                uint attr = (uint)attributes;
                if ((attr & 0x80000) == 0x80000)
                {
                    log(" [ON DISK] ");
                    fileIsAvailable = true;

                }
                else
                {
                    log(" [IN CLOUD] ");
                    fileIsAvailable = false;
                }

                log("copy " + finfo.fileInfo + "\n");
//                log("  to " + finfo.destFullName + "\n");

                File.Copy(finfo.fileInfo.FullName, finfo.destFullName, true);

                if (fileIsAvailable == false)
                {
                    log(" free space of " + finfo.fileInfo.FullName + "\n");
                    // set file offline. free local space 
                    attr = (uint)(attr & (~0x80000));
                    attr = (uint)(attr | (0x100000));
                    File.SetAttributes(finfo.fileInfo.FullName, (FileAttributes)attr);
                }

            }
            catch (Exception ex)
            {
                log("\n ### Exception : Could not write " + finfo.destFullName + "\n");
                log(ex.Message + "\n");
                statistic.count_exceptions++;
            }

            threadRunning = false;
        }

        /// <summary>
        /// synchronize (copy or replace) files into destination path
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destPath"></param>

        private void synchroniseFiles(List<file_info_class> source, string destPath)
        {
            progressBar1.Maximum = source.Count + 1;
            progressBar1.Value = 0;

            string previousPath = "xyz123";

            foreach (file_info_class finfo in source)
            {
                try
                {
                    string name;

                    showStatistic();

                    name = finfo.fileInfo.FullName;

                    if (skipFiles(name) == true) continue;

                    // create the path of the destination file

                    if (cbAppendSourcePath.Checked == false)
                    {

                        // option A : we delete the entire soureRootPath from filename.

                        name = finfo.fileInfo.FullName;
                        name = name.Replace(sourceRootPath, "");
                        finfo.destFullName = destPath + name;
                    }
                    else
                    {
                        // option B : we delete only the drive from filename.
                        // we append source path to destination path

                        finfo.destFullName = name.Remove(0, 3);
                        finfo.destFullName = destPath + "\\" + finfo.destFullName;
                    }

                    // create destination directory

                    string currentPath = Path.GetDirectoryName(finfo.destFullName);
                    if (Directory.Exists(currentPath) == false)
                    {
                        Directory.CreateDirectory(currentPath);
                    }

                    // collect all destination directories used
                    // later we search for obsolete files in these directories

                    if (currentPath != previousPath)
                    {
                        usedDestPaths.Add(currentPath);
                        previousPath = currentPath;
                    }


                    if (File.Exists(finfo.destFullName) == true)
                    {
                        FileInfo f = new FileInfo(finfo.destFullName);

                        TimeSpan t = finfo.fileInfo.LastWriteTime - f.LastWriteTime;
                        //log ("timespan diff" + t.ToString());

                        if (t > TimeSpan.FromSeconds(20))
                        {
                            tbAction.Text = " REPLACE " + finfo.destFullName;
                            log(" REPLACE " + finfo.destFullName + "\n");
 
                            threadRunning = true;
                            Thread t1 = new Thread(unused => copyfile(finfo, finfo.destFullName));

                            t1.Start();

                            while (threadRunning)
                            {
                                Application.DoEvents();
                                Thread.Sleep(50);
                            }

                            statistic.count_replace++;
                        }
                        else
                        {
                            statistic.count_exists++;
                        }
                    }
                    else
                    {
                        tbAction.Text = " COPY " + finfo.fileInfo.FullName + " TO " + finfo.destFullName;

                        threadRunning = true;
                        Thread t1 = new Thread(unused => copyfile(finfo, finfo.destFullName));

                        t1.Start();

                        while (threadRunning)
                        {
                            Application.DoEvents();
                            Thread.Sleep(50);
                        }

                        statistic.count_copy++;
                    }

 
                    showStatistic();
                    progressBar1.Value++;
                    Application.DoEvents();

                    if (cbBreak.Checked == true)
                    {
                        log(" ABORTED \n");
                        break;
                    }
                }
                catch (Exception ex)
                {
                    log(ex.Message + "\n");
                    statistic.count_exceptions++;
                }
            }
            tbAction.Text = "COPY and REPLACE finished";
            log(" Exceptions " + statistic.count_exceptions.ToString());
            sync_finished = true;

        }

        /// <summary>
        /// synchronise source to destination
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
        /// create a list of files to be removed from destination
        /// </summary>

        private void getFilesToRemove()
        {
            List<file_info_class> fileList = new List<file_info_class>();
            string sourcePath = "";
            string sourceName = "";
            string fileName = "";
            Boolean found = false;

            cbBreak.Checked = false;
            filesToRemove.Clear();
            statistic.Clear();
            logBox.Clear();

            notify("Search files to be removed \n");
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

                if (cbBreak.Checked == true)
                {
                    log(" ABORTED \n");
                    break;
                }
            }
            notify("\n List of files to be removed . File count " + filesToRemove.Count + "\n");
            Application.DoEvents();
        }

        /// <summary>
        /// remove files from destination
        /// </summary>
        private void removeFiles()
        {
            int count = 0;
 
            notify("... removing files \n");
            foreach (file_info_class file in filesToRemove)
            {
                log(" deleting file: " + file.fileInfo.FullName + "\n");
                File.Delete(file.fileInfo.FullName);
                count++;
            }
            notify(" number of deleted files "+ count.ToString()+ "\n");
        }
 
        /// <summary>
        /// recursively delete empty directories
        /// </summary>
        /// <param name="startLocation"></param>

        private void deleteEmptyDirectory(string startLocation)
        {
            int count = 0;

            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                deleteEmptyDirectory(directory);
                if (Directory.GetFiles(directory).Length == 0 &&
                    Directory.GetDirectories(directory).Length == 0)
                {
                    Directory.Delete(directory, false);
                    log(" delete directory: " + directory + "\n");
                    count++;

                }
            }
        }

    }

}
