using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace TP0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(2, 5));
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello Wolrd!");
        }

        public static void SayHello()
        {
            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Well hello " + name + "!");
        }

        public static void CalcAge()
        {
            Console.WriteLine("What's your year of birth?");

            string dob = Console.ReadLine();
            int dob_int = int.Parse(dob);
            int year = DateTime.Today.Year;
            int age = year - dob_int;

            Console.WriteLine("Looks like you're around " + age + "!");
        }

        public static int Absolute(int x)
        {
            return (x < 0) ? -x : x;
        }

        public static uint MyFact(uint n)
        {
            return (n == 0) ? 1 : n * MyFact(n - 1);
        }

        public static double MyPow(double x, int n)
        {
            return (n == 0) ? 1 : x * MyPow(x, n - 1);
        }

        public static uint MyFibo(uint n)
        {
            return (n < 2) ? n : MyFibo(n - 2) + MyFibo(n - 1);
        }

        public static string ChangeChar(string s, char c, uint n)
        {
            return (n == 0) ? c + s.Substring(1) : s[0] + ChangeChar(s.Substring(1), c, n - 1);
        }

        public static uint MyGcd(uint a, uint b)
        {
            return (a % b == 0) ? b : MyGcd(b, a % b);
        }

        public static double MySqrtAux(double n, uint i, double tmp = 0.5)
        {
            return (i == 0) ? tmp : MySqrtAux(n, i-1, (tmp + n / tmp) / 2);
        }

        public static double MySqrt(double n, uint i)
        {
            return MySqrtAux(n, i);
        }

        public static bool MyIsPalindrome(string a)
        {
            return (a.Length <= 1) ? true : (a[0] == a[a.Length - 1]) && MyIsPalindrome(a.Substring(1, a.Length - 2));
        }

        public static void CalcRealAge()
        {
            Console.WriteLine("What's your year of birth?");
            string Year = Console.ReadLine();
            Console.WriteLine("What's your month of birth?");
            Console.WriteLine("What's your day of birth?");
            
            Console.WriteLine("Looks like you're exactly!");
        }
    }
}
