using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.MenuLibrary
{
    public class BigMacMenu
    {
        private Package _package;
        private Napkins _napkins;
        private TotalPrice _price;

        public BigMacMenu()
        {
            _package = new Package();
            _napkins = new Napkins();
            _price = new TotalPrice();
        }

        public void AddBigMac()
        {
            BigMac bigMac = new BigMac();
            Console.WriteLine($"Added {bigMac.Name} for {bigMac.Price}");
            _price.Add(bigMac.Price);
        }

        public void AddFrenchFries()
        {
            FrenchFries frenchFries = new FrenchFries();
            Console.WriteLine($"Added {frenchFries.Name} for {frenchFries.Price}");
            _price.Add(frenchFries.Price);
        }

        public void AddCocaCola()
        {
            CocaCola cocaCola = new CocaCola();
            Console.WriteLine($"Added {cocaCola.Name} for {cocaCola.Price}");
            _price.Add(cocaCola.Price);
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = _price.Value + _package.Price + _napkins.Price;
            Console.WriteLine($"Total price: {totalPrice}");
            return totalPrice;
        }
    }
}
