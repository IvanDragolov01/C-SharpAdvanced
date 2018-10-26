using System;
using System.Collections.Generic;

namespace _04.Even_Times
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<int, int> numbers = new Dictionary<int, int>();

			for (int i = 0; i < n; i++)
			{
				var num = int.Parse(Console.ReadLine());

				if (!numbers.ContainsKey(num))
				{
					numbers.Add(num, 1);
				}
				else
				{
					numbers[num]++;
				}
			}

			foreach (var number in numbers)
			{
				var value = number.Value;

				if (value % 2 == 0)
				{
					Console.Write(number.Key);
				}

			}
		}
	}
}
