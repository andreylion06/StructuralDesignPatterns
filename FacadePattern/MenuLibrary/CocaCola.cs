using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.MenuLibrary
{
    public class CocaCola
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public CocaCola()
        {
            Name = "Coca Cola";
            Price = 1.99m;
        }
    }
}
