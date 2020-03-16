using System;
using System.Collections.Generic;
using System.Text;

namespace _3_10
{
    public enum Gatunek
    {
        Horror,
        Komedia,
        Dramat
    }
    class Ksiazka
    {
        public string Tytul;
        public string Autor;
        public Gatunek gatunek;
    }
}
