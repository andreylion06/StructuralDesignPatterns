using DecoratorPattern.Library.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Library.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name, int health) : base(name, health) { }

        public override void Action()
        {
            Console.WriteLine("Kdhh... Warrior acts");
            foreach (IInventoryItem item in Inventory)
                item.Apply(20);
        }
    }
}
