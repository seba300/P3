using System;
using System.Collections.Generic;
using System.Text;

namespace _3_8
{
    class Printer
    {
        public event EventHandler<OutOfPaperEventArgs> OutOfPaperEvent;
        public event EventHandler<OutOfInkEventArgs> OutOfInkEvent;
        private int _paperCount { get; set; }

        private List<Ink> _inks;
        private Random _random = new Random();
        public void Print(int pageNumber)
        {
            if (_paperCount == 0)
            {
                OutOfPaperEvent?.Invoke(this, new OutOfPaperEventArgs(pageNumber));
                return;
            }
            else
            {
                foreach (var ink in _inks)
                {
                    if (ink.Level <= 0)
                    {
                        OutOfInkEvent.Invoke(this, new OutOfInkEventArgs(ink.Color));
                        return;
                    }
                }

                Console.WriteLine("Printing");
                --_paperCount;
                foreach (var ink in _inks)
                {
                    ink.Level -= _random.NextDouble();
                }
            }
        }
        private void OutOfPaperEventHandler(object sender, OutOfPaperEventArgs args)
        {
            Console.WriteLine("[Printer log] Out of paper");
        }
        private void OutOfInkEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine("[Printer log] Out of ink " + args.Color);
        }
        public Printer(int paperCount) : this()
        {
            _paperCount = paperCount;
        }
        public Printer()
        {
            OutOfPaperEvent += OutOfPaperEventHandler;
            OutOfInkEvent += OutOfInkEventHandler;
            _inks = new List<Ink>{
                new Ink("Black",1),
                new Ink("Green",1),
                new Ink("Blue",1),
                new Ink("Red",1)
            };
        }
    }
}
