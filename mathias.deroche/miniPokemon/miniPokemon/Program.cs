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
            Pokemon salameche = new Pokemon("Salameche", 80, 15, Pokemon.Poketype.FIRE);
            salameche.Describe();
        }
    }
}
