using Acedia_Loader__BETA_.InjectionLibrary;
using JLibrary.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acedia_Labs_Loader__Beta_
{
    class PremiumINJ
    {
        
        public static void inj()
        {
            Helper.prfold();

            string put = @"Mlb9rQ\";
            string dgm = @"MirunTb3q.dll";

            WebClient wc = new WebClient();
            string url = " "; //your link
            string save_path = @"C:\ProgramData\" + put;
            string name = dgm;
            wc.DownloadFile(url, save_path + name);

            Thread.Sleep(100);

            string realDLL = @"C:\ProgramData\" + put + dgm;


            InjectionMethod injector = null;

            injector = InjectionMethod.Create(InjectionMethodType.ManualMap);


            Process[] processes = Process.GetProcessesByName("csgo");
            if (processes.Length <= 0)
            {
                Helper.DelMe();
                Console.WriteLine("Start CS:GO first, please click the button...");
                Console.ReadKey();
                return;
            }
            else
            {
                int processId = processes[0].Id;
                IntPtr result = IntPtr.Zero;
                using (PortableExecutable pe = new PortableExecutable(realDLL))
                {
                    result = injector.Inject(pe, processId);
                }
                if (result != IntPtr.Zero)
                {
                    playSimpleSound();
                    File.WriteAllText(Properties.Pst.paste, realDLL + ";");
                    Console.WriteLine("Good inject!");
                    Environment.Exit(0);
                }
                else
                {
                    Helper.DelMe();
                    if (injector.GetLastError() != null)
                    {
                        Console.WriteLine(injector.GetLastError().Message, "Error, please click the button...");
                        Console.ReadKey();
                    }
                }

            }

            void playSimpleSound()
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.beep);
                simpleSound.Play();
                simpleSound.Dispose();
            }

            Helper.DelMe();
        }
    }
}
