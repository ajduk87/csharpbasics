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
        //A GUID (Global Unique IDentifier) is a 128-bit integer used as a unique identifier.
        public Guid Identifier;
        public string Name;
        public string Material;
        public double Price;
        public string SpecificMaterial;
        public string Color;

        public Shape(string Name, 
                     string Material, 
                     double Price, 
                     string SpecificMaterial,
                     string Color)
        {
            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
            this.Color = Color;
        }

        //business rule:
        //order item processing first way - delivery at the order amount at once
        public OrderItem ProcessOrderItem(OrderItem orderItem, int orderAmount)
        {
            orderItem.DeliveryWay = "at once";
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

        //business rule:
        //order item processing second way - delivery at the order amount in two parts
        public OrderItem ProcessOrderItem(OrderItem orderItem, int firstHalfYearAmount, int secondHalfYearAmount)
        {
            orderItem.DeliveryWay = "in two parts";
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

        //business rule:
        //order item processing third way - delivery at the order amount in n parts, where n is number between 3 and 12
        public OrderItem ProcessOrderItem(OrderItem orderItem, int[] amounts)
        {
            orderItem.DeliveryWay = $"in {amounts.Length} parts";
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
