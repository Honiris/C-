using System;
using System.ComponentModel;
using System.Threading;

namespace TP1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            sl();
            Console.ReadKey();
        }

        public static void HelloWorlds(int n)
        {
            for (var i = 0; i <= n; i++)
            {
                Console.WriteLine("Hello (West)World!");
                i = i + 1;
            }
        }

        public static void Echo()
        {
            Console.WriteLine("\n" + Console.ReadLine());
        }

        public static string ReverseAux(string a)
        {
            return (a == "") ? "" : ReverseAux(a.Substring(1)) + a[0];
        }

        public static void Reverse()
        {
            Console.WriteLine(ReverseAux(Console.ReadLine()));
        }

        public static void LoveAcdc()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            var heart = new string[]
            {
                "  * * *   * * *",
                "* *   * * *   * *",
                "*       *       *",
                "* *  <3 ACDC  * *",
                "  * *       * *",
                "    * *   * *",
                "      * * *",
                "        *"
            };

            for (var i = 0; i < heart.Length; i++)
            {
                Console.WriteLine(heart[i]);
            }

            Console.ResetColor();
        }

        public static void MCQ(string question, string aws1, string aws2,
                               string aws3, string aws4, int aws)
        {
            Console.WriteLine(question);
            Console.WriteLine("1)" + aws1);
            Console.WriteLine("2)" + aws2);
            Console.WriteLine("3)" + aws3);
            Console.WriteLine("4)" + aws4);

            var rep = Int32.Parse(Console.ReadLine());

            if (rep == aws)
            {
                Console.WriteLine("Good job bro!");
            }
            else if (rep < 1 || rep > 4)
            {
                Console.WriteLine("So counting is too hard, n00b...");
            }
            else
            {
                Console.WriteLine("You lose... The answer was " + aws);
            }
        }

        public static void BestYears()
        {
            var year = Int32.Parse(Console.ReadLine());

            if (year <= 2022 && year >= 1989)
            {
                if (year == 2022)
                {
                    Console.WriteLine("Bad Year");
                }
                else if (year == 2020)
                {
                    Console.WriteLine("Best Year");
                }
                else if (year % 2 == 0)
                {
                    Console.WriteLine("Good Year");
                }
                else
                {
                    Console.WriteLine("Bad Year");
                }
            }
            else
            {
                Console.WriteLine("?");
            }
        }

        public static void Morse(string s, int i = 0)
        {
            while (i < s.Length)
            {
                if (s[i] == '_')
                {
                    Console.Beep(900, 450);
                }
                else if (s[i] == '.')
                {
                    Console.Beep(900, 150);
                }
                else
                {
                    Thread.Sleep(450);
                }
            }
        }

        public static void Lighthouse(int n)
        {
            var socle = " ===== \n_||_||_\n-------";
            var toit = "  /^\\  \n  |#|  -";
            var etage = " |===| \n  |0|  \n  | |  ";
            
            Console.WriteLine(toit);

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(etage);
            }
            Console.WriteLine(socle);
        }

        public static void LightHouseBonus(int n)
        {
            var socle = " ===== \n_||_||_\n-------";
            var toit = "  /^\\  \n  |#|  -";
            var etage = " |===| \n  |0|  \n  | |  ";
            var light = "  --";
            
            Console.WriteLine(toit);

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(etage + light);
                light = "  " + light + "-";
            }
            Console.WriteLine(socle + light);
        }

        public static void sl()
        {
            Console.Clear();
            var plane = "           _| Drinking nespresso to cure my depresso |_";
            var plane_res = "           _| Drinking nespresso to cure my depresso |_";
            var dd = 1;

            while (true)
            {
                Console.Clear();  
                Console.WriteLine(plane);
                plane = " " + plane;
                if (plane.Length > 500)
                {
                    plane = plane_res;
                }
                Thread.Sleep(50);
            }
        }
    }
}