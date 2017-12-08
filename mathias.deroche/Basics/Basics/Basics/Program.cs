using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Basics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] hill =
            {
              1, 3, 4, 6, 8, 9, 7, 5, 3, 0
            };
            Arrays.BubbleSort(hill);
            foreach (int x in hill)
                Console.WriteLine(x);
        }
    }
}