using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _3_9
{
    static class ExtensionMethods
    {

        //wynik i resztaZDzielenia mowia co wychodzi z funkcji. To tak jakby tylko komentar
        //this mówi jaki typ rozszerzasz np this string mowi ze na stringu moge dac rozszerzenie
        public static (int wynik, int resztaZDzielenia) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int LiczbaZnakowWZdaniu(this string txt,char znak)
        {
            return txt.Count(x => x == znak);
        }

        public static int SumaGrupWiekowych(this GrupaWiekowa grupa)
        {
            return Enum.GetValues(typeof(GrupaWiekowa)).
                Cast<int>().Sum();

            //int suma = 0;
            //foreach (var item in Enum.GetValues(typeof(GrupaWiekowa)))
            //{
            //    suma += (int)item;
            //}
            //return suma;
        }

        //metoda generyczna
        public static int SumaEnuma<T>(this T element) where T:System.Enum
        {
            return Enum.GetValues(typeof(T)).
                Cast<int>().Sum();
        }

    }


    
}
