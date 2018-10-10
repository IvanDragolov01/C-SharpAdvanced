using System;
using System.Linq;

namespace _03.Problem_3._2x2_Squares_in_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			var rowsAndColumns = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			String[,] matrix = new String[rowsAndColumns[0], rowsAndColumns[1]];
			int sumofsqueare = 0;
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				var rowValues = Console.ReadLine().Split(" ").ToArray();
				for (int cols = 0; cols < matrix.GetLength(1); cols++)
				{
					matrix[row, cols] = rowValues[cols];
				}
			}

			for (int row = 0; row < matrix.GetLength(0) - 1; row++)
			{
				for (int col = 0; col < matrix.GetLength(1) - 1; col++)
				{
					if (matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row, col + 1]
						&& matrix[row, col] == matrix[row + 1, col + 1])

					{
						sumofsqueare++;
					}
				}
			}

			Console.WriteLine(sumofsqueare);
		}
	}
}
