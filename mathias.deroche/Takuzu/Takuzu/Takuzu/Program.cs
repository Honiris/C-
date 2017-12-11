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
            Takuzu.PutCell(grid, 3, 6, 1);
            Takuzu.PrintGrid(grid);
        }
    }
}
