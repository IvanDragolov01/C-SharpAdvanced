using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Advanced___Exercicse
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, string> names = new Dictionary<string, string>();

			for (int i = 0; i < n; i++)
			{
				string brnames = Console.ReadLine();

				if (!names.ContainsKey(brnames))
				{
					names.Add(brnames, " ");
				}
			}

			foreach (var name in names)
			{
				var key = name.Key;
				Console.WriteLine(key);
			}
		}
	}
}
