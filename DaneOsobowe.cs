using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_CRM_MN_PWr
{
    public class DaneOsobowe
    {
        private string imie;
        private string nazwisko;
        private string telefon;
        private string departament;

        public void Dodaj()
        {
            Console.WriteLine("Wprowadź dane nowego pracownika:");
            Console.Write("\tImię: ");
            imie = Console.ReadLine();

            Console.Write("\tNazwisko: ");
            nazwisko = Console.ReadLine();

            Console.Write("\tNumer telefonu: ");
            telefon = Console.ReadLine();

            Console.Write("\tDepartament: ");
            departament = Console.ReadLine();

            string nowy = "\r\n" + imie + "\t" + nazwisko + "\t" + telefon + "\t" + departament;
            File.AppendAllText(@"C:\Users\mnowa\Documents\CRC\daneosobowe.txt", nowy);

            Console.WriteLine("\r\nDodano nowego pracownika!");
            Console.WriteLine(nowy);
        }

        public void Usun()
        {
            string[] t = File.ReadAllLines(@"C:\Users\mnowa\Documents\CRC\daneosobowe.txt");
            Console.Write("Podaj identyfikator pracownika, którego chcesz usunąć: ");
            string ids = Console.ReadLine();
            int id = Int32.Parse(ids);

            int dl = t.Length;
            string[] n = new string[dl-1];

            for (int i = 0; i < id; i++)
            {
                n[i] = t[i];
            }

            for (int i = id-1; i < dl-1; i++)
            {
                n[i] = t[i + 1];
            }

            File.WriteAllLines(@"C:\Users\mnowa\Documents\CRC\bazazastepcza.txt", n);
            File.Replace(@"C:\Users\mnowa\Documents\CRC\bazazastepcza.txt", @"C:\Users\mnowa\Documents\CRC\daneosobowe.txt", @"C:\Users\mnowa\Documents\CRC\kopiazapasowa_daneosobowe.txt");
            
            Console.WriteLine("Wskazany pracownik został usunięty z bazy!");
        }

        public void Wyszukaj()
        {
            string[] t = File.ReadAllLines(@"C:\Users\mnowa\Documents\CRC\daneosobowe.txt");

            Console.Write("Podaj identyfikator pracownika: ");
            string ids = Console.ReadLine();
            int id = Int32.Parse(ids);

            string text = t[id - 1];
            string[] wyniktext = text.Split('\t');

            Console.WriteLine("\r\n-------------------------------------------------------------" +
                              "\r\n\tIdentyfikator pracownika: " + id +
                              "\r\n\tImię: " + wyniktext[0] +
                              "\r\n\tNazwisko: " + wyniktext[1] +
                              "\r\n\tNumer telefonu: " + wyniktext[2] +
                              "\r\n\tDepartament: " + wyniktext[3] +
                              "\r\n-------------------------------------------------------------");

        }
    }
}
