using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CS_FileSync
{

    #region classes

    /// <summary>
    /// file infos
    /// </summary>

    public class file_info_class
    {
        /// <summary>
        /// full path to file destination. Set only if file will be copied
        /// </summary>

        public string destFullName;
        public Boolean isAvailable = false;
        public FileInfo fileInfo;

    }

    /// <summary>
    /// directory infos
    /// </summary>

    public class directory_info_class
    {
        string thePath;
        long theSize;

        public string path
        {
            get { return thePath; }
            set { thePath = value; }
        }

        public long size
        {
            get { return theSize; }
            set { theSize = value; }
        }


    }

    public class statistic_class
    {
        public int count_files = 0;
        public int count_copy = 0;
        public int count_replace = 0;
        public int count_skipped = 0;
        public int count_exceptions = 0;
        public int count_exists = 0;

        public void Clear()
        {
            count_files = 0;
            count_copy = 0;
            count_replace = 0;
            count_skipped = 0;
            count_exceptions = 0;
            count_exceptions = 0;
            count_exists = 0;
        }

    }

    #endregion


}
