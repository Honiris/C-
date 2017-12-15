using System;
using System.Collections.Generic;
using System.Reflection;

namespace miniPokemon
{
    class Trainer : Animal
    {
        private int age;
        private List<Pokemon> listPokemon;
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        #region Constructor

        public Trainer(string name, int age)
        : base(name)
        {
            this.age = age;
            listPokemon = new List<Pokemon>();
        }

        #endregion Constructor

        #region Methods

        public override void WhoAmI()
        {
            Console.WriteLine("I'm a pokemon Trainer !");
        }

        public static int NumberOfPokemon()
        {
            return listPokemon.Count;
        }

        public override void Describe()
        {
            Console.WriteLine("My name is " + Name + ", I'm " + age + " and I have " + listPokemon.Count + "Pokemon !");
        }

        public void Birthday()
        {
            age++;
        }

        public void MyPokemon()
        {
            Console.WriteLine("My pokemon are :");
            foreach (var x in listPokemon)
                Console.WriteLine("- " + x.Name);
        }

        public void CatchAPokemon(Pokemon pokemon)
        {
            listPokemon.Add(pokemon);
        }
        
        #endregion Methods
    }
}
