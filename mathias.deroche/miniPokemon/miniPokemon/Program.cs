using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("salope");
            cat.Describe();
        }
    }
}
