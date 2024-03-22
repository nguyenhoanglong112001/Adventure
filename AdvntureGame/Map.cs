using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Map
    {
        public int floor;
        public int numberofMonster;
        public bool HasBoss => floor % 5 == 0;
        public int expreward;
        public int goldreward;
        public Item itemReward;
        public List<Monster> monsters = null;
        public Map(int level)
        {
            floor = level;
            numberofMonster = GameHelper.RandomValue(1, 6);
            monsters = new List<Monster>();
        }
    }
}
