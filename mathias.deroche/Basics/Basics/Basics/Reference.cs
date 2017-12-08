using System.Runtime.InteropServices;

namespace Basics
{
    public class Reference
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public static int Trunc(ref float f)
        {
            float c = f;
            f %= 1;
            return (int) (c - f);
        }
        
        //Instring renvoie la position de la premiere
        //occurrence d'un char c dans une string

        public static int instring(string s, char c)
        {
            int i = 0;
            bool test = true;
            
            while (i < s.Length && test)
            {
                if (s[i] == c)
                    test = false;
                i++;
            }
            return (test) ? -1 : i-1;
        }

        public static void RotChar(ref char c, int n)
        {
            string min = "abcdefghijklmnopqrstuvwxyz";
            string maj = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string nbr = "0123456789";
            int d = instring(min, c);
            int e = instring(maj, c);
            int f = instring(nbr, c);

            if (d != -1)
                c = min[((d + n) % 26 + 26) % 26];
            else if (e != -1)
                c = maj[((e + n) % 26 + 26) % 26];
            else
                c = nbr[((f + n) % 10 + 10) % 10];
        }
    }
}