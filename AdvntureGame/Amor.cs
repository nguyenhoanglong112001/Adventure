using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Amor : Item
    {
        public int def;
        public int hp;
        public int evasion;

        public Amor()
        {
            this.type = "Amor";
            tier = (ItemRarity)GameHelper.RandomValue(1, 5);
            if (tier == ItemRarity.Common)
            {
                def = GameHelper.RandomValue(1, 4);
                hp = GameHelper.RandomValue(200, 500);
                evasion = GameHelper.RandomValue(0, 10);
                weight = GameHelper.RandomValue(15, 20);
            }
            else if (tier == ItemRarity.Rare) 
            {
                def = GameHelper.RandomValue(5, 12);
                hp = GameHelper.RandomValue(550, 800);
                evasion = GameHelper.RandomValue(10,20);
                weight = GameHelper.RandomValue(12, 15);
            }
            else if  (tier == ItemRarity.Epic)
            {
                def = GameHelper.RandomValue(13, 20);
                hp = GameHelper.RandomValue(850,1100);
                evasion = GameHelper.RandomValue(25, 40);
                weight = GameHelper.RandomValue(8, 12);
            }
            else if (tier == ItemRarity.Lengedary)
            {
                def = GameHelper.RandomValue(25, 40);
                hp = GameHelper.RandomValue(1200, 1600);
                evasion = GameHelper.RandomValue(45, 55);
                weight = GameHelper.RandomValue(5, 8);
            }
            else if (tier == ItemRarity.Mythical)
            {
                def = GameHelper.RandomValue(45, 60);
                hp = GameHelper.RandomValue(2000, 3000);
                evasion = GameHelper.RandomValue(60, 70);
                weight = GameHelper.RandomValue(1,4);
            }
        }

        public override void ShowItemInfo()
        {
            base.ShowItemInfo();
            Console.WriteLine($"def: {def}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"evasion: {evasion}");
        }

        public override void ItemAdd(Hero hero)
        {
            hero.hp += hp;
            hero.evasion += evasion;
            hero.amor += def;
            hero.totalweigh += weight;
        }

        public override void ItemRemove(Hero hero)
        {
            hero.hp -= hp;
            hero.evasion -= evasion;
            hero.amor -= def;
            hero.totalweigh -= weight;
        }
    }
}
