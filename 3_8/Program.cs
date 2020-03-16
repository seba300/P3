using System;
using System.Collections.Generic;

namespace _3_8
{
    class Program
    {
        public static bool printerOk = true;
        static void Main(string[] args)
        {
            Printer printer = new Printer(10);
            printer.OutOfPaperEvent += OutOfPaperEventHandler2;
            printer.OutOfInkEvent += OutOfInkEventHandler2;

            for (int i = 1; i < 12; i++)
            {
                printer.Print(i);
                if (!printerOk)
                {
                    return;
                }
            }
        }

        static void OutOfPaperEventHandler2(object sender, OutOfPaperEventArgs args)
        {
            Console.WriteLine("Please refill the paper. Continue printing from page " + args.PageNumber);
            printerOk = false;
        }
        static void OutOfInkEventHandler2(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine("Please refill ink " + args.Color);
            printerOk = false;
        }
    }
}