using System;
using System.Linq;
namespace _08.Custom_Comparator
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] max = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int[] max1 = { };
			int[] max2 = { };
			int p = 0, p2 = 0;
			Func<int, int> isDivesible1 = x => x % 2;
			Func<int, int> isDivesible2 = x => x % 2;
			for (int i = 0; i < max.Length; i++)
			{
				if (isDivesible1(max[i]) != 0)
				{
					foreach (var number in max)
					{
						max1[p] = number;
						p++;
					}
				}
			}
			for (int i = 0; i < max.Length; i++)
			{
				if (isDivesible2(max[i]) == 0)
				{
					foreach (var number in max)
					{
						max2[p2] = number;
						p++;
					}
				}
			}
			int[] max3 = max1.Concat(max2).ToArray();
			for (int i = 0; i < max3.Length; i++)
			{
				Console.WriteLine(max3[i]);
			}
		}
	}
}
