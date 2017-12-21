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
				System.Console.WriteLine("could bot open file: <" + str + ">");
			}
			else
			{
				File.WriteAllText(destination, source);
			}
		}
		
		public static void CopyHalfFile(string source, string destination)
		{
			
		}	
	}
}