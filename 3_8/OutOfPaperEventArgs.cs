using System;
using System.Collections.Generic;
using System.Text;

namespace _3_8
{
    public class OutOfPaperEventArgs : EventArgs
    {
        public int PageNumber { get; set; }
        public OutOfPaperEventArgs(int pgnum)
        {
            PageNumber = pgnum;
        }
    }
}
