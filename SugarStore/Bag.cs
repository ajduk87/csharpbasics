using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarStore
{
    public class Bag : SugarItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }

        public Bag(string name, double price, double amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public override double CalculateItemValue()
        {
            return Price * Amount;
        }
    }
}
