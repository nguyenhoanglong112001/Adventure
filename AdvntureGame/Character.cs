using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public abstract class Character
    {
        public  string name {  get; set; }
        public  HeroType type { get; set; }
        public int hp {  get; set; }
        public int mp { get; set; }
        public int atk {  get; set; }
        public int atkspeed {  get; set; }
        public int ap { get; set; }
        public  int amor { get; set; }
        public int crit { get; set; }
        public int evasion { get; set; }
        public   int accurancy { get; set; }
        public int totalweigh { get; set; } = 0;
        public   int level { get; set; }
        public   int exp {  get; set; }
        public   int currentgold { get; set; }
        public bool Alive => hp > 0;

        public List<Item> itemuse = null;

        public abstract void Attack();

        public abstract void UseSkill();

        public abstract void Skill();
    }
}
