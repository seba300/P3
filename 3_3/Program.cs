using System;
using System.Text;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string text = "";
            while (text != "stop")
            {
                text = Console.ReadLine();
                builder.Append(text + ",");
            }

            string[] arr = builder.ToString().Split(new[] { ",", ";", " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] tablica = new int[arr.Length];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = Convert.ToInt32(arr[i]);
            }
            int suma = 0;
            foreach (int ocena in tablica)
            {
                suma += ocena;
            }

            float wynik = (float)suma / tablica.Length;
            Console.WriteLine(wynik.ToString());
            Console.Read();
        }
    }
}