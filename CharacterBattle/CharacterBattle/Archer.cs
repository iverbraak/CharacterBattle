using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBehaviorAct1
{
    class Archer : CommonCharacter
    {
        private string attribute;
        private string items;

        public Archer()
        {
            attribute = "defense";
            items = "Bow and arrows";
        }
        public Archer(string attribute, string items, int health, int level, int stamina, string name) : base(health, level, stamina, name)
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
        public override string ToString()
        {
            return name + "'s strategy: " + attribute + " Archer's items: " + items + " Health: " + Health + " Stamina: " + Stamina;
        }
    }
}

