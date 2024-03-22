using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public abstract class Item
    {
        public int itemid;
        public string type;
        public int weight;
        public ItemRarity tier;

        public virtual void ShowItemInfo()
        {
            Console.Clear();
            Console.WriteLine($"Item Type: {type}");
            Console.WriteLine($"Weigh: {weight}");
            Console.WriteLine($"Tier: {tier}");
        }

        public abstract void ItemAdd(Hero hero);

        public abstract void ItemRemove(Hero hero);
    }
}
