using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Orders
{
    public class Order
    {
        public string ProductName { get; set; }
        public Material Material { get; set; }
        public int Amount { get; set; }

        public Order(string productName, Material material, int amount) 
        {
            ProductName = productName;
            Material = material;
            Amount = amount;
        }
    }
}
