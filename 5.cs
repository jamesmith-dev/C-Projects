using System;
using System.Linq;

class Program
{
		static int[] numbers1 = { 1, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 29, 30, 31, 32, 33 };
		static int[] numbers2 = { 30, 31, 40, 41, 50, 51, 60, 61, 70, 71, 72, 74, 75, 100, 101, 101, 200 };

		static void Main()
		{
				int[] result = FindCommonOddMultiplesOf5(numbers1, numbers2);

				Console.WriteLine("Common odd numbers that are multiples of 5:");
				foreach (var number in result)
				{
						Console.WriteLine(number);
				}

				Console.ReadKey();
		}

		static int[] FindCommonOddMultiplesOf5(int[] array1, int[] array2)
		{
				var commonOddMultiplesOf5 = array1
						.Intersect(array2) // Find common elements
						.Where(num => num % 2 != 0 && num % 5 == 0) // Filter odd multiples of 5
						.ToArray();

				return commonOddMultiplesOf5;
		}
}
