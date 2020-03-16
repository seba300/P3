using System;
using System.Collections.Generic;
using System.Text;

namespace _3_10
{
    static class ExtensionMethodDateTime
    {
        public static string GetDate(this DateTime abc)
        {
            if((DateTime.Now.Day - abc.Day) < 1) return String.Concat("Wczoraj " + (DateTime.Now.Hour - abc.Hour));
            if ((DateTime.Now.Hour - abc.Hour) < 1) return String.Concat("Przed chwilą ");
            else return abc.ToString();


        }
    }
}
