using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.MenuLibrary
{
    public class TotalPrice
    {
        public decimal Value { get; private set; }

        public TotalPrice()
        {
            Value = 0;
        }

        public void Add(decimal value)
        {
            Value += value;
        }

        public void Reset()
        {
            Value = 0;
        }
    }
}
