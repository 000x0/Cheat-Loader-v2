using System;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acedia_Labs_Loader__Beta_
{
    class Program
    {              
        [STAThreadAttribute]
        static void Main(string[] args)
        {           
            Task.Run(() => Protect.Check());
            MenuC.Menu();
        }
    }
}
