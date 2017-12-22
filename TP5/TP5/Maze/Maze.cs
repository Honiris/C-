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
			System.Console.WriteLine("Which file should be loaded ?");
			string path = System.Console.ReadLine();

			if (!File.Exists(path))
			{
				if (Path.GetExtension(path))
					System.Console.WriteLine("C'est n'est pas .maze et ce fichier n'existe pas");
				else
					System.Console.WriteLine("C'est bien un .maze et ce fichier n'existe pas");
			}
			else if (!Path.GetExtension(path))
			{
				if (File.Exists(path))
					System.Console.WriteLine("C'est n'est pas .maze et ce fichier n'existe pas");
				else
					System.Console.WriteLine("C'est bien un .maze et ce fichier n'existe pas");
			}
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