using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class FileDB
    {
        public static string filePath;
        public static FileStream fs;

        public static bool CheckIfFileExist () {
            if (File.Exists(filePath))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static void OpenWriteFile ()
        {
            fs = File.OpenWrite(filePath);
        }

        public static void OpenReadFile()
        {
            fs = File.OpenRead(filePath);
        }

        public static void OpenAndRewriteFile ()
        {
            fs = File.Open(filePath, FileMode.Create);
        }

        public static void OpenAndAddUpFile ()
        {
            fs = File.Open(filePath, FileMode.Append);
        }

        public static void CloseFile ()
        {
            fs.Close();
        }

        public static void DeleteFile ()
        {
            File.Delete(filePath);
        }
    }
}
