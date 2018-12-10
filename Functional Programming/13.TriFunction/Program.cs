using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.TriFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = int.Parse(Console.ReadLine());
			List<string> names = Console.ReadLine()
				.Split(' ')
				.ToList();

			Console.WriteLine(names.FirstOrDefault(name => name.ToCharArray().Sum(c => c) >= sum));
		}
	}
}
