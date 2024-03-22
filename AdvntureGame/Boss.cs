using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Boss : Monster
    {
        public BoosName bossname;
        public int crit;
        public int evasion;

        public Boss() 
        {
            bossname = (BoosName)GameHelper.RandomValue(1, 4);
            base.level += 5;
            crit = GameHelper.RandomValue(50, 101);
            evasion = GameHelper.RandomValue(50, 101);
            base.hp = (int)(base.hp*1.5f);
            base.mp = (int)(base.mp * 1.1f);
            base.atk = (int)(base.atk * 1.8f);
            base.atkspeed = (int)(base.atkspeed * 1.4f);
        }
    }
}
