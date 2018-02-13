using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace Brainfuck
{
    class Brainfuck
    {
        /**
         * Interpret @code with @symbols and return the resulting string.
         * In case of error,  an ArgumentException is raised.
         * Possible error cases are:
         *     - Invalid braces number / order
         *     - Symbol not present in @symbols
         */
        public static string Interpret(string code, Dictionary<char, char> symbols)
        {
            string print = "";
            int i = 0;
            int pointer = 0;
            int tmp = 0;
            int pas = 0;

            int[] arr = new int[30000];

            for (int j = 0; j < 30000; j++)
                arr[j] = 0;
            
            while (i < code.Length)
            {
                char x = code[i];

                if (x == symbols['>'])
                {
                    pointer = (pointer + 1) % 30000;
                }
                else if (x == symbols['<'])
                {
                    pointer = ((pointer - 1) % 30000 + 30000) % 30000;
                }
                else if (x == symbols['+'])
                {
                    arr[pointer] = (arr[pointer] + 1) % 256;
                }
                else if (x == symbols['-'])
                {
                    arr[pointer] = ((arr[pointer] - 1) % 256 + 256) % 256;
                }
                else if (x == symbols[','])
                {
                    Console.Write("Input a char: ");
                    char input = Console.ReadLine()[0];
                    arr[pointer] = (int) input;
                }
                else if (x == symbols['.'])
                {
                    print += (char) arr[pointer];
                }
                else if (x == symbols['['])
                {
                    if (arr[pointer] == 0)
                    {
                        tmp = i + 1;
                        pas = 0;
                        
                        while (code[tmp] != symbols[']'] || pas > 0)
                        {
                            if (code[tmp] == symbols['['])
                            {
                                pas--;
                            }
                            else if (code[tmp] == symbols[']'])
                            {
                                pas--;
                            }
                            
                            tmp++;
                            i = tmp;
                        }
                    }
                }
                else if (x == symbols[']'])
                { 
                    if (arr[pointer] != 0)
                    {
                        tmp = i - 1;
                        pas = 0;
                        
                        while (code[tmp] != symbols['['] || pas > 0)
                        {
                            if (code[tmp] == symbols[']'])
                            {
                                pas++;
                            }
                            else if (code[tmp] == symbols['['])
                            {
                                pas--;
                            }
                            
                            tmp--;
                            i = tmp;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Not a BrainFuck symbol");
                }
                
                i++;
            }

            return print;
        }
        
        /**
         * Generate the brainfuck code to print @text with @symbols.and return it.
         * In case of error, an ArgumentException is raised.
         * Possible error case is:
         *     - Missing symbol in @symbols
         */
        public static string GenerateCodeFromText(string text, Dictionary<char, char> symbols)
        {
            string print = "";

            foreach (char x in text)
            {
                for (int i = 0; i < (int) x; i++)
                    print += symbols['+'];

                print += ".>";
            }
            
            return print;
        }
        
         /**
         * Shorten @program with @symbols and return the resulting string.
         * In case of error, an ArgumentException is raised.
         * Possible error cases are:
         *     - Symbol not present in @symbols
         *     - Invalid symbol
         */
        public static string ShortenCode(string program, Dictionary<char, char> symbols)
        {
            string text = Interpret(program, symbols);
            
            string print = "";

            foreach (char x in text)
            {
                int nbr = (int) x;
                int q = (nbr - nbr % 10) / 10;
                int r = nbr % 10;

                if (nbr < 10)
                {
                    for (int i = 0; i < nbr; i++)
                        print += symbols['+'];
                }
                else
                {
                    for (int j = 0; j < q; j++)
                        print += symbols['+'];
                    
                    print += "[>++++++++++<-]>";
                    
                    for (int k = 0; k < r; k++)
                        print += symbols['+'];
                }

                print += ".>";
            }
            
            return print;
        }
    }
}
