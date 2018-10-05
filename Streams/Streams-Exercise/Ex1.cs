using System;
using System.IO;

namespace Streams_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader(@"D:\CSharpAdvance\C-SharpAdvanced\Streams\Streams-Exercise\text.txt"))
            {
                var lineNumber = 2;
                 
                string line;
                while ((line = stream.ReadLine()) != null)
                {  

                    if(line.Length % 2  != 0)
                    {

                        Console.WriteLine($"Line {lineNumber}: " + line);
                        break;
                    }
                    
                }
            }
        }
    }
}
