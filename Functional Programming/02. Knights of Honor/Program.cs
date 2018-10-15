using System;
using System.Linq;
namespace _02._Knights_of_Honor
{
	class Program
	{
		static void Main(string[] args)
		{
			Action<string> print = message => Console.WriteLine("Sir " + message);
			var name = Console.ReadLine().Split(' ').ToList();

			foreach (var word in name)
			{
				print(word);
			}
		}
	}
}
