using System.IO;

namespace Exercise1
{
	internal static class PrintFile
	{
		/// <summary>
		///   EXERCISE 1.1:
		///   <para />
		///   Read all the text in a file and print it in the console.
		/// </summary>
		/// <param name="path">the path (absolute or relative) to the file</param>
		public static void PrintAllFile(string path)
		{
			if (!File.Exists(path))
			{
				string str = Path.GetFileName(path);
				System.Console.WriteLine("could bot open file: <" + str + ">");
			}
			else
			{
				string[] file = File.ReadAllLines(path);

				foreach (string x in file)
				{
					System.Console.WriteLine(x);
				}
			}
		}

		/// <summary>
		///   EXERCISE 1.2:
		///   <para />
		///   Read only one line out of two and print it in the console.
		/// </summary>
		/// <param name="path"></param>
		public static void PrintHalfFile(string path)
		{
			if (!File.Exists(path))
			{
				string str = Path.GetFileName(path);
				System.Console.WriteLine("could bot open file: <" + str + ">");
			}
			else
			{
				string[] file = File.ReadAllLines(path);

				for (int i = 0; i < file.Length; i += 2)
				{
					System.Console.WriteLine(file[i]);
				}
			}
		}
	}
}