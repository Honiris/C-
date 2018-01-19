using System;

namespace WestWorldTycoon
{
    public class Attraction :Building
    {
        public const long BUILD_COST = 10000;
        public static readonly long[] UPGRADE_COST = { 5000, 10000, 45000 };
        public static readonly long[] ATTRACTIVENESS = { 500, 1000, 1300, 1500 };

        private int lvl;

        public Attraction()
        {
            type = BuildingType.ATTRACTION;
            lvl = 0;
        }


        public Attraction(Attraction attraction)
        {
            // BONUS
            throw new NotImplementedException();
        }

        
        public long Attractiveness()
        {
            return ATTRACTIVENESS[lvl];
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
