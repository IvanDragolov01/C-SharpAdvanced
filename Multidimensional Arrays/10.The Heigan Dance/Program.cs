using System;
using System.Linq;

namespace TheHeiganDance
{
	class Program
	{
		const int Min = 0;
		const int Max = 14;
		const int CloudDamage = 3500;
		const int EruptionDamage = 6000;
		static int _playerRow = 7;
		static int _playerCol = 7;
		static string _causeOfDeath;
		static double _heiganHealth = 3000000.0;
		static int _playerHealth = 18500;
		static bool _hasCloud = false;

		static void Main(string[] args)
		{
			double playerDamage = double.Parse(Console.ReadLine());

			while (_playerHealth > 0)
			{
				_heiganHealth -= playerDamage;

				if (_hasCloud)
				{
					_playerHealth -= CloudDamage;
					_hasCloud = false;
					_causeOfDeath = "Plague Cloud";
				}

				if (_heiganHealth <= 0 || _playerHealth <= 0)
				{
					break;
				}

				string[] spellTokens = Console.ReadLine().Split();
				string spellName = spellTokens[0];
				int rowHit = int.Parse(spellTokens[1]);
				int colHit = int.Parse(spellTokens[2]);
				int[][] damageArea = GetDamageArea(rowHit, colHit);

				if (IsPlayerInDamageZone(damageArea))
				{
					TryToMove(damageArea, spellName);

				}
			}

			string heiganFinish = _heiganHealth > 0 ? _heiganHealth.ToString("f2") : "Defeated!";
			string playerFinish = _playerHealth > 0 ? _playerHealth.ToString() : $"Killed by {_causeOfDeath}";
			Console.WriteLine($"Heigan: {heiganFinish}");
			Console.WriteLine($"Player: {playerFinish}");
			Console.WriteLine($"Final position: {_playerRow}, {_playerCol}");
		}

		private static bool IsPlayerInDamageZone(int[][] damageArea)
		{
			bool isInRowsHit = damageArea[0].Contains(_playerRow);
			bool isInColsHit = damageArea[1].Contains(_playerCol);
			return isInRowsHit && isInColsHit;
		}

		private static int[][] GetDamageArea(int rowHit, int colHit)
		{
			int[][] damageArea = new int[2][];
			damageArea[0] = new int[3];
			damageArea[1] = new int[3];

			for (int i = 0; i < 3; i++)
			{
				damageArea[0][i] = rowHit + i - 1;
			}

			for (int i = 0; i < 3; i++)
			{
				damageArea[1][i] = colHit + i - 1;
			}

			return damageArea;
		}

		private static void TryToMove(int[][] damageArea, string spellName)
		{
			int rowAbove = _playerRow - 1;
			int rowBelow = _playerRow + 1;
			int leftCol = _playerCol - 1;
			int rightCol = _playerCol + 1;

			if (_playerRow - 1 >= Min && !damageArea[0].Contains(rowAbove))
			{
				_playerRow = rowAbove;
			}
			else if (rightCol <= Max && !damageArea[1].Contains(rightCol))
			{
				_playerCol = rightCol;
			}
			else if (rowBelow <= Max && !damageArea[0].Contains(rowBelow))
			{
				_playerRow = rowBelow;
			}
			else if (leftCol >= Min && !damageArea[1].Contains(leftCol))
			{
				_playerCol = leftCol;
			}
			else
			{
				TakeDamage(spellName);
			}
		}

		private static void TakeDamage(string spellName)
		{
			if (spellName == "Cloud")
			{
				_playerHealth -= CloudDamage;
				_hasCloud = true;
				_causeOfDeath = "Plague Cloud";
			}
			else
			{
				_playerHealth -= EruptionDamage;
				_causeOfDeath = "Eruption";
			}
		}
	}
}