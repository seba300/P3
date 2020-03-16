using System;
using System.Collections.Generic;
using System.Text;

namespace _3_9
{
    //enumy beda reprezentowane flaga bitowa
    [Flags]
    public enum GrupaWiekowa
    {
        Brak = 0,
        Dzieci = 1,//[0001]
        Mlodziez = 2,//[0010]
        Dorosli = 4,//[0100]
        Starsi = 8,//[1000]
       // Pelnoletni = 12//dorosli + starci bo 8+4
    }

    public enum Zainteresowania
    {
        Komputery,
        Gaming,
        Elektronika,
        Motoryzacja
    }
}
