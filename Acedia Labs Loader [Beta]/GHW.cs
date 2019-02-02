using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Acedia_Labs_Loader__Beta_
{
    class GHW
    {
     
            public static string GetHWID()
            {
                string str = "";
                {
                    try
                    {
                        string str2 = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
                        ManagementObject obj1 = new ManagementObject("win32_logicaldisk.deviceid=\"" + str2 + ":\"");
                        obj1.Get();
                        str = obj1["VolumeSerialNumber"].ToString();
                    }
                    catch (Exception)
                    {
                    }
                }
                return str;
            }
        
    }
}
