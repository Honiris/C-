using System;
using System.Net;
using Debugger;

namespace Debugger
{
    public static class Loop
    {
        public static void Print_Naturals(int n)
        {
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(n);
        }

        public static bool is_prime(int n)
        {
            int b = n - 1;
            
            while (!Misc.isDivisor(n, b))
            {
                b--;
            }
            
            return (b == 1);
        }

        public static void Print_Primes(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (is_prime(i))
                {
                    Console.WriteLine(i + " ");
                }       
            }
            if (is_prime(n))
            {
                Console.WriteLine(n);
            }
        }

        public static long Fibonacci(long n)
        {
            var a = 0;
            var b = 1;
            var c = 1;

            for (long i = 0; i < n - 1; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            
            return c;
        }

        public static long Factorial(long n)
        {
            // TODO
            return 0;
        }

        public static void Print_Strong(int n)
        {
            // TODO
        }

        public static float Abs(float n)
        {
            // TODO
            return 0;
        }

        public static float Sqrt(float n)
        {
            // TODO
            return 0;
        }

        public static long Power(long a, long b)
        {
            // TODO
            return 0;
        }

        public static void Print_Tree(int n)
        {
            // TODO
        }
    }
}