using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarStore
{
    public class Cube : SugarItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Cube(string name,  double price, int amount) 
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
