﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIWF
{
    class Units
    {

        int health = 100;

       //code here bitch

        int healthPlayer = 100;

        public string Player(string damage)
        {
            
            string msg = null;
            if (damage == "attack")
            {
                healthPlayer--;
                msg = "ENEMY Drew Blood";
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
