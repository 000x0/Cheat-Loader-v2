using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Acedia_Labs_Loader__Beta_
{
    class Helper
    {
        public static void prfold()
        {
            string pop = @"C:\ProgramData\";
            string path = pop + @"Mlb9rQ\";

            if (System.IO.Directory.Exists(path))
            {

            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }

        }
        
        public static void deleteFolder(string folder)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(folder);

                DirectoryInfo[] diA = di.GetDirectories();

                FileInfo[] fi = di.GetFiles();

                foreach (FileInfo f in fi)
                {
                    f.Delete();
                }

                foreach (DirectoryInfo df in diA)
                {
                    deleteFolder(df.FullName);
                    if (df.GetDirectories().Length == 0 && df.GetFiles().Length == 0) df.Delete();
                }
            }
            catch (Exception)
            {

            }

        }

        public static void DelMe()
        {
            string pop = @"C:\ProgramData\";
            string path = pop + @"Mlb9rQ\";
            string dgm = @"MirunTb3q.dll";

            FileInfo fi2 = new FileInfo(path + dgm);
            fi2.Delete();
            
            string deletePath = path;
            deleteFolder(deletePath);
            Directory.Delete(deletePath);
        }        

    }
}
