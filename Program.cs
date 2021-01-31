using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Emit;

namespace Projekt1_CRM_MN_PWr
{
    class Program
    {
        static void Main(string[] args)
        {
            Start menu = new Start();
            menu.StartMenu();

            Console.ReadKey();
        }
    }
}
