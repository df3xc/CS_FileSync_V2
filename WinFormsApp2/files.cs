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
                if (opt.skip_dot_dirs == true && path.Contains("AppData"))
                {
                    return (_sourceList);
                }

                if (opt.skip_dot_dirs == true && path.Contains("Downloads"))
                {
                    return (_sourceList);
                }

                if (opt.skip_artifacts == true && path.Contains(".lst"))
                {
                    return (_sourceList);
                }


                filePaths = Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly);

                foreach (string s in filePaths)
                {
                    try
                    {

                        if (opt.skip_dot_dirs == true && s.Contains("\\."))
                        {
                            statistic.count_skipped++;
                            continue;
                        }

                        if (opt.copy_videos == false && s.EndsWith(".mp4"))
                        {
                            statistic.count_skipped++;
                            continue;
                        }

                        if (opt.copy_audios == false && s.EndsWith(".mp3"))
                        {
                            statistic.count_skipped++;
                            continue;
                        }

                        if (opt.skip_artifacts == true && s.EndsWith(".lst"))
                        {
                            statistic.count_skipped++;
                            continue;
                        }

                        if (opt.skip_artifacts == true && s.EndsWith(".bak"))
                        {
                            statistic.count_skipped++;
                            continue;
                        }

                        if (opt.skip_artifacts == true && s.EndsWith(".o"))
                        {
                            statistic.count_skipped++;
                            continue;
                        }

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

                log("copy " + finfo.fileInfo + "\n");
                log("  to " + finfo.destFullName + "\n" );
                //              finfo.fileInfo.CopyTo(finfo.destFullName, true);

                attributes = File.GetAttributes(finfo.fileInfo.FullName);
                uint attr = (uint)attributes;
                if ((attr & 0x80000) == 0x80000)
                {
                    log(" --- ON DISK --- \n");
                    fileIsAvailable = true;

                }
                else
                {
                    log(" ### OFFLINE ### \n");
                    fileIsAvailable = false;
                }

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

                    if (opt.skip_dot_dirs == true && name.Contains("AppData"))
                    {
                        statistic.count_skipped++;
                        continue;
                    }

                    if (opt.skip_dot_dirs == true && name.Contains("\\."))
                    {
                        statistic.count_skipped++;
                        continue;
                    }


                    if (opt.copy_videos == false && name.Contains(".mp4"))
                    {
                        statistic.count_skipped++;
                        progressBar1.Value++;
                        continue;
                    }

                    if (opt.copy_audios == false && name.Contains(".mp3"))
                    {
                        statistic.count_skipped++;
                        progressBar1.Value++;
                        continue;
                    }

                    if (opt.copy_OneDrive == false && name.Contains("OneDrive"))
                    {
                        statistic.count_skipped++;
                        progressBar1.Value++;
                        continue;
                    }

                    if (name.Contains("RECYCLE.BIN"))
                    {
                        statistic.count_skipped++;
                        progressBar1.Value++;
                        continue;
                    }

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

                        //if (finfo.fileInfo.FullName.Contains(".mp4"))
                        //{
                        //    result = jonas.process_util.process_exec_wait(@"C:\Windows\SysWOW64\attrib.exe", "+U -P \""+ finfo.fileInfo.FullName +"\"");
                        //    log(" free space of " + finfo.fileInfo.FullName + "\n");
                        //}

                        //if (finfo.fileInfo.FullName.Contains(".mp3"))
                        //{
                        //    result = jonas.process_util.process_exec_wait(@"C:\Windows\SysWOW64\attrib.exe", "+U -P \""+ finfo.fileInfo.FullName + "\"");
                        //    log(" free space of " + finfo.fileInfo.FullName + "\n");
                        //}

                        statistic.count_copy++;
                    }

 
                    showStatistic();
                    progressBar1.Value++;
                    Application.DoEvents();
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
        /// recursively delete empty directories
        /// </summary>
        /// <param name="startLocation"></param>

        private void deleteEmptyDirectory(string startLocation)
        {
            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                deleteEmptyDirectory(directory);
                if (Directory.GetFiles(directory).Length == 0 &&
                    Directory.GetDirectories(directory).Length == 0)
                {
                    Directory.Delete(directory, false);
                    log(" DELETE " + directory + "\n");

                }
            }
        }

    }

}
