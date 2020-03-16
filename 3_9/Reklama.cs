using System;
using System.Collections.Generic;
using System.Text;

namespace _3_9
{
    class Reklama
    {
        public string Tekst { get; set; }
        public GrupaWiekowa grupaWiekowa;
        public Zainteresowania zainteresowania;

        public Reklama(string tekst, GrupaWiekowa grupaWiekowa, Zainteresowania zainteresowania)
        {
            Tekst = tekst;
            this.grupaWiekowa = grupaWiekowa;
            this.zainteresowania = zainteresowania;
        }
    }
}
