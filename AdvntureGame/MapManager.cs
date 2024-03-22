using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class MapManager
    {
        public Dictionary<int, Map> maps =null;

        public MapManager() 
        {
            maps = new Dictionary<int, Map>();
        }

        public void MapCreate()
        {
            for (int i = 0; i < 20; i++)
            {
                Map map = new Map(i + 1);
                CreateMonmap(map);
                maps.Add(i + 1, map);
                Thread.Sleep(100);
            }
        }

        public void CreateMonmap(Map map)
        {
            if (map.HasBoss)
            {
                Boss boss = new Boss();
                map.monsters.Add(boss);
            }
            else if (!map.HasBoss)
            {
                for (int i = 0; i < map.numberofMonster; i++)
                {
                    Monster monster = new Monster();
                    map.monsters.Add(monster);
                    Thread.Sleep(100);
                }
            }
        }
    }
}
