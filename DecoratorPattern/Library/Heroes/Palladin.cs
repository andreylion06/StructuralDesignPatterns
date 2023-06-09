﻿using DecoratorPattern.Library.Inventory;

namespace DecoratorPattern.Library.Heroes
{
    public class Palladin : Hero
    {
        public Palladin(string name, int health) : base(name, health) { }

        public override void Action()
        {
            Console.WriteLine("Khhh... Palladin acts");
            foreach (IInventoryItem item in Inventory)
                item.Apply(15);
        }
    }
}
