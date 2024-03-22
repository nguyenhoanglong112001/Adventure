using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Data
    {
        public Dictionary<string,Account> accounts = new Dictionary<string, Account>();

        public Data() 
        {
        }
    }
}
