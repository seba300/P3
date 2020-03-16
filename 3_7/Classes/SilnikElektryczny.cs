using Dziedziczenie;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_7
{
    class SilnikElektryczny : Silnik
    {
        public SilnikElektryczny(int moc, double spalanie, string dzwiek) : base(moc, spalanie, "pykpykpyk")
        {

        }
    }
}
