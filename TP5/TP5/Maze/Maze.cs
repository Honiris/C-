using System.IO;

namespace Maze
{
	internal static class Maze
	{
		/// <summary>
		/// MAZE:
		/// <para/>
		/// This is where you should call your functions to make your program work.
		/// </summary>
		/// <param name="args">unused</param>
		public static void Main(string[] args)
		{
			System.Console.WriteLine(AskMazeFile());
		}

		private static string AskMazeFile()
		{
			bool test = true;
			System.Console.WriteLine("Which file should be loaded ?");
			string path;
			
			do
			{
				path = "";
				while (path == "")
					path = System.Console.ReadLine();
				
				if (!File.Exists(path))
				{
					if (Path.GetExtension(path) == ".maze")
						System.Console.WriteLine(path + "  #  It is a .maze but the file does not exists.");
					else
						System.Console.WriteLine(path + "  #  It is not a .maze and it does not even exists.");
				}
				else
				{
					if (Path.GetExtension(path) == ".maze")
						System.Console.WriteLine(path + "  #  File exists and it is a .maze.");
					else
						System.Console.WriteLine(path + "  #  File exists but it is not a .maze");
				}

				if ((Path.GetExtension(path) == "maze") && File.Exists(path))
					test = false;
			} while (test);
			
		    System.Console.WriteLine("Thank you, bye");
			
			return path;
		}
	}

	/// <summary>
	///   Class that allows to store 2D coordinates.
	/// </summary>
	internal class Point
	{
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int Y { get; set; }
		public int X { get; set; }
	}
}