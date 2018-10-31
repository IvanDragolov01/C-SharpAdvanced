using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_of_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

			Dictionary<int, int> numbersn = new Dictionary<int, int>();
			Dictionary<int, int> numbersm = new Dictionary<int, int>();

			for (int i = 0; i < n[0]; i++)
			{
				int brnumbers1 = int.Parse(Console.ReadLine());

				if (!numbersn.ContainsKey(brnumbers1))
				{
					numbersn.Add(brnumbers1, 1);
				}
			}

			for (int i = 0; i < n[1]; i++)
			{
				int brnumbers2 = int.Parse(Console.ReadLine());

				if (!numbersm.ContainsKey(brnumbers2))
				{
					numbersm.Add(brnumbers2, 1);
				}
			}

			foreach (KeyValuePair<int, int> item in numbersn)
			{
				int key = item.Key;

				if (numbersm.ContainsKey(key))
				{
					Console.Write(key + " ");
				}
			}

			//second solution -Hash Set
			//HashSet<int> firstSet = new HashSet<int>();
			//HashSet<int> secondSet = new HashSet<int>();

			//int[] length = Console.ReadLine().Split().Select(int.Parse).ToArray();
			//int n = length[0];
			//int m = length[1];

			//for (int i = 0; i < n; i++)
			//{
			//	int currentNumber = int.Parse(Console.ReadLine());
			//	firstSet.Add(currentNumber);
			//}

			//for (int i = 0; i < m; i++)
			//{
			//	int currentNumber = int.Parse(Console.ReadLine());
			//	secondSet.Add(currentNumber);
			//}

			//foreach (int number in firstSet)
			//{
			//	if (secondSet.Contains(number))
			//	{
			//		Console.Write(number + " ");
			//	}
			//}
		}
	}
}
