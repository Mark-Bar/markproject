using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KIWF
{
    class Program
    {
        public static void Main()
        {
            Dice myDiceOne = new Dice();

            Console.WriteLine("    *** KILL IT WITH FIRE ! ***");
            //Console.WriteLine(" Starring: ");
            Console.WriteLine("");
            PlayTime run = new PlayTime();
            
            run.Play("");
            Console.ReadLine();
        }

    }

}

































