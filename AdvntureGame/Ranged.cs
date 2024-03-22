using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    internal class Ranged : Hero
    {
        public Ranged(string name, HeroType type) : base(name, type)
        {
            atk = GameHelper.RandomValue(40, 70);
            ap = GameHelper.RandomValue(70, 150);
            hp = GameHelper.RandomValue(400, 600);
            atkspeed = GameHelper.RandomValue(50,90);
            amor = GameHelper.RandomValue(5, 20);
            crit = GameHelper.RandomValue(30, 60);
            evasion = GameHelper.RandomValue(0, 15);
            accurancy = GameHelper.RandomValue(0, 30);
        }
    }
}
