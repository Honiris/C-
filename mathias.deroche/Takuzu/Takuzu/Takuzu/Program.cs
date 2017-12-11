using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Takuzu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] grid =
                {
                {0, -1, -1, -1, -1, -1, -1, 1},
                {-1, 0, -1, -1, -1, -1, 1, -1},
                {-1, -1, 0, -1, -1, 1, -1, -1},
                {-1, -1, -1, 0, 1, -1, -1, -1},
                {-1, -1, -1, 1, 0, -1, -1, -1},
                {-1, -1, 1, -1, -1, 0, -1, -1},
                {-1, 1, -1, -1, -1, -1, 0, -1},
                { 1, -1, -1, -1, -1, -1, -1, 0}
                };
            Takuzu.PutCell(grid, 0, 0, 1);
            Console.WriteLine(Takuzu.PrintGrid(grid));
        }
    }
}
