using System;
using System.Collections.Generic;
using System.Text;

namespace _3_10
{
    class Kurier : IDostawca
    {
        public string lokalizacja;
        public string statusPaczki;
        public string dataWyslania;

        public void Odbierz(int id)
        {
            Console.WriteLine("nie mozna odebrac paczki, paczka nie dotarła");
        }

        public void Status(int id)
        {
            Console.WriteLine(statusPaczki + " lok: "+lokalizacja);
        }

        public int Wyslij()
        {
            return 1;
        }
    }
}
