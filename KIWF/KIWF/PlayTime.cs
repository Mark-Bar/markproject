using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KIWF
{
     class PlayTime
    {

        public void Play(string a)
        {
            Console.Write("Hit enter to roll the dice and begin the assault");
            Console.ReadLine();

            Dice playerRoll = new Dice();
            string p = playerRoll.roll().ToString();
            Console.WriteLine("Player rolled a " + p);
            System.Threading.Thread.Sleep(5);
            string e = playerRoll.roll().ToString();
            Console.WriteLine("Enemy  rolled a " + e);

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
            
            Console.WriteLine("PLAYER Health:");
            Console.WriteLine("ENEMY Health:");

        }


    }
}
