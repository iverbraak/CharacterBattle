using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBehaviorAct1
{
    class Knight : CommonCharacter
    {
        private string attribute;
        private string items;

        public Knight()
        {
            attribute = "offense";
            items = "Sword and shield";
        }
        public Knight(string attribute, string items, int health, int level, int stamina, string name) : base(health, level, stamina, name)
        {
            this.items = items;
            this.attribute = attribute;
            switch(attribute)
            {
                case "offense":
                    attribute = "offense";
                    break;
                case "defense":
                    attribute = "defense";
                    break;
                default:
                    attribute = "offense";
                    break;
            }
        }
        //modified version of the attack method from the parent class
        public override int Attack()
        {
            Random rand = new Random();
            int firstGen = rand.Next(1, 101);
            int damage = 0;

            if(firstGen < 31)
            {
                Console.WriteLine("You missed the enemy.");
                damage = 0;
                Console.WriteLine("Damage dealt: " + damage);
                return damage;
            }
            else if(firstGen < 81)
            {
                Console.WriteLine("Medium hit.");
                damage = rand.Next(5, 16);
                Console.WriteLine("Damage dealt: " + damage);
                return damage;
            }
            else
            {
                Console.WriteLine("Severe hit.");
                damage = rand.Next(16, 26);
                Console.WriteLine("Damage dealt: " + damage);
                return damage;
            }
        }
        //knight is braver than the archer, so he stays until the very last bit of 
        //health is left to fight
        public override bool HasFled()
        {
            if(health < 5)
            {
                Console.WriteLine("Your knight has fled the battle.");
                return true;
            }
            else
            {
                Console.WriteLine("Your knight stays for the battle.");
                return false;
            }
        }

        public override string ToString()
        {
            return name + "'s strategy: " + attribute + " Archer's items: " + items + " Health: " + Health + " Stamina: " + Stamina;
        }
    }
}
