using System;
using System.IO;

namespace Exercise1
{
	internal static class CopyFile
	{
		/// <summary>
		///   EXERCISE 1.3:
		///   <para />
		///   Read the source file and put its content into destination file
		/// </summary>
		/// <param name="source">the path to the source file</param>
		/// <param name="destination">the path to the destination file</param>
		public static void CopyAllFile(string source, string destination)
		{
			if (!File.Exists(source))
			{
				string str = Path.GetFileName(source);
				System.Console.WriteLine("could not open file: <" + str + ">");
			}
			else
			{
				string file = File.ReadAllText(source);
				File.WriteAllText(destination, file);
			}
		}
		
		public static void CopyHalfFile(string source, string destination)
		{
			if (!File.Exists(source))
			{
				string str = Path.GetFileName(source);
				System.Console.WriteLine("could not open file: <" + str + ">");
			}
			else
			{
				string[] file = File.ReadAllLines(source);
				int half;
				int len = file.Length;
				
				File.WriteAllText(destination, "");

				if (file.Length % 2 == 0)
					half = len / 2;
				else
					half = (len - 1) / 2;

				for (int i = 0; i < half; i += 1)
				{
					File.AppendAllText(destination, file[i] + "\n");
				}
			}
		}	
	}
}