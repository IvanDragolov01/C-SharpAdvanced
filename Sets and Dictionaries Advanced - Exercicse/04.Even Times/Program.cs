using System;
using System.Collections.Generic;
using System.Linq;

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

			foreach (KeyValuePair<int, int> number in numbers)
			{
				int value = number.Value;

				if (value % 2 == 0)
				{
					Console.Write(number.Key);
				}
			}

			//second solution
			//int n = int.Parse(Console.ReadLine());
			//Dictionary<int, int> numbers = new Dictionary<int, int>();

			//for (int i = 0; i < n; i++)
			//{
			//	int num = int.Parse(Console.ReadLine());

			//	if (!numbers.ContainsKey(num))
			//	{
			//		numbers.Add(num, 0);
			//	}
			//	numbers[num]++;
			//}

			//Console.WriteLine(numbers.Where(x => x.Value % 2 == 0).FirstOrDefault().Key);
		}
	}
}
