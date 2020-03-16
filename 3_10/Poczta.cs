using System;
using System.Collections.Generic;
using System.Text;

namespace _3_10
{
    class Poczta : IDostawca
    {
        public string lokalizacja;
        public string statusPaczki;
        public string dataWyslania;

        public void Odbierz(int id)
        {
            Console.WriteLine("Paczka odebrana");
        }

        public void Status(int id)
        {
            Console.WriteLine(dataWyslania);
        }

        public int Wyslij()
        {
            return 1;
        }
    }
}
