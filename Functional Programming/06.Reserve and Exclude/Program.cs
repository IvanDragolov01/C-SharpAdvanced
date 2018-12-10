using System;
using System.Linq;

namespace _06.Reserve_and_Exclude
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] max = Console.ReadLine().Split(" ")
				.Select(int.Parse)
				.ToArray();

			int n = int.Parse(Console.ReadLine());

			Func<int, int, int> isDivesible = (int x, int b) => x % b;
			Action<int> print = x => Console.Write(x + " ");

			for (int i = max.Length - 1; i >= 0; i--)
			{
				if (isDivesible(max[i], n) != 0)
				{
					print(max[i]);
				}
			}
		}
	}
}