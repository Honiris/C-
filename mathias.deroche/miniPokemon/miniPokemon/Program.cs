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
            int pdv = salameche.Life;
            int attack = salameche.Attack();
            salameche.GetHurt(90);
            pdv = salameche.Life;
            bool state = salameche.IsKO;
            salameche.Heal(80);
            Console.WriteLine(salameche.Life);
            
        }
    }
}
