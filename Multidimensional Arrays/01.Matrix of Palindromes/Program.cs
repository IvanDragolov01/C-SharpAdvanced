using System;
using System.Linq;

namespace _01.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] matrix = new char[rowsAndColumns[0], rowsAndColumns[1]];
            char a = 'a';
            char b = 'a';
            for (int rows = 0; rows < rowsAndColumns[0]; rows++)
             {
                    for (int cols = 0; cols < rowsAndColumns[1]; cols++)
                    {
                        Console.Write(a);
                        Console.Write(b);
                        Console.Write(a);
                        Console.Write(" ");
                        b++;
                    }
             
                Console.WriteLine();
                a++;
                b = a;
            }
        }
    }
}


