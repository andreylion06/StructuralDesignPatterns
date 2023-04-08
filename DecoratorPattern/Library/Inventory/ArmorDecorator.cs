using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Library.Inventory
{
    public class ArmorDecorator : IInventoryItem
    {
        private const int _healthIncrease = 100; 

        private readonly IInventoryItem _decoratorInventory;

        public string Name { get; set; }

        public int Health { get; set; }

        public string Material { get; set; }

        public ArmorDecorator(IInventoryItem decoratorInventory, string material)
        {
            _decoratorInventory = decoratorInventory;
            // The hero brings the thing to the blacksmith,
            // he reworks it for him. Therefore, health increases.
            Name = decoratorInventory.Name;
            Health += decoratorInventory.Health + _healthIncrease;
            Material = material;
            Console.WriteLine($"The item was reworked at the blacksmith's (heal.+{_healthIncrease}). Current health: {Health}");

        }

        public bool Apply(int damage)
        {
            if (Health - damage < 0)
            {
                Console.WriteLine($"{Material} Armor is too worn. Cannot be equiped");
                return false;
            }
            else
            {
                Health -= damage;
                Console.WriteLine($"{Material} Armor equiped. Current health: {Health}");
                return true;
            }
        }

        public override string ToString()
        {
            return $"{Material} Armor {Name} (heal.{Health})";
        }
    }
}
