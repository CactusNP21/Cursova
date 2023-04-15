using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursova
{
    internal class Player
    {
        public string secretNumber = "";
        public string prevAns = "";
        public string bulls = "";
        public string cows = "";
        public Player()
        {

        }
        public Player(string sn)
        {
            secretNumber = sn;   
        }
       
    }
}
