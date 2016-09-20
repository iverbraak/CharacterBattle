using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBehaviorAct1
{
    class CommonCharacter
    {
        protected int health;
        protected int level;
        protected int stamina;
        protected string name;

        
        public CommonCharacter()
        {
            health = 100;
            level = 1;
            stamina = 60;            
        }
        public CommonCharacter(int health, int level, int stamina, string name)
        {
            this.name = name;
            this.health = health;
            this.level = level;
            this.stamina = stamina;
        }
        
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string Name
        {
            get { return  name; }
            set { name = value; }
        }
        
        public int Level    // <-- will be able to change over time, so it will have a get & set
        {
            get { return level; }
            set {level = value;}                
        }

        public int Stamina // <-- will decrease when the character uses their attack
        {
            get { return stamina; }
            set { stamina = value; }
        }
        //charas attack method, determines damage
        public virtual int Attack()
        {

            Random rand = new Random();
            int firstGen = rand.Next(1, 101);
            int damage = 0;

            if (firstGen < 26)
            {
                Console.WriteLine("Missed. No damage.");
                return damage;
            }
            else if (firstGen < 46)
            {
                Console.WriteLine("You nicked the enemy.");
                damage = rand.Next(1, 6);
                Console.WriteLine("Damage dealt: " + damage);
                return damage;
            }
            else if (firstGen < 66)
            {
                Console.WriteLine("Light hit.");
                damage = rand.Next(6, 11);
                Console.WriteLine("Damage dealt: " + damage);
                return damage;
            }
            else if (firstGen < 86)
            {
                Console.WriteLine("You hit the enemy.");
                damage = rand.Next(11, 16);
                Console.WriteLine("Damage dealt: " + damage);
                return damage;
            }
            else
            {
                Console.WriteLine("Severe hit.");
                damage = rand.Next(16, 21);
                Console.WriteLine("Damage dealt: " + damage);
                return damage;
            }

        }
        //checks charas current health value, if 0, chara is dead
        public virtual bool IsDead()
        {
            if (health <= 0)
            {
                Console.WriteLine("Your character is dead.");
                return true;
            }
            Console.WriteLine("Your character is alive.");
            return false;
        }
        //changes charas health depending on the damage that is dealt to them
        public virtual void ChangeHealth(int amount)
        {
            health += amount;
            if (health < 0)
            {
                health = 0;
            }
            if (health > 100)
            {
                health = 100;
            }
        }
        //chara will flee if their health reaches a certain point, this method 
        //determines that
        public virtual bool HasFled()
        {
            if (health < 25)
            {
                Console.WriteLine("Your character has fled.");
                return true;
            }
            else
            {
                Console.WriteLine("Your character has stayed for the fight.");
                return false;
            }
        }
    }
}
