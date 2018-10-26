using System;
using System.Collections.Generic;

namespace _05.Count_Symbols
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
			char[] sym = Console.ReadLine().ToCharArray();

			foreach (char symbol in sym)
			{
				if (!symbols.ContainsKey(symbol))
				{
					symbols.Add(symbol, 1);
				}
				else
				{
					symbols[symbol]++;
				}
			}

			foreach (var symbol in symbols)
			{
				var key = symbol.Key;
				var value = symbol.Value;
				Console.WriteLine(key + ": " + value + " time/s");
			}
		}
	}
}
