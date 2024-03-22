using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class AccountInformation
    {
        //public Account account = null;
        public string username;
        public DateTime datecreate;
        //public DateTime timeplay;
        public List<Character> characters = null;

        public AccountInformation() 
        {
            characters = new List<Character>();
        }

        public bool fullcharacter()
        {
            if (characters.Count > 3)
            {
                return true;
            }
            return false;
        }
    }
}
