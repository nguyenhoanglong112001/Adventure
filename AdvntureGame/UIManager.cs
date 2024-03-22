using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class UIManager
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("=========Dungeon Game==========");
            Console.WriteLine("1. Create Hero");
            Console.WriteLine("2. Show hero infomation");
            Console.WriteLine("3. Create Item");
            Console.WriteLine("4. Show list item");
            Console.WriteLine("5. Start Game");
            int str = InputInt("Lua chon cua ban: ",1,5);
            if (str == 1)
            {
                CreateHeroUI();
            }
            else if (str == 2)
            {
                ShowHeroInfo();
            }
            else if (str == 3)
            {
                CreateItemUI();
            }
            else if (str == 4)
            {
                ShowListItem();
            }
            else if (str == 5)
            {
                Program.mapmanager.MapCreate();
                for (int i=0;i<Program.mapmanager.maps.Count;i++)
                {
                    ShowMapinfo(Program.mapmanager.maps[i+1]);
                }
            }
        }
        public void LoginUI()
        {
            Console.Clear();
            Console.WriteLine("1. Dang nhap");
            Console.WriteLine("2. Dang ky");
            int select = InputInt("Lua chon cua ban: ",1,2);
            if (select == 1)
            {
                Login();
            }
            else if (select == 2 )
            {
                Register();
            }
        }
        public void Register()
        {
            Console.Clear();
            Console.WriteLine("=======Dang ky tai khoan=======");
            string json = File.ReadAllText("Data.json");
            Data data = JsonConvert.DeserializeObject<Data>(json);
            string username = InputStr("username: ");
            string password = InputStr("Password: ");
            foreach (var kvp in data.accounts.Values)
            {
                if (username.Equals(kvp.username))
                {
                    Console.WriteLine("Ten dang nhap da ton tai vui long nhap lai");
                    Console.ReadKey();
                    LoginUI();
                }
            }
            Program.account = new Account(username, password);
            data.accounts.Add(username, Program.account);
            string newjson = JsonConvert.SerializeObject(data);
            File.WriteAllText("Data.json", newjson);
            Console.WriteLine("Tao tai khoan moi thanh cong");
            Console.ReadKey();
            LoginUI();
        }

        public void Login()
        {
            Console.Clear();
            string json = File.ReadAllText("Data.json");
            Data data = JsonConvert.DeserializeObject<Data>(json);
            Console.WriteLine("=======Dang nhap=======");
            string username = InputStr("username: ");
            string password = InputStr("Password: ");
            if (data.accounts.Any(u => u.Value.username.Equals(username) && u.Value.password.Equals(password)))
            {
                Console.WriteLine("Dang nhap thanh cong");
                Console.ReadKey();
                MainMenu();
            }
            else
            {
                Console.WriteLine("Sai ten tai khoan hoac mat khau");
                Console.ReadKey();
                LoginUI();
            }
        }

        public void ChooseTypeUI()
        {
            Console.Clear();
            Console.WriteLine("1. Tanker");
            Console.WriteLine("2. Ranged");
            Console.WriteLine("3. Assasin");
            Program.characterManager.ChooseType();
        }
        
        public void CreateHeroUI()
        {
            Console.Clear();
            Console.WriteLine("=======Khoi tao nhan vat==========");
            string name = InputStr("Ten nhan vat: ");
            ChooseTypeUI();
            Program.createhero(name);
            Program.accountinfo.characters.Add(Program.hero);
            Console.WriteLine("Tao nhan vat thanh cong");
            Console.ReadKey();
            MainMenu();
        }

        public void ShowHeroInfo()
        {
            Console.Clear();
            Console.WriteLine($"========{Program.hero.name}'information=========");
            Console.WriteLine($"Type: {Program.hero.type}");
            Console.WriteLine($"Level {Program.hero.level} \t Exp: {Program.hero.exp} \t Gold: {Program.hero.currentgold}");
            Console.WriteLine($"HP: {Program.hero.hp}");
            Console.WriteLine($"Mana: {Program.hero.mp}");
            Console.WriteLine($"Attack dame: {Program.hero.atk}");
            Console.WriteLine($"Attack speed: {Program.hero.atkspeed}");
            Console.WriteLine($"Amplify Dame: {Program.hero.ap}");
            Console.WriteLine($"Amor: {Program.hero.amor}");
            Console.WriteLine($"Crit: {Program.hero.crit}");
            Console.WriteLine($"Evasion: {Program.hero.evasion}");
            Console.WriteLine($"Accurancy: {Program.hero.accurancy}");
            for (int i =0;i<Program.hero.itemuse.Count;i++)
            {
                if (Program.hero.itemuse[i] != null)
                {
                    Console.WriteLine($"slot {i}: {Program.hero.itemuse[i].type}");
                }
            }
            Console.WriteLine("1. Unequip Item");
            Console.WriteLine("2. Main menu");
            int select = InputInt("Lua chon: ",1,2);
            if (select == 1)
            {
                int slot = InputInt("Nhap slot muon thao trang bi");
                Console.WriteLine($"Thong tin trang bi thao: {Program.hero.itemuse[slot].type}\t{Program.hero.itemuse[slot].tier}");
                Console.WriteLine("ban muon thao trang bi nay khong");
                string input = InputStr("Y:Dong y, N: Tu choi");
                if (input.Equals("Y") || input.Equals("y"))
                {
                    Program.unequipitem(slot-1, Program.hero.itemuse[slot - 1]);
                    Console.WriteLine("Thao trang bi thanh cong");
                    Console.ReadKey();
                    ShowHeroInfo();
                }
                else
                {
                    MainMenu();
                }
            }
            else if (select==2)
            {
                MainMenu();
            }
            Console.ReadKey();
        }

        public void CreateItemUI()
        {
            Console.Clear();
            Console.WriteLine("1. Roll 10 item");
            Console.WriteLine("2. Roll 1 item");
            int select = InputInt("Lua chon cua ban: ",1,2);
            if ( select == 1 )
            {
                Program.createitem(10);
            }
            else if (select == 2)
            {
                Program.createitem(1);
            }
            Console.ReadKey();
            MainMenu();
        }

        public void ShowItemInfo(Item item)
        {
            Console.Clear();
            item.ShowItemInfo();
        }

        public void ShowListItem()
        {
            for (int i=0;i<Program.itemmanager.items.Count;i++)
            {
                if (Program.itemmanager.items[i] !=null)
                {
                    Console.WriteLine($"{i + 1}. {Program.itemmanager.items[i].type}");
                }
            }
            Console.WriteLine("=================");
            Console.WriteLine("1. Show item info");
            Console.WriteLine("2. Main menu");
            int select = InputInt("Lua chon: ",1,2);
            if ( select == 1 )
            {
                Console.Clear();
                int index = InputInt("Nhap trang bi muon xem chi tiet: ");
                ShowItemInfo(Program.itemmanager.items[index - 1]);
                Console.ReadKey();
                Console.WriteLine("1. Su dung trang bi");
                Console.WriteLine("2. Main menu");   
                int choice = InputInt("Lua chon: ",1,2);
                if (choice == 1)
                {
                    int slot = InputInt("slot muon trang bi: ",1,3);
                    Console.WriteLine($"Ban co muon trang bi {Program.itemmanager.items[index - 1]} vao slot {slot}");
                    string input = InputStr("Y:Dong y, N: Tu choi");
                    if (input.Equals("Y") || input.Equals("y"))
                    {
                        if (Program.characterManager.AvaliableSlot(slot - 1))
                        {
                            Program.useitem(slot - 1, index - 1, Program.itemmanager.items[index - 1]);
                            Console.WriteLine("Trang bi thanh cong");
                            Console.ReadKey();
                            MainMenu();
                        }
                        else
                        {
                            Console.WriteLine("Slot da duoc trang bi vat pham ban co muon thay the vat pham khong");
                            input = InputStr("Y:Dong y, N: Tu choi");
                            if (input.Equals("Y") || input.Equals("y"))
                            {
                                Program.unequipitem(slot - 1, Program.hero.itemuse[slot - 1]);
                                Program.useitem(slot - 1, index - 1, Program.itemmanager.items[index - 1]);
                                Console.WriteLine("Thay the trang bi thanh cong");
                                Console.ReadKey();
                                MainMenu();
                            }
                            else
                            {
                                MainMenu();
                            }
                        }
                    }
                    else
                    {
                        MainMenu();
                    }
                }
                else if (choice == 2)
                {
                    MainMenu();
                }
            }
        }

        public void ShowMonsterlist()
        {
            int i = 1;
            foreach (var monsterList in Program.mapmanager.maps.Values)
            {
                foreach (var mon in monsterList.monsters)
                {
                    if (mon is Monster)
                    {
                        Console.WriteLine($"{i}. Monster: {((Monster)mon).name}");
                    }
                    else if (mon is Boss)
                    {
                        Console.WriteLine($"{i}. Boss: {((Boss)mon).bossname}");
                    }
                }
                i++;
            }
        }

        public void ShowMapinfo(Map map)
        
        {
            Console.Clear();
            Console.WriteLine($"Tang: {map.floor}");
            Console.WriteLine($"So luong quai: {map.monsters.Count(monster => monster is Monster)}");
            ShowMonsterlist();
            Console.ReadKey();
            MainMenu();
        }

        public string InputStr(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }

        public int InputInt(string input)
        {
            Console.WriteLine(input);
            if (!int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Nhap sai ky tu vui long nhap lai !!!!!");
                InputInt(input);
            }
            return result;
        }

        public int InputInt(string input,int min,int max)
        {
            Console.Write(input);
            bool str = int.TryParse(Console.ReadLine(), out int result);
            if (!str)
            {
                Console.WriteLine("Nhap sai dinh dang vui long nhap lai");
                return InputInt(input);
            }
            else
            {
                if (result > max || result<min)
                {
                    Console.WriteLine("Nhap sai lua chon vui long nhap lai");
                    return InputInt(input);
                }
            }
            return result;
        }
    }
}
