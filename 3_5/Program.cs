using System;

namespace _3_5
{
	class Program
	{
		static void Main(string[] args)
		{
			//GR A, 16:40

			//ZAD1
			Console.WriteLine(Zad1a(10));
			Console.WriteLine();
			//

			//ZAD2
			//Do zmiennej wrzucamy dzien do ktorego ma sie wyswietlac suma pienedzy z dni msc
			int dzienMsc = 30;
			float[] zyskiDoDnia = new float[dzienMsc];

			zyskiDoDnia = Zad2a(dzienMsc);

			for (int i = 0; i < dzienMsc; i++)
			{
				Console.WriteLine("Dzień " + (i + 1) + ": " + zyskiDoDnia[i]);
			}
			Console.WriteLine();
			//

			//ZAD3
			int[][] tab = new int[5][];
			int n = 2;

			for (int i = 0; i < tab.GetLength(0); i++)
			{
				tab[i] = new int[n];

				for (int j = 0; j < tab[i].Length; j++)
				{
					tab[i][j] += (i + j);
				}
			}

			Console.WriteLine("Tab poszarpana");
			foreach (var item in tab)
			{
				foreach (var item2 in item)
				{
					Console.WriteLine(item2);
				}

			}

			int[,] nowaTab = Zad3a(tab);
			Console.WriteLine("Tab kwadratowa");
			foreach (var item in nowaTab)
			{
				Console.WriteLine(item);
			}
			//

		}

		//ZAD3
		static int[,] Zad3a(int[][] tab)
		{

			int[,] nowaTab = new int[tab.GetLength(0), tab[0].GetLength(0)];

			for (int i = 0; i < tab.GetLength(0); i++)
			{
				for (int j = 0; j < tab[i].Length; j++)
				{
					nowaTab[i, j] = tab[i][j];
				}
			}

			return nowaTab;

		}

		//ZAD2
		static float[] Zad2a(int dzienMsc)
		{
			//Tablica 30 dni
			float[] zyski = {
				1,2,3,4,5,6,7,8,9,10,
				11,12,13,14,15,16,17,18,19,20,
				21,22,23,24,25,26,27,28,29,30 };

			float[] zysDoDnia = new float[dzienMsc];
			float suma = 0;

			for (int i = 0; i < dzienMsc; i++)
			{
				suma += zyski[i];
				zysDoDnia[i] = suma;
			}

			return zysDoDnia;
		}

		//ZAD1
		static double Zad1a(double x)
		{
			return 2 * Math.Pow(x, 3) - 8 * Math.Pow(x, 2) - 3 * x + 10;
		}
	}
}
