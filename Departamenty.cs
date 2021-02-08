using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_CRM_MN_PWr
{
    public class Departamenty
    {
        private string departament;

        public void Dane()
        {
            Console.Write("Wprowadź nazwę departamentu:");
            departament = Console.ReadLine();

            string[] t = File.ReadAllLines(@"C:\Users\mnowa\Documents\CRC\daneosobowe.txt");
            int dl = t.Length;
            int licznik = 0;
            int licznik_K = 0;
            int licznik_M = 0;

            for (int i = 0; i < dl; i++)
            {
                string linia = t[i];
                string[] podzial = linia.Split('\t');

                if (podzial[3] == departament)
                {
                    licznik++;
                    string imie = podzial[0];
                    if (imie[imie.Length - 1] == 'A') licznik_K++;
                    else licznik_M++;
                }
            }

            Console.WriteLine("\n\tLiczba pracowników w departamencie: " + licznik);
            Console.WriteLine("\tW tym kobiet: " + licznik_K + " i mężczyzn: " + licznik_M);
        }

    }
}
