using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Acedia_Labs_Loader__Beta_
{
    class Premium
    {
        
        public static void Prem()
        {
            Console.Clear();
            string hw = GHW.GetHWID();
            string str;
            using (StreamReader strr = new StreamReader(HttpWebRequest.Create("your server" + hw).GetResponse().GetResponseStream()))
                str = strr.ReadToEnd();

            if (str == "{\"status\":\"ok\"}")
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("Please wait, we are introducing cheat into the game...");
                PremiumINJ.inj();
            }

            else
            {
                Console.WriteLine("Please buy a license.");
                Console.WriteLine("If this is an error, please contact me in Vkontakte https://vk.com/aikosimidzu");
                Console.WriteLine("Before you write to me, you need to know what could have caused this:");
                Console.WriteLine("1. This could be due to a lack of connection to the server");
                Console.WriteLine("2. Our server is temporarily unavailable");
                Console.WriteLine("3. Your ISP blocks access to the server");
                Console.WriteLine("4. System error");
                Console.WriteLine("5. Your antivirus blocks connection to the server");
                Console.WriteLine("To solve these problems, you can download VPN.");
                Console.WriteLine("Turn off the Internet protection in the antivirus or the firewall. This is a temporary solution, after a successful injection, you can turn them on.");
                Console.WriteLine("Try to run the program as administrator or without");
            }
            Console.ReadKey();
        }
    }
}
