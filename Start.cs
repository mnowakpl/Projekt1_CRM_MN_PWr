using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_CRM_MN_PWr
{
    public class Start
    {
        private DaneOsobowe pracownicy = new DaneOsobowe();
        private Produktywnosc wyniki = new Produktywnosc();
        private Departamenty depart = new Departamenty();
        public void StartMenu()
        {
            Console.WriteLine("----------------------------------" +
                              "\r\nMICHAŁ NOWAK 249558" +
                              "\r\nPOLITECHNIKA WROCŁAWSKA WEMiF" +
                              "\r\nsemestr zimowy 2020/2021" +
                              "\r\n----------------------------------");
            Console.WriteLine("\r\n\tWITAJ W SYSTEMIE CRC!" +
                              "\r\n " +
                              "\r\n----------------------------------");
            Console.WriteLine("\r\n\tMenu:");
            Console.WriteLine("\t\t 1. \t PRACOWNICY FIRMY");
            Console.WriteLine("\t\t 2. \t DEPARTAMENTY");
            Console.WriteLine("\t\t 3. \t ANALIZA WYNIKÓW");
            Console.WriteLine("\t\t 4. \t INSTRUKCJA");
            Console.Write("\r\nWybierz odpowiednią opcję:");

            switch (Console.ReadLine())
            {
                case "1": OsobyMenu();
                    break;
                case "2": ProduktywnoscMenu();
                    break;
                case "3": DepartMenu();
                    break;
                case "4": Instrukcja(); 
                    break;
            }
        }
        public void OsobyMenu()
        {
            Console.WriteLine("\r\n----------------------------------");
            Console.WriteLine("\r\n\tDostępne działania:");
            Console.WriteLine("\t\t A.\t Wyszukaj pracownika");
            Console.WriteLine("\t\t B.\t Dodaj pracownika");
            Console.WriteLine("\t\t C.\t Usuń pracownika");
            Console.WriteLine("\t\t D.\t INSTRUKCJA");
            Console.WriteLine("\t\t X.\t Powrót do MENU");
            Console.Write("\r\nWybierz odpowiednią opcję:");

            switch (Console.ReadLine())
            {
                case "A": pracownicy.Wyszukaj();
                    break;
                case "B": pracownicy.Dodaj();
                    break;
                case "C": pracownicy.Usun();
                    break;
                case "D": Instrukcja();
                    break;
                case "X": StartMenu();
                    break;
            }
        }
        public void ProduktywnoscMenu()
        {
            Console.WriteLine("\r\n----------------------------------");
            Console.WriteLine("\r\n\tDostępne działania:");
            Console.WriteLine("\t\t A.\t Wyszukaj dane pracownika");
            Console.WriteLine("\t\t B.\t Dodaj dane");
            Console.WriteLine("\t\t C.\t Usuń dane");
            Console.WriteLine("\t\t D.\t INSTRUKCJA");
            Console.WriteLine("\t\t X.\t Powrót do MENU");
            Console.Write("\r\nWybierz odpowiednią opcję:");

            switch (Console.ReadLine())
            {
                case "A": wyniki.Wyszukaj();
                    break;
                case "B": wyniki.Dodaj();
                    break;
                case "C": wyniki.Usun();
                    break;
                case "D": Instrukcja();
                    break;
                case "X": StartMenu();
                    break;
            }
        }
        public void DepartMenu()
        {
            Console.WriteLine("\r\n----------------------------------");
            Console.WriteLine("\r\n\tDostępne działania:");
            Console.WriteLine("\t\t A.\t Wyszukaj dane pracownika");
            Console.WriteLine("\t\t B.\t Dodaj dane");
            Console.WriteLine("\t\t C.\t Usuń dane");
            Console.WriteLine("\t\t D.\t INSTRUKCJA");
            Console.WriteLine("\t\t X.\t Powrót do MENU");
            Console.Write("\r\nWybierz odpowiednią opcję:");

            switch (Console.ReadLine())
            {
                case "A": wyniki.Wyszukaj();
                    break;
                case "B": wyniki.Dodaj();
                    break;
                case "C": wyniki.Usun();
                    break;
                case "D": Instrukcja();
                    break;
                case "X": StartMenu();
                    break;
            }
        }
        public void Instrukcja()
        {
            Console.WriteLine("\r\n------------------------------------------------------------------------------------");
            Console.WriteLine("\r\n\tPo aplikacji należy poruszać się wybierając jedną z dostępnych opcji." +
                              "\r\n\tWybranie nieistniejącej opcji spowoduje brak reakcji aplikacji." +
                              "\r\n\t " +
                              "\r\n\tZakładka 'PRACOWNICY FIRMY' pozwala zarządzać bazą danych osób pracujących w firmie, " +
                              "\r\n\tpoprzez dodawanie lub usuwanie osób, a także łatwy dostęp do wszystkich danych " +
                              "\r\n\tpracownika poprzez jego kod identyfikacyjny." +
                              "\r\n\tZakładka 'PRODUKTYWNOŚĆ' pozwala kontrolować wyniki pracy każdego pracownika" +
                              "\r\n\tpo podaniu jego kodu identyfikacyjnego." +
                              "\r\n\tZakładka 'ANALIZA DANYCH' pozwala dokonać podstawowej analizy ekonomicznej departamentów," +
                              "\r\n\tna podstawie zbioru danych dostępnych w bazie." +
                              "\r\n\t " +
                              "\r\n\tAplikacja operuje na bazach i zbiorach danych zawartych w plikach *.txt" +
                              "\r\n\tznajdujących się w folderze CRC znajdującym się w dokumentach komputera.");
            Console.WriteLine("\r\n\t------------------------------------------------------------------------------------");

            Console.Write("\r\nWybierz X, aby powrócić do MENU:");

            switch (Console.ReadLine())
            {
                case "X":
                    StartMenu();
                    break;
            }
        }
    }
}
