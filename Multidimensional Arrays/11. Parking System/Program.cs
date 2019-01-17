using System;
using System.Linq;
namespace _11._Parking_System
{
	class Program
	{
		static bool[][] _parking;
		static int _rows;
		static int _cols;

		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			_rows = dimensions[0];
			_cols = dimensions[1];
			_parking = new bool[_rows][];
			string command;

			while ((command = Console.ReadLine()) != "stop")
			{
				int[] commandArgs = command
					.Split()
					.Select(int.Parse).
					ToArray();

				int entryRow = commandArgs[0];
				int targetRow = commandArgs[1];
				int targetCol = commandArgs[2];

				if (IsSpotTaken(targetRow, targetCol))
				{
					targetCol = TryFindFreeSpot(targetRow, targetCol);
				}

				if (targetCol > 0)
				{
					MarkSpotAsTaken(targetRow, targetCol);
					int distancePassed = Math.Abs(entryRow - targetRow) + targetCol + 1;
					Console.WriteLine(distancePassed);
				}
				else
				{
					Console.WriteLine($"Row {targetRow} full");
				}
			}
		}

		private static void MarkSpotAsTaken(int targetRow, int targetCol)
		{
			if (_parking[targetRow] == null)
			{
				_parking[targetRow] = new bool[_cols];
			}

			_parking[targetRow][targetCol] = true;
		}

		private static int TryFindFreeSpot(int targetRow, int targetCol)
		{
			int parkingCol = 0;
			int bestDistance = int.MaxValue;
			//int bestDistance = 10001 same result
			for (int currentcol = 1; currentcol < _cols; currentcol++)
			{
				if (!_parking[targetRow][currentcol])
				{
					int distance = Math.Abs(currentcol - targetCol);

					if (distance < bestDistance)
					{
						parkingCol = currentcol;
						bestDistance = distance;
					}
				}
			}

			return parkingCol;
		}

		private static bool IsSpotTaken(int targetRow, int targetCol)
		{
			return _parking[targetRow] != null && _parking[targetRow][targetCol];
		}
	}
}
