using System;
using System.Collections.Generic;
using System.Text;

namespace _3_8
{
    public class Ink
    {
        public string Color { get; set; }
        public double Level { get; set; }

        public Ink(string c, double l)
        {
            Color = c;
            Level = l;
        }
    }
}
