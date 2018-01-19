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
            long price;
            
            switch (type)
            {
                case Building.BuildingType.ATTRACTION :
                    price = 10000; 
                    break;
                case Building.BuildingType.SHOP :
                    price = 300;
                    break;
                case Building.BuildingType.HOUSE :
                    price = 250;
                    break;
                default :
                    Console.WriteLine("AH");
                    return false;
            }
            
            if (money < price || biome != Biome.PLAIN)
                return false;
            
            money -= price;
            
            switch (type)
            {
                   case Building.BuildingType.ATTRACTION :
                       building = new Attraction();
                       break;
                   case Building.BuildingType.SHOP :
                       building = new Shop();
                       break;
                   default :
                       building = new House();
                       break;
            }
            
            return true;
        }


        public bool Upgrade(ref long money)
        {
            return (building as building.Type).Upgrade
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