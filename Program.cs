using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonoyuncu_Checker
{
    static class Program
    {

        [STAThread]
        private static void Main(string[] args)
        {
            Console.Title = "Sonoyuncu Checker [>]: Royalist Baba";
            Utils.Runner();
            Console.ReadKey();
        }


    }
}
