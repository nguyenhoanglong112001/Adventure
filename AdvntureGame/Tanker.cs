using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    internal class Tanker : Hero
    {
        public Tanker(string name, HeroType type) : base(name, type)
        {
            atk = GameHelper.RandomValue(20, 50);
            ap = 0;
            hp = GameHelper.RandomValue(1000, 1500);
            amor = GameHelper.RandomValue(30, 50);
            atkspeed = GameHelper.RandomValue(10, 30);
            crit = GameHelper.RandomValue(5, 20);
            evasion = GameHelper.RandomValue(0, 15);
            accurancy = GameHelper.RandomValue(0, 30);
        }

        public override void Skill()
        {
            
        }

        public override void UseSkill()
        {
            
        }

        public override void Attack()
        {
           
        }
    }
}
