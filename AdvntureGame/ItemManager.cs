using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class ItemManager
    {
        public List<Item> items = null;
        public ItemManager() 
        {
            items = new List<Item>();
            Program.createitem = CreateItem;
        }

        public void CreateItem(int count)
        {
            for (int i =0; i < count; i++)
            {
                int type = GameHelper.RandomValue(1, 3);
                if (type == 1)
                {
                    Weapon newweapon = new Weapon();
                    items.Add(newweapon);
                    Console.WriteLine($"{i + 1} \t {newweapon.type} \t {newweapon.tier} ");
                }
                else if (type == 2)
                {
                    Amor newamor = new Amor();
                    items.Add(newamor);
                    Console.WriteLine($"{i + 1} \t {newamor.type} \t {newamor.tier}");
                }
                Thread.Sleep(100);
            }
        }
    }
}
