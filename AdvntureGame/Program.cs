using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdvntureGame
{
    public delegate void CreateHero(string name);
    public delegate void CreateItem(int count);
    public delegate void UseItem(int slot, int index, Item item);
    public delegate void UnequipItem(int slot, Item item);
    internal class Program
    {
        public static Account account = null;
        public static CreateHero createhero;
        public static UIManager uimanager = null;
        public static Hero hero = null;
        public static CharacterManager characterManager = null;
        public static AccountInformation accountinfo = null;
        public static ItemManager itemmanager = null;
        public static CreateItem createitem = null;
        public static UseItem useitem = null;
        public static UnequipItem unequipitem = null;
        public static MapManager mapmanager = null;
        static void Main(string[] args)
        {
            uimanager = new UIManager();
            itemmanager = new ItemManager();
            characterManager = new CharacterManager();
            accountinfo = new AccountInformation();
            mapmanager = new MapManager();
            uimanager.LoginUI();
        }
    }
}
