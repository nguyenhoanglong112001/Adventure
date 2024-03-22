using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Monster
    {
        public MonsterName name;
        public int hp;
        public int mp;
        public int atk;
        public int atkspeed;
        public int level;
        public bool Alive => hp > 0;
        public Monster()
        {
            name = (MonsterName)GameHelper.RandomValue(1, 5);
            level = GameHelper.RandomValue(Program.hero.level, Program.hero.level + 5);
            hp = GameHelper.RandomValue(50, 200) * level;
            mp = GameHelper.RandomValue(50, 150);
            atk = GameHelper.RandomValue(10, 30) * (int)(0.8f * level);
            atkspeed = GameHelper.RandomValue(5, 20) * (int)(0.4 * level);
        }
    }
}
