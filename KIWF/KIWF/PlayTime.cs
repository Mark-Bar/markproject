using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KIWF
{
     class PlayTime
    {

        public void Play()
        {
            Console.WriteLine("");
            Console.Write("Hit enter to roll the dice and begin the assault");
            Console.WriteLine("");
            Console.ReadLine();

            Dice playerRoll = new Dice();
            string p = playerRoll.ToString();
            Console.WriteLine("Player rolled " + p);
            System.Threading.Thread.Sleep(5);
            string e = playerRoll.ToString();
            Console.WriteLine("Enemy  rolled " + e);

            int iPlayer = Convert.ToInt32(p);
            int iEnemy = Convert.ToInt32(e);

            if (iPlayer > iEnemy)
            {
                Units damage = new Units();
                damage.Player("");
                damage.unitOne("attack");
                
            }

            

            else if (iPlayer < iEnemy)
            {
                Units damageHit = new Units();
                damageHit.unitOne("");
                damageHit.Player("attack");
            }

            else
            {
                Console.WriteLine("> No one drew blood");
            }
            
            //Console.WriteLine("PLAYER Health:");
            //Console.WriteLine("ENEMY Health:");

        }


    }
}
