using System;
using System.Collections.Generic;
using System.Reflection;

namespace miniPokemon
{
    public class Pokemon : Animal
    {
        private Poketype poketype;
        private int damage;
        private int level;
        private bool isKO;
        private int life;
        
        public int Life
        {
            get { return life; }
            set { life = value; }
        }
        
        public bool IskO
        {
            get { return isKO; }
            set { isKO = value; }
        }
        
        public enum Poketype
        {
            POISON,
            FIRE,
            WATER,
            GRASS,
            ELECTRICK
        };

        #region Constructor

        
        public Pokemon(string name, int life, int damage, Poketype poketype)
        : base(name)
        {
            this.life = life;
            this.damage = damage;
            this.poketype = poketype;
        }

        #endregion Constructor
        

        #region Methods

        
        public override void WhoAmI()
        {
            Console.WriteLine("I am a pokemon");
        }

        public override void Describe()
        {
            Console.WriteLine("My name is " + Name + " I'm a pokemon of type " + poketype + " and I'm level " + level);
        }
        
        public void LevelUp()
        {
            level++;
        }

        public int Attack()
        {
            return damage;
        }

        public void GetHurt(int damage)
        {
            life -= damage;
        }

        public void Heal(int life)
        {
            this.life += life;
        }

        #endregion Methods
        
    }
}
