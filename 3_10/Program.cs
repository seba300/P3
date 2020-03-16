using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();
            Zad3();
            Zad4();

        }

        static void Zad4()
        {
            Poczta p1 = new Poczta();
            Kurier p2 = new Kurier();

            p1.lokalizacja = "Brno";
            p1.dataWyslania = "Poniedziałek";
            p1.statusPaczki = "Pakowana";
            p1.Odbierz(12);
            p1.Wyslij();
            p1.Status(12);

            p2.lokalizacja = "Wrocław";
            p2.dataWyslania = "Wtorek";
            p2.statusPaczki = "Wysłana";
            p2.Odbierz(145);
            p2.Wyslij();
            p2.Status(12);
        }
        static void Zad3()
        {
            List<Ksiazka> ksiazki = new List<Ksiazka>();
            ksiazki.Add(new Ksiazka());
            ksiazki.Add(new Ksiazka());
            ksiazki.Add(new Ksiazka());
            ksiazki.Add(new Ksiazka());
            ksiazki[0].gatunek = Gatunek.Horror;
            ksiazki[0].Tytul = "Kac Vegas";

            ksiazki[1].gatunek = Gatunek.Komedia;
            ksiazki[1].Tytul = "Moby Dick";

            ksiazki[2].gatunek = Gatunek.Dramat;
            ksiazki[2].Tytul = "Weosły swiat gumbala";

            ksiazki[3].gatunek = Gatunek.Horror;
            ksiazki[3].Tytul = "wampiry i spolka";

            Console.WriteLine("Gatunek:");
            string decyzjaUzytkownika = Console.ReadLine();

            var result = ksiazki.Where(x => x.gatunek.ToString() == decyzjaUzytkownika);
            foreach (var item in result)
            {
                Console.WriteLine(item.Tytul + " - " + item.gatunek);
            }
        }

        static void Zad2()
        {
            DateTime data = new DateTime(2020, 01, 27, 10, 2, 59);
            Console.WriteLine(data.GetDate());
        }
        static void Zad1()
        {
            List<Komputer> Inwentaryzacja = new List<Komputer>();
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                Inwentaryzacja.Add(new Komputer());
            }

            //5
            Inwentaryzacja[0].Procesor = "Amd x901";
            Inwentaryzacja[1].Procesor = "Amd x901";
            Inwentaryzacja[2].Procesor = "Amd Xenof";
            Inwentaryzacja[3].Procesor = "Intel i5";
            Inwentaryzacja[4].Procesor = "Intel i7";
            Inwentaryzacja[5].Procesor = "Intel i5";
            Inwentaryzacja[6].Procesor = "Intel i3";

            List<Procesor> Procesory = new List<Procesor>();
            for (int i = 0; i < n; i++)
            {
                Procesory.Add(new Procesor());
            }

            for (int i = 0; i < n; i++)
            {
                Procesory[i].nazwa = Inwentaryzacja[i].Procesor;
            }

            List<string> unikalneProcesory = new List<string>();

            var result = Procesory.Select(x => x.nazwa).Distinct().ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
