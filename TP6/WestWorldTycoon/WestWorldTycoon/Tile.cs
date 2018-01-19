using System;
using System.Xml.Schema;

namespace WestWorldTycoon
{
    public class Tile
    {
        private Biome biome;
        private Building building;
        
        public enum Biome
        {
            SEA, MOUNTAIN, PLAIN
        }
        
        
        public Tile(Biome b)
        {
            biome = b;
            building = null;
        }

        
        public Tile(Tile tile)
        {
            // BONUS
            throw new NotImplementedException();
        }

        
        public bool Build(ref long money, Building.BuildingType type)
        {
            int[] costs =
            {
                10000, 250, 300
            };
            int cost = costs[(int) type - 1];
            throw new NotImplementedException();
        }


        public bool Upgrade(ref long money)
        {
            throw new NotImplementedException();
        }
        
        
        public long GetHousing()
        {
            throw new NotImplementedException();
        }
        
        
        public long GetAttractiveness()
        {
            throw new NotImplementedException();
        }
        
        
        public long GetIncome(long population)
        {
            throw new NotImplementedException();
        }


        public bool Destroy()
        {
            // BONUS
            throw new NotImplementedException();
        }
        

        public Biome GetBiome
        {
            get { return biome; }
        }
    }
}