using DecoratorPattern.Library.Inventory;

namespace DecoratorPattern.Library.Heroes
{
    public abstract class Hero
    {
        public string Name { get; set; }
        protected int health;
        public int Health 
        { 
            get { return health; } 
            set
            {
                if(value >= 0)
                    health = value;
                else
                    health = 0;
            }
        }

        public List<IInventoryItem> Inventory { get; protected set; }

        public Hero(string name, int health)
        {
            Name = name;
            Health = health;
            Inventory = new List<IInventoryItem>();
        }

        public bool AddInventoryItem(IInventoryItem item)
        {
            bool addPossibility = !Inventory.Contains(item);
            if (addPossibility)
                Inventory.Add(item);
            return addPossibility;
        }

        public bool RemoveInventoryItem(IInventoryItem item)
        {
            return Inventory.Remove(item);
        }

        public abstract void Action();

        public bool IsAlive()
        {
            return health > 0;
        }

        public override string ToString()
        {
            // Header from child class
            string output = string.Empty;
            output += $"Health: {Health}\n";
            output += "Inventory:\n";
            foreach(IInventoryItem item in Inventory) 
                output += $"\t{item.ToString()}\n";
            return output;
        }

    }
}
