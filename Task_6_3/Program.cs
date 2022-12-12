using Microsoft.VisualBasic.FileIO;
using System;
using System.Security.Cryptography;

namespace Task_6_3 
{
	class Program
	{
		static void Main()
		{
			try
			{
				int[,] mas;

				Console.WriteLine("Введите значения для двумерного массива");
				Console.Write("n = ");
				int n = Convert.ToInt32(Console.ReadLine());
				Console.Write("m = ");
				int m = Convert.ToInt32(Console.ReadLine());

				if (n < 1 || m < 1) throw new Exception();
				mas = new int[n, m];


				Console.WriteLine("Введите значения массива");
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						mas[i,j] = Convert.ToInt32(Console.ReadLine());
					}
				}

				Console.WriteLine("\nМассив до изменений столбцов");

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						Console.Write(mas[i, j] + "\t");
					}
					Console.WriteLine();
				}

				Console.WriteLine("\nМассив после изменений столбцов");

				if (m % 2 == 0)
				{
					int a = (m / 2) - 1;
					int b = m / 2;
					int[] temp = new int[n];

					for (int i = 0; i < n; i++)
					{
						temp[i] = mas[i, a];
						mas[i, a] = mas[i, b];
						mas[i, b] = temp[i];
					}
				}
				else
				{
					int a = (int)decimal.Round((m / 2), MidpointRounding.AwayFromZero);
					int b = 0;
					int[] temp = new int[n];

					for (int i = 0; i < n; i++)
					{
						temp[i] = mas[i, a];
						mas[i, a] = mas[i, b];
						mas[i, b] = temp[i];
					}
				}

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						Console.Write(mas[i, j] + "\t");
					}
					Console.WriteLine();
				}

			}
			catch (FormatException)
			{
				Console.WriteLine("Введите корректные значения");
			}
			catch
			{
				Console.WriteLine("n и m должны быть натуральным числом");
			}

		}
	}
}