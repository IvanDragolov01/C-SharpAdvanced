using System;
using System.IO;

namespace _02.Line_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader readStream = new StreamReader
				(@"D:\CSharpAdvance\C-SharpAdvanced\Streams\02.Line Numbers\text.txt"))
			{
				using (StreamWriter writeStream = new StreamWriter
					(@"D:\CSharpAdvance\C-SharpAdvanced\Streams\02.Line Numbers\newfile.txt"))
				{
					int lineNumber = 1;
					string line;

					while ((line = readStream.ReadLine()) != null)
					{
						writeStream.WriteLine($"Line {lineNumber}: " + line);
						lineNumber++;
					}
				}
			}
		}
	}
}

