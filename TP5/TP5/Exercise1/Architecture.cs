using System.IO;

namespace Exercise1
{
	internal static class Architecture
	{
		/// <summary>
		///   EXERCISE 1.5:
		///   <para />
		///   This function creates a folder architecture as described in the subject.
		///   When testing, take care not to put an important folder in path.
		/// </summary>
		/// <param name="path">the path to the first folder you will create</param>
		public static void Architect(string path)
		{
			string read = "Everything in programming is magic... except for the programmer\n";
			
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			else if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
			}
			
			Directory.CreateDirectory(path);
			File.WriteAllText(path + "AUTHORS", "* prenom.nom\n");
			File.WriteAllText(path + "READ", read);
			Directory.CreateDirectory(path + "TP5");
			File.WriteAllText(path + "/TP5/useless.txt", "");
		}
	}
}