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
            Console.WriteLine("");
            Console.WriteLine("              *** KILL IT WITH FIRE ! ***");
            Console.WriteLine("");

            PlayTime run = new PlayTime();
            PlayTime runA = new PlayTime();
            PlayTime runB = new PlayTime();
            PlayTime runC = new PlayTime();
            run.Play();
            runA.Play();
            runB.Play();
            runC.Play();
            Console.WriteLine("");
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }

    }

}

































