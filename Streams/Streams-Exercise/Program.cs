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
                var lineNumber = 1;
                 
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    if (lineNumber % 2  == 0)
                    {
                        
                        Console.WriteLine(line);
                        
                    }
                    lineNumber++;
                }
            }
        }
    }
}
/*
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
                var lineNumber = 0;

                string line;
                while ((line = stream.ReadLine()) != null)
                {

                    if (lineNumber % 3 != 0)
                    {

                        Console.WriteLine(line);
                        break;

                    }
                    lineNumber++;

                }
            }
        }
    }
}
*/
/*
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
                var lineNumber = 0;

                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {

                        Console.WriteLine(line);

                    }

                }
            }
        }
    }
}
*/