using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Library.Inventory
{
    public class WeaponDecorator : IInventoryItem
    {
        private const int _healthIncrease = 100;

        private readonly IInventoryItem _decoratorInventory;

        public string Name { get; set; }

        public int Health { get; set; }

        public int Power { get; set; }

        public WeaponDecorator(IInventoryItem decoratorInventory, int power)
        {
            _decoratorInventory = decoratorInventory;
            // The hero brings the thing to the blacksmith,
            // he remakes it for him. Therefore, health increases.
            Name = decoratorInventory.Name;
            Health += decoratorInventory.Health + _healthIncrease;
            Power = power;
            Console.WriteLine($"The item was reworked at the blacksmith's (heal.+{_healthIncrease}). Current health: {Health}");

        }

        public bool Apply(int damage)
        {
            if (Health - damage < 0)
            {
                Console.WriteLine($"The Weapon(pow. {{Power}}) is broken. Requires repair");
                return false;
            }
            else
            {
                Health -= damage;
                Console.WriteLine($"The Weapon(pow. {Power}) applied. Current health: {Health}");
                return true;
            }
        }

        public override string ToString()
        {
            return $"Weapon {Name} with {Power} power (heal.{Health})";
        }
    }
}
