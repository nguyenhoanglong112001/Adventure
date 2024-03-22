using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class CharacterManager
    {

        public CharacterManager() 
        {
            Program.createhero = CreateHero; 
            Program.useitem = UseItem;
            Program.unequipitem = UnequipItem;
        }

        public HeroType ChooseType()
        {
            int str = Program.uimanager.InputInt("Nhap lua chon cua ban: ",1,3);
            HeroType herotype = 0;
            if (str == 1)
            {
                herotype = HeroType.Tank;
            }
            else if (str == 2)
            {
                herotype = HeroType.Ranged;
            }
            else if (str == 3)
            {
                herotype = HeroType.Assasin;
            }
            return herotype;
        }
        public void CreateHero(string name)
        {
            HeroType type = ChooseType();
            if (type == HeroType.Tank)
            {
                Program.hero = new Tanker(name, type);
            }
            else if (type == HeroType.Ranged)
            {
                Program.hero = new Ranged(name, type);
            }
            else if (type == HeroType.Assasin)
            {
                Program.hero = new Assasin(name, type);
            }
        }
        
        public bool FullItem()
        {
            bool emptycheck = Program.hero.itemuse.Any(item => item == null);
            if (emptycheck)
            {
                return false;
            }
            else { return true; }
        }

        public bool AvaliableSlot(int slot)
        {
            if (Program.hero.itemuse[slot] == null)
            {
                return true;
            }
            return false;
        }

        public void UseItem(int slot, int index, Item item)
        {
            item.ItemAdd(Program.hero);
            Program.hero.itemuse[slot] = item;
            Program.itemmanager.items[index] = null;
        }

        public void UnequipItem(int slot,Item item)
        {
            item.ItemRemove(Program.hero);
            Program.itemmanager.items.Add(item);
            Program.hero.itemuse[slot] = null;
        }
    }


}
