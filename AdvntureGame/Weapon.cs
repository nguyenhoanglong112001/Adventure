using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Weapon : Item
    {
        public WeaponType weapontype;
        public int atk;
        public int crit;
        public int accurancy;

        public Weapon()
        {
            weapontype = (WeaponType)GameHelper.RandomValue(0,4);
            type = weapontype.ToString();
            tier = (ItemRarity)GameHelper.RandomValue(1, 5);
            if (tier == ItemRarity.Common)
            {
                atk = GameHelper.RandomValue(15, 30);
                crit = GameHelper.RandomValue(0, 10);
                accurancy = GameHelper.RandomValue(0, 15);
                weight = GameHelper.RandomValue(12, 15);
            }
            else if (tier == ItemRarity.Rare)
            {
                atk = GameHelper.RandomValue(35, 50);
                crit = GameHelper.RandomValue(15, 30);
                accurancy = GameHelper.RandomValue(15,30);
                weight = GameHelper.RandomValue(10, 12);
            }
            else if (tier == ItemRarity.Epic)
            {
                atk = GameHelper.RandomValue(50, 60);
                crit = GameHelper.RandomValue(30, 40);
                accurancy = GameHelper.RandomValue(30, 40);
                weight = GameHelper.RandomValue(8,10);
            }
            else if (tier == ItemRarity.Lengedary)
            {
                atk = GameHelper.RandomValue(60, 80);
                crit = GameHelper.RandomValue(40, 60);
                accurancy = GameHelper.RandomValue(40, 65);
                weight = GameHelper.RandomValue(5, 8);
            }
            else if (tier==ItemRarity.Mythical)
            {
                atk = GameHelper.RandomValue(90, 110);
                crit = GameHelper.RandomValue(70, 100);
                accurancy = GameHelper.RandomValue(70, 100);
                weight = GameHelper.RandomValue(0, 4);
            }
        }
        public override void ShowItemInfo()
        {
            base.ShowItemInfo();
            Console.WriteLine($"attack dame: {atk}");
            Console.WriteLine($"crit: {crit}");
            Console.WriteLine($"accurancy: {accurancy}");
        }

        public override void ItemAdd(Hero hero)
        {
            hero.atk += atk;
            hero.crit += crit;
            hero.accurancy += accurancy;
            hero.totalweigh += weight;
        }
        public override void ItemRemove(Hero hero)
        {
            hero.atk -= atk;
            hero.crit -= crit;
            hero.accurancy -= accurancy;
            hero.totalweigh -= weight;
        }
    }
}
