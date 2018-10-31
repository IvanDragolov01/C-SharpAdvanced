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
				string key = name.Key;
				Console.WriteLine(key);
			}


			//second solution - HastSet
			//int n = int.Parse(Console.ReadLine());
			//HashSet<string> uniquenames = new HashSet<string>();

			//for (int i = 0; i < n; i++)
			//{
			//	string names = Console.ReadLine();
			//	uniquenames.Add(names);
			//}

			//Console.WriteLine(string.Join(Environment.NewLine, uniquenames));

		}
	}
}
