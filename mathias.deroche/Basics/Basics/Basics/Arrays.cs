using System;
using System.CodeDom;

namespace Basics
{
    public class Arrays
    {
        public static int Search(int[] arr, int e)
        {
            int i = 0;
            bool test = true;
            
            while (i < arr.Length && test)
            {
                if (arr[i] == e)
                    test = false;
                i++;
            }
            return (test) ? -1 : i-1;
        }

        public static int KingOfTheHill(int[] arr)
        {
            int i = 0;
            int tmp = 0;
            bool test = true;
            
            while (i < arr.Length - 1 && test)
            {
                if (arr[i] > arr[i + 1])
                {
                    test = false;
                    tmp = arr[i];
                }
                i++;
            }
            return tmp;
        }

        public static int[] CloneArray(int[] arr)
        {
            int[] clone = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                clone[i] = arr[i];
            return arr;
        }

        public static void BubbleSort(int[] arr)
        {
            int tmp = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }       
                }   
            }
        }

        public static bool is_sorted(int[] arr)
        {
            bool test = true;
            int i = 0;

            while (i < arr.Length - 1 && test)
            {
                if (arr[i] > arr[i + 1])
                    test = false;
            }

            return test;
        }

        public static void bogoSort(int[] arr)
        {
            while (!is_sorted(arr))
            {
                
            }
        }
    }
}