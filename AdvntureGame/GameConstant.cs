using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public enum HeroType
    {
        Tank,
        Ranged,
        Assasin
    }
    public enum WeaponType
    {
        Blade,
        Knife,
        Staff
    }

    public enum RestoreType
    {
        HP,
        MP
    }

    public enum ItemRarity
    {
        Common,
        Rare,
        Epic,
        Lengedary,
        Mythical
    }

    public enum MonsterName
    {
        Clink,
        Hawk,
        Lion,
        Hec,
        Selkenton
    }
    public enum BoosName
    {
        Doom,
        TerrorKing,
        WraithKing,
        DragonAncient
    }
    public class GameConstant
    {
    }
}
