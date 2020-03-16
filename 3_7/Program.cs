using Dziedziczenie;
using System;

namespace _3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            IPojazd auto = new Osobowka(new SilnikBenzyna(120, 4, "pyrpyrpyr"));
            auto.Jedz(120);
        }
    }
}
