﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;

namespace miniPokemon
{
    public class Animal
    {
        private string name;

        public string Name
        {
            get {return name;}
        }

        #region Constructor

        public Animal(string name)
        {
            this.name = name;
        }

        #endregion Constructor
        
        #region Methods

        public virtual void WhoAmI()
        {
            Console.WriteLine("I am an animal !");
        }

        public virtual void Describe()
        {
            Console.WriteLine("My name is " + name);
        }

        public void Rename(string NewName)
        {
            name = NewName;
        }

        #endregion Methods
        
    }
}
