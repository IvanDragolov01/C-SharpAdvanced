using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            var oldVersions = new Stack<string>();

            var text = new StringBuilder();

            for (int i = 0; i < commandsCount; i++)
            {
                String[] commandInput = Console.ReadLine().Split();

                int command = int.Parse(commandInput[0]);


                switch (command)
                {
                    case 1:
                        oldVersions.Push(text.ToString());
                        string newStr = commandInput[1];
                        text.Append(newStr);
                        break;
                    case 2:
                        oldVersions.Push(text.ToString());
                        int length = int.Parse(commandInput[1]);
                        text.Remove(text.Length - length, length);
                        break;
                    case 3:
                        int index = int.Parse(commandInput[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(oldVersions.Pop());
                        break;

                }
            }
        }
    }
}
