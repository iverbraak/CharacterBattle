using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBehaviorAct1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            /*
            //creates 3 archers 
            Archer archerKen = new Archer("offense", "Bow and arrows", 54, 12, 75, "Ken");

            Console.WriteLine(archerKen.ToString());

            Console.WriteLine();
            Archer archerGlen = new Archer("defense", "Cascioli's genuine pink Huntsman", 36, 55, 12,"Glen");
            Console.WriteLine(archerGlen.ToString());
            

            Console.WriteLine();
            Archer archerBen = new Archer("offense", "Crusader's Crossbow", 100, 43, 15,"Ben"); //MEDIC!
            Console.WriteLine();
            archerBen.Attack();
            archerBen.IsDead();
            archerBen.ChangeHealth(75);
            archerBen.HasFled();

            Console.WriteLine(archerBen.ToString());

            //creates a knight character
            Console.WriteLine();
            Knight knightTim = new Knight("offense", "Sword and Shield", 78, 60, 100, "Tim");
            Console.WriteLine(knightTim.ToString());
            knightTim.Attack();
            knightTim.IsDead();
            knightTim.HasFled();
            
            */

            List<CommonCharacter> listOfCharas = new List<CommonCharacter>();
            listOfCharas.Add(new Archer("defense", "Huntsman", 30, 45, 60, "Ken"));
            listOfCharas.Add(new Knight("offense", "Skull Crushing Sword", 90, 70, 30, "Jesse, yo"));
            listOfCharas.Add(new Archer("offense", "Poison Arrows", 100, 95, 10, "Glen"));
            listOfCharas.Add(new Knight("defense", "Makeshift Sword", 5, 85, 65, "Benjamin"));

            while(listOfCharas.Count > 1)
            {
                foreach(CommonCharacter battler in listOfCharas)
                {
                    Knight k;
                    Archer j;
                    int archerAttack, knightAttack;
                    //check type and downcast
                    if (battler is Knight)
                    {
                        k = (Knight)battler;
                       knightAttack = k.Attack();
                       
                       int opponentIndex = rand.Next(1, listOfCharas.Count);
                       listOfCharas[opponentIndex].ChangeHealth(-knightAttack);

                       Console.WriteLine("Your knight does " + knightAttack + " to " + "the enemy");
                       
                    }
                    
                    if(battler is Archer)
                    {
                        j = (Archer)battler;
                       archerAttack = j.Attack();
                        int opponentIndex = rand.Next(1, listOfCharas.Count);
                        listOfCharas[opponentIndex].ChangeHealth(-archerAttack);

                        Console.WriteLine("Your archer does " + archerAttack + " to " + "the enemy");
                    }                    
                }

                for (int i = 0; i < listOfCharas.Count; i++) 
                {
                    if(listOfCharas[i].HasFled() == true)
                    {
                        listOfCharas.RemoveAt(i);
                        Console.WriteLine("Your character is low on health and sails away in a boat.");
                    }
                }

                
            }
            if (listOfCharas.Count == 1)
            {
                Console.WriteLine("The winner is " + listOfCharas[0].Name);
            }
            else
            {
                Console.WriteLine("Everyone has fled the battle");
            }
        }
    }
}
