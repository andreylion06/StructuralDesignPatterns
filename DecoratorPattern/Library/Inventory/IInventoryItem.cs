
namespace DecoratorPattern.Library.Inventory
{
    public interface IInventoryItem
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool Apply(int damage);
    }
}
