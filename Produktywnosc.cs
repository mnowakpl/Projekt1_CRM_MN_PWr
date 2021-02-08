using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_CRM_MN_PWr
{
    public class Produktywnosc
    {
        private string imie;
        private string nazwisko;
        private string godzina;
        private string produkcja;
        private double licz_wspol;
        private double proc_wspol;
        private int godz;
        private int prod;
        

        public void Dodaj()
        {
            Console.WriteLine("Wprowadź dane produkcyjne pracownika:");
            Console.Write("\tImię: ");
            imie = Console.ReadLine();

            Console.Write("\tNazwisko: ");
            nazwisko = Console.ReadLine();

            Console.Write("\tPrzepracowane godziny: ");
            godzina = Console.ReadLine();
            godz = int.Parse(godzina);

            Console.Write("\tLiczba wyprodukowanych jednostek: ");
            produkcja = Console.ReadLine();
            prod = int.Parse(produkcja);

            licz_wspol = Wspolczynnik(prod, godz);
            proc_wspol = Procent(prod, godz);

            string nowy = "\r\n" + imie + "\t" + nazwisko + "\t" + licz_wspol + "\t" + proc_wspol + "%";
            File.AppendAllText(@"C:\Users\mnowa\Documents\CRC\daneprodukcja.txt", nowy);

            Console.WriteLine("\r\nDodano nowe dane!");
            Console.WriteLine(nowy);
        }


        public void Wyszukaj()
        {
            string[] t = File.ReadAllLines(@"C:\Users\mnowa\Documents\CRC\daneprodukcja.txt");

            Console.Write("Podaj identyfikator pracownika: ");
            string ids = Console.ReadLine();
            int id = int.Parse(ids);

            string text = t[id - 1];
            string[] wyniktext = text.Split('\t');

            Console.WriteLine("\r\n-------------------------------------------------------------" +
                              "\r\n\tIdentyfikator pracownika: " + id +
                              "\r\n\tImię: " + wyniktext[0] +
                              "\r\n\tNazwisko: " + wyniktext[1] +
                              "\r\n\tWspółczynik produktywności: " + wyniktext[2] +
                              "\r\n\tProcentowy współczynnik: " + wyniktext[3] +
                              "\r\n-------------------------------------------------------------");
        }

        public double Wspolczynnik(int x, int y)
        {
            double wylicz = 1d*x / y;
            return Math.Round(wylicz, 1);
        }

        public double Procent(int x, int y)
        {
            double wsp = 1d * x / y;
            double procentowo = wsp * 100d;
            return Math.Round(procentowo, 2);
        }
    }
}
