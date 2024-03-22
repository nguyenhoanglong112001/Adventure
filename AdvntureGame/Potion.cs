using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Potion
    {
        public int restoreamount;
        public RestoreType restoreType;

        public Potion()
        {
            restoreType = (RestoreType)GameHelper.RandomValue(1, 2);
            if (restoreType == RestoreType.HP)
            {
                restoreamount = 100;
            }
            else if (restoreType == RestoreType.MP)
            {
                restoreamount = 30;
            }
        }
    }
}
