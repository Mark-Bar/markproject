using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIWF
{
    class Dice
    {

        //Random rndOne = new Random();

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int diceONE(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public static int diceTWO(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

    }

    }

  
 
