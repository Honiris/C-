using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using Debugger;

namespace Debugger
{
    public static class Loop
    {
        public static void Print_Naturals(int n)
        {
            for (var i = 1; i < n; i++)
                Console.Write(i + " ");
            
            Console.Write(n);
        }

        public static bool is_prime(int n)
        {
            var b = n - 1;
            
            while (!Misc.isDivisor(n, b))
                b--;
            
            return (b == 1);
        }

        public static void Print_Primes(int n)
        {
            for (var i = 2; i < n; i++)
            {
                if (is_prime(i))
                    Console.Write(i + " ");     
            }
            if (is_prime(n))
                Console.Write(n);
        }

        public static long Fibonacci(long n)
        {
            long a = 0;
            long b = 1;
            long c = 0;

            if (n == 1)
            {
                c = 1;
            }
            else
            {
                for (long i = 1; i < n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            
            return c;
        }

        public static long Factorial(long n)
        {
            long ret = 1;

            if (n == 0)
            {
                ret = 1;
            }
            else
            {
                for (var i = 2; i <= n; i++)
                    ret *= i;
            }
            
            return ret;
        }

        public static bool is_strong(int n)
        {
            var c = (long)n;
            long sum = 0;

            while (c != 0)
            {
                sum += Factorial(c % 10);
                c = (c - c % 10) / 10;
            }

            return (sum == (long) n);
        }

        public static void Print_Strong(int n)
        {
            for (var i = 1; i < n; i++)
            {
                if (is_strong(i))
                    Console.Write(i + " ");     
            }
            
            if (is_strong(n))
                Console.Write(n);
        }

        public static float Abs(float n)
        {
            return (n < 0) ? -n : n;
        }

        public static float Sqrt(float n)
        {
            var Xn = (float)0.5;
            n = Abs(n);
            
            for (var i = 1; i <= 7; i++)
                Xn = (Xn + (n / Xn)) / 2;
            
            return Xn;
        }

        public static long Power(long a, long b)
        {
            long tmp = 1;
            
            for (var i = 1; i <= b; i++)
                tmp *= a;
            
            return tmp;
        }

        public static void Print_Tree(int n)
        {
            var pine = "";

            for (var i = 1; i <= (1 + 2 * (n - 1)); i++)
                pine += "";
            
            
        }
    }
}