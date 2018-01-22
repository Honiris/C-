using System;
using System.Reflection;
using System.Xml.Schema;

namespace WestWorldTycoon
{
    public class Game
    {
        private long score;
        private long money;
        private int nbRound;
        private int round;
        private Map map;
        
        public Game(string name, int nbRound, long initialMoney)
        {
            TycoonIO.GameInit(name, nbRound, initialMoney);
            round = 1;
            this.nbRound = NbRound;
            money = initialMoney;
            map = new Map(name);
            score = 0;
        }


        public long Launch(Bot bot)
        {
            throw new NotImplementedException();
        }
        
        
        public void Update()
        {
            throw new NotImplementedException();
            TycoonIO.GameUpdate();
        }


        public bool Build(int i, int j, Building.BuildingType type)
        {
            return map.Build(i, j, ref money, type);
        }


        public bool Destroy(int i, int j)
        {
            throw new NotImplementedException();
        }
        
        public bool Upgrade(int i, int j)
        {
            throw new NotImplementedException();
        }
        
        
        public long Score
        {
            get { return score; }
        }
        
        
        public long Money
        {
            get { return money; }
        }
        
        
        public int NbRound
        {
            get { return nbRound; }
        }


        public int Round
        {
            get { return round; }
        }

        public Map Map
        {
            get { return map; }
        }
    }
}