using System;

namespace 3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var reklama = new Reklama("Kup teraz", GrupaWiekowa.Dorosli | GrupaWiekowa.Mlodziez,
                 Zainteresowania.Elektronika);

            for (int i = 0; i < GrupaWiekowa.Dorosli.SumaGrupWiekowych(); i++)
            {
                Console.WriteLine((GrupaWiekowa)i);
            }
        }


        static void ZliczZnaki()
        {
            string zdanie = "Ala ma kota a kot ma ale";
            Console.WriteLine(zdanie.LiczbaZnakowWZdaniu('a'));
        }
        static void ZliczReszteZDzielenia()
        {
            int liczba = Convert.ToInt32(Console.ReadLine());
            int wynik;
            int reszta;

            //metoda rozszerzajaca wtedy kiedy ma thisa na poczatku i jest statyczna
            (wynik, reszta) = liczba.DzielenieZReszta(3);
            Console.WriteLine($"{liczba}/3={wynik} r={reszta}");
        }

    }
}
