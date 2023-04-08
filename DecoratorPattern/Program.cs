using DecoratorPattern.Library.Heroes;
using DecoratorPattern.Library.Inventory;

Hero hero = new Warrior("First Hero", 900);

IInventoryItem sword = new InventoryItem("Sword Of Truth", 400);
sword = new WeaponDecorator(sword, 90);
hero.AddInventoryItem(sword);

IInventoryItem armor = new InventoryItem("Cobra Armor", 700);
armor = new ArmorDecorator(armor, "Leather");
hero.AddInventoryItem(armor);

IInventoryItem artifact = new InventoryItem("Prophetic Lantern", 300);
artifact = new ArtifactDecorator(artifact, "Portends the Way");
hero.AddInventoryItem(artifact);

Console.WriteLine("\n\n\n");
Console.WriteLine(hero.ToString());
Console.WriteLine("\n\n\n");

hero.Action();



