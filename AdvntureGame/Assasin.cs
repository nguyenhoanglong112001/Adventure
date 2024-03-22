using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Assasin : Hero
    {
        public Assasin(string name, HeroType type) : base(name, type)
        {
            atk = GameHelper.RandomValue(130, 150);
            ap = GameHelper.RandomValue(0, 25);
            hp = GameHelper.RandomValue(300, 600);
            atkspeed = GameHelper.RandomValue(25, 40);
            amor = GameHelper.RandomValue(20, 40);
            crit = GameHelper.RandomValue(20, 50);
            evasion = GameHelper.RandomValue(10, 50);
            accurancy = GameHelper.RandomValue(0, 30);
        }

        public override void UseSkill()
        {
            
        }

        public override void Skill()
        {

        }

        public override void Attack()
        {
            
        }
    }
}
