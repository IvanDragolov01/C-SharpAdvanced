using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Odd_Lines
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> print = message => Console.WriteLine(message);
			List<string> name = Console.ReadLine().Split(' ').ToList();

			foreach (var word in name)
			{
				print(word);
			}
		}
	}
}
