using System;
using System.Collections.Generic;
using System.Text;

namespace _3_8
{
    public class OutOfInkEventArgs : EventArgs
    {
        public OutOfInkEventArgs(string c)
        {
            Color = c;
        }
        public string Color { get; set; }
    }
}
