using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var clothes = new Dictionary<string, Dictionary<string, int>>();

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split(" -> ");
				string color = input[0];
				string[] clothesstr = input[1].Split(',');

				if (!clothes.ContainsKey(color))
				{
					clothes.Add(color, new Dictionary<string, int>());
				}

				for (int j = 0; j < clothesstr.Length; j++)
				{
					string currentItem = clothesstr[j];

					if (!clothes[color].ContainsKey(currentItem))
					{
						clothes[color].Add(currentItem, 0);
					}

					clothes[color][currentItem] += 1;
				}
			}

			string[] targetItem = Console.ReadLine().Split();
			string targetColor = targetItem[0];
			string itemName = targetItem[1];

			foreach (KeyValuePair<string, Dictionary<string, int>> kvp in clothes)
			{
				Console.WriteLine($"{kvp.Key} clothes:");

				foreach (KeyValuePair<string, int> item in kvp.Value)
				{
					Console.Write($"* {item.Key} - {item.Value}");

					if (kvp.Key == targetColor && item.Key == itemName)
					{
						Console.Write(" (found!)");
					}

					Console.WriteLine();
				}
			}
		}
	}
}
