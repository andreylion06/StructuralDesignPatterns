
namespace DecoratorPattern.Library.Inventory
{
    public class ArtifactDecorator : IInventoryItem
    {
        private const int _healthIncrease = 10; 

        private readonly IInventoryItem _decoratorInventory;

        public string Name { get; set; }

        public int Health { get; set; }

        public string Effect { get; set; }

        public ArtifactDecorator(IInventoryItem decoratorInventory, string effect)
        {
            _decoratorInventory = decoratorInventory;
            // The hero brings the thing to the blacksmith,
            // he reworks it for him. Therefore, health increases.
            Name = decoratorInventory.Name;
            Health += decoratorInventory.Health + _healthIncrease;
            Effect = effect;
            Console.WriteLine($"The item was reworked at the blacksmith's (heal.+{_healthIncrease}). Current health: {Health}");

        }

        public bool Apply(int damage)
        {
            if (Health - damage < 0)
            {
                Console.WriteLine($"{Effect} Artifact lost the spell. Cannot be applied");
                return false;
            }
            else
            {
                Health -= damage;
                Console.WriteLine($"*Magic Sound* {Effect} Armor applied. Current health: {Health}");
                return true;
            }
        }

        public override string ToString()
        {
            return $"Artifact {Name} with {Effect} effect (heal.{Health})";
        }
    }
}
