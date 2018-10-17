using System;
using System.Collections.Generic;
using System.Linq;


namespace _12.Inferno_III
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> gems = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();
			var filters = new Dictionary<string, Func<List<int>, List<int>>>();
			string command;
			while ((command = Console.ReadLine()) != "Forge")
			{
				ParseCommand(command)
			}
		}

		private static void ParseCommand(string command)
		{
			string tokens = command.Split();

		}
	}
}
