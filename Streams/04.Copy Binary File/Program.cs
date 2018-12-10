using System.IO;

namespace _04.Copy_Binary_File
{
	class Program
	{
		static void Main(string[] args)
		{
			using (FileStream sourceFile = new FileStream(
				@"D:\CSharpAdvance\C-SharpAdvanced\Streams\04.Copy Binary File\copyMe.png", FileMode.Open))
			{
				using (FileStream destinacionFile = new FileStream(
					@"D:\CSharpAdvance\C-SharpAdvanced\Streams\04.Copy Binary File\copiedfile.png", FileMode.Create))
				{
					byte[] buffer = new byte[4096];

					while (true)
					{
						int readBytesCount = sourceFile.Read(buffer, 0, buffer.Length);

						if (readBytesCount == 0)
						{
							break;
						}

						destinacionFile.Write(buffer, 0, buffer.Length);
					}
				}
			}
		}
	}
}
