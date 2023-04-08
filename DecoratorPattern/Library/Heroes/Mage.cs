using DecoratorPattern.Library.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Library.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name, int health) : base(name, health) { }

        public override void Action()
        {
            Console.WriteLine("Wrrr... Mage acts");
            foreach (IInventoryItem item in Inventory)
                item.Apply(10);
        }

        public override string ToString()
        {
            string output = string.Empty;
            output += $"*** MAGE {Name} ***\n";
            output += base.ToString();
            return output;
        }
    }
}
