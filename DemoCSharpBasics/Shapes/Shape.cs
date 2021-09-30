using DemoCSharpBasics.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Shapes
{
    public class Shape
    {
        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }
        public SpecificMaterial SpecificMaterial { get; set; }
        public Color Color { get; set; }

        public Shape(string Name, 
                     Material Material, 
                     double Price, 
                     SpecificMaterial SpecificMaterial,
                     Color Color,
                     int OrderAmount)
        {
            Console.WriteLine("Instance shape (base) constructor is called.");

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
            this.Color = this.Color;
        }

        //business rule:
        //if it is purchased over 20 shapes you will receive a five percent discount
        public virtual OrderItem ProcessOrderItem(OrderItem orderItem)
        {
            if (orderItem.OrderAmount > 20)
            {
                orderItem.Value = 0.95 * this.Price * orderItem.OrderAmount;
                orderItem.Discount = 5;                
            }
            else 
            {
                orderItem.Value = this.Price * orderItem.OrderAmount;
                orderItem.Discount = 0;
            }

            orderItem.PayedAmount = orderItem.OrderAmount;

            return orderItem;
        }
    }
}
