using System;
using System.Data.Common;

namespace Takuzu 
{
    public static class Takuzu
    {
        public static void PrintGrid(int[,] grid)
        {
            string top = "   ";
            string tmp = "";
            
            for (int i = 0; i < grid.GetLength(1); i++)
                top += i + " ";
            
            Console.WriteLine(top);
            
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                tmp = i + " |";
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        tmp += "1|";
                    }
                    else if (grid[i, j] == 0)
                    {
                        tmp += "0|";
                    }
                    else
                    {
                        tmp += " |";
                    }
                }
                Console.WriteLine(tmp);
            }
        }

        public static bool IsRowValid(int[,] grid, int row)
        {
            int nbr_of_1 = 0;
            int nbr_of_0 = 0;

            for (int i = 0; i < grid.GetLength(1); i++)
            {
                if (grid[row, i] == 1)
                    nbr_of_1++;
                
                if (grid[row, i] == 0)
                    nbr_of_0++;
            }
            
            return nbr_of_0 == nbr_of_1;
        }
        
        public static bool IsColumnValid(int[,] grid, int col)
        {
            int nbr_of_1 = 0;
            int nbr_of_0 = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                if (grid[i, col] == 1)
                    nbr_of_1++;
                
                if (grid[i, col] == 0)
                    nbr_of_0++;
            }
            
            return nbr_of_0 == nbr_of_1;
        }

        public static bool IsGridValid(int[,] grid)
        {
            bool test1 = true;
            bool test2 = true;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                if (!IsColumnValid(grid, i))
                    test1 = false;
            }
            
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if (!IsRowValid(grid, j))
                    test2 = false;
            }
            
            return test1 && test2;
        }

        public static bool PutCell(int[,] grid, int x, int y, int val)
        {
            bool test = true;

            if (!(val >= -1 && val <= 1) || x < 0 || y < 0 || y >= grid.GetLength(0) || x >= grid.GetLength(1))
            {
                test = false;
            }
            else
            {
                grid[y, x] = val;
            }
                
            return test;
        }
        
        public static void Game(int[,] start)
        {
            //FIXME
        }

        public static int[,] AI(int[,] grid)
        {
            //FIXME
            return null;
        }
    }
}