using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.The_V_Logger
{
	class Program
	{
		public static void Main(string[] args)
		{
			var vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
			string input;

			do
			{
				input = Console.ReadLine();
			}
			while (input != "Statistics");
			{
				string[] elements = input.Split();
				string user = elements[0];
				string command = elements[1];
				string targetUser = elements[2];

				if (command == "joined")
				{
					if (!vloggers.ContainsKey(user))
					{
						vloggers.Add(user, new Dictionary<string, SortedSet<string>>());
						vloggers[user].Add("following", new SortedSet<string>());
						vloggers[user].Add("followers", new SortedSet<string>());
					}
				}
				else if (command == "followed")
				{
					bool isSameVloggers = user == targetUser;

					if (vloggers.ContainsKey(user) && vloggers.ContainsKey(targetUser) && !isSameVloggers)
					{
						vloggers[user]["following"].Add(targetUser);
						vloggers[targetUser]["followers"].Add(user);
					}
				}
			}

			Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

			var sortedVloggers = vloggers.OrderByDescending(x => x.Value["followers"].Count)
													.ThenBy(x => x.Value["following"].Count);
			int counter = 1;

			foreach (var item in sortedVloggers)
			{
				Console.WriteLine($"{counter}. {item.Key} : {item.Value["followers"].Count} followers," +
								  $" {item.Value["following"].Count} following");

				if (counter == 1)
				{
					foreach (string followerName in item.Value["followers"])
					{
						Console.WriteLine($"*  {followerName}");
					}
				}

				counter++;
			}
		}
	}
}
