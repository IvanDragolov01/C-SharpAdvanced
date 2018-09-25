using System;
using System.Linq;

namespace _01.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int[] rowsAndColumns = Console.ReadLine().Split(", ",
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
            if (rowsAndColumns.Length <=27)
            {
                for (int rows = 0; rows < rowsAndColumns.Length; rows++)
                {
                    for (int col = 0; col < rowsAndColumns.Length; col++)
                    {
                        
                    }
                }
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        
                    }
                }
                int r = matrix.GetLength(0);
                int c = matrix.GetLength(1);
                Console.WriteLine(alphabet[r]+alphabet[c]);
            }
        }
    }
}
