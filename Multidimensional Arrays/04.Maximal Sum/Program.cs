using System;
using System.Linq;
namespace _04.Maximal_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] rowsAndColumns = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
			int maxsum = 0, currentsum = 0;
			int startCol = 0, startRow = 0;

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				var rowValues = Console.ReadLine()
					.Split(new[] { ' ' }
						, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse).ToArray();
				for (int cols = 0; cols < matrix.GetLength(1); cols++)
				{
					matrix[row, cols] = rowValues[cols];
				}
			}

			for (int row = 0; row < matrix.GetLength(0) - 2; row++)
			{
				for (int col = 0; col < matrix.GetLength(1) - 2; col++)
				{
					currentsum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] +
					+matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1] +
					+matrix[row + 2, col + 2] + matrix[row + 2, col] + matrix[row, col + 2];

					if (maxsum < currentsum)
					{
						maxsum = currentsum;
						startCol = col;
						startRow = row;
					}
				}
			}

			Console.WriteLine("Sum = " + maxsum);

			for (int row = startRow; row < startRow + 3; row++)
			{
				for (int col = startCol; col < startCol + 3; col++)
				{
					Console.Write(matrix[row, col] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
