using System;
using System.Linq;

namespace _08._Radioactive_Bunnies
{
	class Program
	{
		static char[,] _board;
		static int _playerRow;
		static int _playerCol;
		static int _rows;
		static int _columns;

		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			_board = ReadAndFillMatrix(dimensions);
			char[] movements = Console.ReadLine().ToCharArray();

			foreach (char move in movements)
			{
				int[] previouslocation = MovePlayer(move);
				MultiplyBunnies();

				if (IsPlayerOnBoard())
				{
					if (_board[_playerRow, _playerCol] == 'B')
					{
						Die();
					}

					continue;
				}

				Win(previouslocation);
			}
		}

		private static void Die()
		{
			PrintBoard();
			Console.WriteLine($"dead: {_playerRow} {_playerCol}");
			Environment.Exit(0);
		}

		private static void Win(int[] previouslocation)
		{
			PrintBoard();
			int row = previouslocation[0];
			int col = previouslocation[1];

			Console.WriteLine($"won: {row} {col}");
			Environment.Exit(0);
		}

		private static bool IsPlayerOnBoard()
		{
			bool validRow = _playerRow >= 0 && _playerRow < _rows;
			bool validCol = _playerCol >= 0 && _playerCol < _columns;

			if (validRow && validCol)
			{
				return true;
			}

			return false;
		}

		private static void PrintBoard()
		{
			for (int row = 0; row < _rows; row++)
			{
				for (int col = 0; col < _columns; col++)
				{
					Console.Write(_board[row, col]);
				}

				Console.WriteLine();
			}
		}

		private static void MultiplyBunnies()
		{
			for (int row = 0; row < _rows; row++)
			{
				for (int col = 0; col < _columns; col++)
				{
					if (_board[row, col] == 'B')
					{
						if (row > 0)
						{
							NewBunny(row - 1, col);
						}

						if (row < _rows - 1)
						{
							NewBunny(row + 1, col);
						}

						if (col > 0)
						{
							NewBunny(row, col - 1);
						}

						if (col < _columns - 1)
						{
							NewBunny(row, col + 1);
						}
					}
				}
			}

			for (int row = 0; row < _rows; row++)
			{
				for (int col = 0; col < _columns; col++)
				{
					if (_board[row, col] == 'X')
					{
						_board[row, col] = 'B';
					}
				}
			}
		}

		private static void NewBunny(int row, int col)
		{
			if (_board[row, col] != 'B')
			{
				_board[row, col] = 'X';
			}
		}

		private static int[] MovePlayer(char move)
		{
			int[] previousLocation = { _playerRow, _playerCol };

			switch (move)
			{
				case 'U':
					_playerRow--;
					break;
				case 'D':
					_playerRow++;
					break;
				case 'L':
					_playerCol--;
					break;
				case 'R':
					_playerCol++;
					break;
			}

			if (IsPlayerOnBoard() && _board[_playerRow, _playerCol] != 'B')
			{
				_board[_playerRow, _playerCol] = 'P';
			}

			int oldRow = previousLocation[0];
			int oldCol = previousLocation[1];
			_board[oldRow, oldCol] = '.';

			return previousLocation;
		}

		private static char[,] ReadAndFillMatrix(int[] dimensions)
		{
			_rows = dimensions[0];
			_columns = dimensions[1];

			char[,] matrix = new char[_rows, _columns];

			for (int row = 0; row < _rows; row++)
			{
				char[] rowInput = Console.ReadLine().ToCharArray();

				for (int col = 0; col < _columns; col++)
				{
					matrix[row, col] = rowInput[col];

					if (rowInput[col] == 'P')
					{
						_playerRow = row;
						_playerCol = col;
					}
				}
			}

			return matrix;
		}
	}
}
