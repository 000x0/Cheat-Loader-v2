using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acedia_Labs_Loader__Beta_
{
    class MenuC
    {
        static public void Menu()
        {            
            Console.Clear();
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("### Powered by Aiko ###");
            }
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Inject\n");
                Console.WriteLine("2. Copy my HWID\n");
                Console.WriteLine("Please, select menu.");                
            }

            String str = Console.ReadLine();

            void prem()
            {
                Premium.Prem();
            }

            void cop()
            {
                Clipboard.Clear();
                Clipboard.SetText(GHW.GetHWID());
                Console.WriteLine("Done, please enter button.");
                Console.ReadKey();
                MenuC.Menu();
            }

            switch (str)
            {
                case "1":
                    prem();
                    break;
               
                case "2":
                    cop();
                    break;
            }
        }
       
    }
}
