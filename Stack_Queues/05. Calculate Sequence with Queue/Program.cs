using System;
using System.Collections.Generic;

namespace _05._Calculate_Sequence_with_Queue
{
	class Program
	{
		public const int number = 50;
		static void Main(string[] args)
		{
			
			long startNum = long.Parse(Console.ReadLine());
			Queue<long> queue = new Queue<long>();
			queue.Enqueue(startNum);

			for (int i = 0; i < number; i++)
			{
				long n = queue.Dequeue();
				Console.Write(n + " ");
				queue.Enqueue(n + 1);
				queue.Enqueue(2 * n + 1);
				queue.Enqueue(n + 2);
			}
		}
	}
}
