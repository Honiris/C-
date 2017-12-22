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
			// get .maze filename
			// get .solved filename
			// parse .maze file
			// print the maze (BONUS)
			// solve the maze
			// print the maze (BONUS)
			// save solution in .solved file
		}

		private static string AskMazeFile()
		{
			bool test = true;
			System.Console.Read("Which file should be loaded ?");
			
			do
			{
				string path = System.Console.ReadLine();

				if (!File.Exists(path))
				{
					if (Path.GetExtension(path) == "maze")
						System.Console.Write("#  It is a .maze but the file does not exists.\n");
					else
						System.Console.Write("#  It is not a .maze and it does not even exists.\n");
				}
				else if (!Path.GetExtension(path) == "maze")
				{
					if (File.Exists(path))
						System.Console.Write("#  File exists but it is not a .maze.\n");
					else
						System.Console.Write("#  File does not exists and it is not a .maze\n");
				}
				else
					test = false;
			} while (test);
			
		    System.Console.WriteLine("Thank you, bye");
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