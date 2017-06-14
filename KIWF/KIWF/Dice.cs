using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIWF
{
    class Dice
    {

        public int roll()
        {


            Random rndOne = new Random();


            int diceOne = rndOne.Next(1, 7);
            System.Threading.Thread.Sleep(5);
            int diceTwo = rndOne.Next(1, 7);
            System.Threading.Thread.Sleep(5);
            int output = diceOne + diceTwo;
            return output;



        }
    }
}