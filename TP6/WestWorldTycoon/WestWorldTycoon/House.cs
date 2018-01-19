using System;

namespace WestWorldTycoon
{
    public class House : Building
    {
        public const long BUILD_COST = 250;
        public static readonly long[] UPGRADE_COST ={ 750, 3000, 10000 };
        public static readonly long[] HOUSING ={ 300, 500, 650, 750 };
        
        private int lvl;
        
        public House()
        {
            type = BuildingType.HOUSE;
            lvl = 0;
        }


        public House(House house)
        {
            // BONUS
            throw new NotImplementedException();
        }

        
        public long Housing()
        {
            return HOUSING[lvl];
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