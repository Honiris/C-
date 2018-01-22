using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

namespace WestWorldTycoon
{
    public class Map
    {
        public Tile[,] matrix;
        
        public Map(string name)
        {
            matrix = TycoonIO.ParseMap(name);
        }
        
        
        public Map(Map map)
        {
            // BONUS
            throw new NotImplementedException();
        }


        public bool Build(int i, int j, ref long money, Building.BuildingType type)
        {
            return matrix[i, j].Build(ref money, type);
        }


        public bool Destroy(int i, int j)
        {
            // BONUS
            throw new NotImplementedException();
        }

        public bool Upgrade(int i, int j, ref long money)
        {
            return matrix[i, j].Upgrade(ref money);
        }
        
        
        public long GetAttractiveness()
        {
            throw new NotImplementedException();
        }

        
        public long GetHousing()
        {
            long sum;

            sum = 0;
            foreach (var x in matrix)
            {
                sum += x.GetHousing();
            }

            return sum;
        }


        public long GetPopulation()
        {
            long sum;

            sum = 0;
            foreach (var x in matrix)
            {
                sum += x.GetAttractiveness();
            }

            return sum;
        }
        
        
        public long GetIncome(long population)
        {
            long sum;

            sum = 0;
            foreach (var x in matrix)
            {
                sum += x.GetIncome(population);
            }

            return sum;
        }
       
    }
}