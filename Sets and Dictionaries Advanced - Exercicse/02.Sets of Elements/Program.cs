using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_of_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
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

			foreach (var item in numbersn)
			{
				var key = item.Key;

				if (numbersm.ContainsKey(key))
				{
					Console.Write(key + " ");
				}
			}
		}
	}
}
