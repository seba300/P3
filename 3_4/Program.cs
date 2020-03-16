using System;
using System.Linq;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PoszarpanaTablica();

        }

        static int[][] Kopiujj(int[][] tablica)
        {
            int[][] x = new int[tablica.Length][];

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = new int[tablica[i].Length];

                for (int j = 0; j < tablica[i].Length; j++)
                {
                    x[i][j] = tablica[i][j];
                }
            }

            return x;
        }

        static void PoszarpanaTablica()
        {
            //Tablica poszarpana
            int[][] x = new int[5][];
            for (int i = 1; i <= x.GetLength(0); i++)
            {
                x[i - 1] = new int[i];
            }

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    x[i][j] = i + j;
                }
            }

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    Console.Write(x[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            int[][] y = Kopiujj(x);

            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y[i].Length; j++)
                {
                    Console.Write(y[i][j]);
                }
                Console.WriteLine();
            }
        }

        static void TwoDimensionTab()
        {
            int[,] x = new int[2, 3];
            int[,] y =
            {
                {1,2,3,4,5 },
                {6,7,8,9,10 }
            };

            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    Console.Write(y[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Copy()
        {
            //Shallow copy - kopiowanie eytkiety na wskaźniku
            /*int[] x = { 0 };
            int[] y = x;

            x[0] = 10;
            Console.WriteLine(x[0]);
            Console.WriteLine(y[0]);*/


            //Deep copy - kopiowanie zawartości
            /* int[] z = { 1, 2, 3, 4, 5 };
             int[] k = new int[z.Length];

             for (int i = 0; i < z.Length; i++)
             {
                 k[i] = z[i];
             }

             for (int i = 0; i < z.Length; i++)
             {
                 Console.Write(z[i]+" ");
                 Console.Write(k[i]);
                 Console.WriteLine();
             }*/
        }
    }
}
