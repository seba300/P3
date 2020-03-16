using System;

namespace _3_2
{
    class Program
    {
        static int[] licznik = { 0, 0, 0 };
        static int cel = 10;
        static void Main(string[] args)
        {
            etykieta();

        }
        static int suma()
        {
            int suma = 0;
            for (int i = 0; i < licznik.Length; i++)
            {
                suma += licznik[i];
            }
            return suma;
        }
        public static void etykieta()
        {

            while (suma() != cel + 1)
            {
                string tekst = Console.ReadLine();
                switch (tekst)
                {
                    case "1":
                        drukujEtykiete(1);
                        break;
                    case "2":
                        drukujEtykiete(2);
                        break;
                    case "3":
                        drukujEtykiete(3);
                        break;
                    default:
                        break;
                }

            }
        }
        public static void drukujEtykiete(int index)
        {
            Console.WriteLine("Etykieta " + licznik[index - 1]);
            licznik[index - 1]++;
        }
        public static void wozek()
        {
            int odleglosc = -1;
            int ileRazy = 0;
            int suma = 0;
            string odp;
            float srednia;

            while (odleglosc != 0)
            {
                odp = Console.ReadLine();
                odleglosc = Convert.ToInt32(odp);
                suma += odleglosc;
                ileRazy++;
            }

            srednia = (float)suma / (ileRazy - 1);
            Console.WriteLine("Srednia odleglosc {0}", srednia);

        }
        public static void evenNumber()
        {
            int liczba;
            Console.WriteLine("Wpisz liczbe");

            string txt = Console.ReadLine();

            liczba = Convert.ToInt32(txt);

            if (liczba % 2 == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nie parzysta");
            }

            //if terrarny
            Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta");
        }
    }
}