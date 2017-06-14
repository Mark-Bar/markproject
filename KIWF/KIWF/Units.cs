using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIWF
{
    class Units
    {

        int health = 100;

        public void unitOne(string damage)
        {


            if (damage == "attack")
            {
                health--;
                //Console.WriteLine("Player Wins");
            }
            
            
             Console.WriteLine("Enemy has " + health + "% health remaining!");
          


        }

        int healthPlayer = 100;

        public void Player(string damage)
        {

            if (damage == "attack")
            {
                healthPlayer--;
                //Console.WriteLine("Enemy Wins");
            }


            Console.WriteLine("Player has " + healthPlayer + "% health remaining!");


        }
    }
}
