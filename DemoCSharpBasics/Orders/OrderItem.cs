using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Orders
{
    public class OrderItem
    {
        public string ProductName { get; set; }
        public Material Material { get; set; }
        public int OrderAmount { get; set; }
        public int PayedAmount { get; set; }
        public double Discount { get; set; }
        public double Value { get; set; }

        public OrderItem(string ProductName, Material Material, int OrderAmount) 
        {
            this.ProductName = ProductName;
            this.Material = Material;
            this.OrderAmount = OrderAmount;
        }
    }
}
