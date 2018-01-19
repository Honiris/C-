﻿using System;

namespace WestWorldTycoon
{
    public class Shop : Building
    {
        public const long BUILD_COST = 300;
        public static readonly long[] UPGRADE_COST = { 2500, 10000, 50000 };
        public static readonly long[] INCOME = { 7, 8, 9, 10 };

        private int lvl;
        
        public Shop()
        {
            lvl = 0;
            type = BuildingType.SHOP;
        }


        public Shop(Shop shop)
        {
            // BONUS
            throw new NotImplementedException();
        }
        
        
        public long Income(long population)
        {
            return INCOME[lvl] / 100 * population;
        }
        
        
        public bool Upgrade(ref long money)
        {
            if (lvl > 2 || money < UPGRADE_COST[lvl])
                return false;
            money -= UPGRADE_COST[lvl];
            lvl++;
            return true;
        }
        
        
        public int Lvl
        {
            get { return lvl; }
        }
    }
}