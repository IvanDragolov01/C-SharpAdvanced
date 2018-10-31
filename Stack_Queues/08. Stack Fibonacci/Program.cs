using System;
using System.Collections.Generic;

namespace _08._Stack_Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = int.Parse(Console.ReadLine());
			Stack<long> stack = new Stack<long>(input);
			stack.Push(1);
			stack.Push(1);

			for (int i = 0; i < input - 1; i++)
			{
				long first = stack.Pop();
				long second = stack.Pop();

				stack.Push(first);
				stack.Push(first + second);
			}

			stack.Pop();
			Console.WriteLine(stack.Peek());
		}
	}
}
