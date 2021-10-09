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
        private Guid identifier;
        private string name;
        private string material;
        private double price;
        private string specificMaterial;


        //A GUID (Global Unique IDentifier) is a 128-bit integer used as a unique identifier.
        public Guid Identifier 
        {
            get { return identifier; }
            set { identifier = value; }
        }
        public string Name 
        {
            get { return name; }
            set 
            {
                //Name of Shape can not be null
                if (string.IsNullOrEmpty(value) == false)
                {
                    name = value;
                }
            }
        }
        public string Material 
        {
            get { return material; }
            set 
            {
                List<string> availableMaterials = new List<string>();
                availableMaterials.Add("PLASTIC");
                availableMaterials.Add("WOOD");
                availableMaterials.Add("METAL");
                availableMaterials.Add("GLASS");

                //Material have to be one of 4 available materials in shape store (plastic, wood, metal, glass)
                if (availableMaterials.Contains(value))
                {
                    material = value;
                }
            }
        }
        public double Price 
        {
            get { return price; }
            set 
            {
                //Price should always be greater than zero
                if (value > 0)
                {
                    price = value;
                }
            }
        }
        public string SpecificMaterial 
        {
            get { return specificMaterial; }
            set 
            {
                //if SpecificMaterial is missing type SpecificMaterial is not specified
                specificMaterial = string.IsNullOrEmpty(value) ? "SpecificMaterial is not specified" :
                                                                             value;
            }
        }
        public string Color 
        {
            //Color should be read only
            get;
        }

        public Shape(string Name, 
                     string Material, 
                     double Price, 
                     string SpecificMaterial,
                     string Color)
        {
            Identifier = Guid.NewGuid();
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
