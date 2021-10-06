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
                     Color Color)
        {
            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
            this.Color = this.Color;
        }

        //business rule:
        //if it is purchased over 20 shapes you will receive a five percent discount
        public OrderItem ProcessOrderItem(OrderItem orderItem, int orderAmount)
        {
            orderItem.OrderAmount = orderAmount;

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

        public OrderItem ProcessOrderItem(OrderItem orderItem, int firstHalfYearAmount, int secondHalfYearAmount)
        {
            orderItem.OrderAmount = firstHalfYearAmount + secondHalfYearAmount;

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

        public OrderItem ProcessOrderItem(OrderItem orderItem, int[] amounts)
        {
            orderItem.OrderAmount = 0;
            foreach (var amount in amounts)
            {
                orderItem.OrderAmount = orderItem.OrderAmount + amount;
            }

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
