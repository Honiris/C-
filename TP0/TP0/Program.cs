using System;
using System.Collections.Generic;
using System.Net.Security;

namespace TP0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ChangeChar("hello", 'a', 3));
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
            return ((x < 0) ? -x : x);
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
            return (n < 2) ? n : MyFibo(n-2) + MyFibo(n-1);
        }

        public static string ChangeChar(string s, char c, uint n)
        {
            string t;
            string ch = c.ToString();
            
            if (n == 0)
            {
                t = ch + s.Substring(1);
            }
            else if (n == 1)
            {
                t = s[0].ToString() + ch + s.Substring(2);
            }
            else if (n == s.Length - 1)
            {
                t = s.Substring(0, (int) n - 2) + ch;
            }
            else
            {
                t=s.Substring(0,((int)n-1))+ch+s.Substring((int)n+1);
            }
            return t;
        }
    }
}