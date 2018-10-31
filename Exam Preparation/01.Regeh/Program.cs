using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Regeh
{
	class Program
	{
		static void Main(string[] args)
		{
			string pattern = @"\[[a-zA-Z]+<(\d+)REGEH(\d+)>[a-zA-Z]+\]";
			var input = Console.ReadLine();
			var regex = new Regex(pattern);
			var indexes = new List<int>();

			foreach (Match match in regex.Matches(input))
			{
				var groupsValue = match.Groups[1].ToString();
				indexes.Add(int.Parse(match.Groups[1].Value));
				indexes.Add(int.Parse(match.Groups[2].Value));
			}

			int currentIndex = 0;

			foreach (var index in indexes)
			{
				currentIndex += index;
				var charIndex = currentIndex % (input.Length - 1);
				Console.Write(input[charIndex]);
			}
		}
	}
}
