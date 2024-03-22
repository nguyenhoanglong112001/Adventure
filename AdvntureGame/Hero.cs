using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Hero : Character
    {
        public Hero(string name, HeroType type)
        {
            this.name = name;
            this.type = type;
            this.level = 1;
            this.exp = 0;
            this.currentgold = 0;
            itemuse = new List<Item>()
            {
                null,
                null,
                null
            };
        }
        public override void Attack()
        {
          
        }

        public override void UseSkill()
        {
            
        }

        public override void Skill()
        {

        }
    }
}
