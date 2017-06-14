using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIWF
{
    public class Scratch
    {
        public string unitX(string damage, string heart)
        {
            int health = 100;
            string msg = null;
            if (damage == "attack")
            {

                heart = "";
                health--;
                msg = "PLAYER drew blood" + health;
                Console.WriteLine(msg);
                return msg;
               

            }

            else
            {
                return msg;
            }
        }
    }

}