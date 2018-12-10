using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> print = message => Console.WriteLine("Sir " + message);
			List<string> name = Console.ReadLine().Split(' ').ToList();

			foreach (string word in name)
			{
				print(word);
			}
		}
	}
}
