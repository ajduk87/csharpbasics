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
            Identifier = Guid.NewGuid();
            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
            this.Color = Color;
        }

        #region Getters

        public Guid GetIdentifier() 
        {
            return this.Identifier;
        }

        public string GetName() 
        {
            return this.Name;
        }

        public double GetPrice() 
        {
            return this.Price;
        }

        public string GetSpecificMaterial() 
        {
            return this.SpecificMaterial;
        }

        //Color should be read only
        public string GetColor() 
        {
            return this.Color;
        }

        #endregion

        #region Setters

        public void SetName(string name)
        {
            //Name of Shape can not be null
            if (string.IsNullOrEmpty(name) == false) 
            {
                this.Name = name;
            }
        }

        public void SetMaterial(string material) 
        {
            List<string> availableMaterials = new List<string>();
            availableMaterials.Add("PLASTIC");
            availableMaterials.Add("WOOD");
            availableMaterials.Add("METAL");
            availableMaterials.Add("GLASS");

            //Material have to be one of 4 available materials in shape store (plastic, wood, metal, glass)
            if (availableMaterials.Contains(material)) 
            {
                this.Material = material;
            }
        }

        public void SetPrice(double price)
        {
            //Price should always be greater than zero
            if (price > 0) 
            {
                this.Price = price;
            }
        }

        public void SetSpecificMaterial(string specificMaterial) 
        {
            //if SpecificMaterial is missing type SpecificMaterial is not specified.
            this.SpecificMaterial = string.IsNullOrEmpty(specificMaterial) ? "SpecificMaterial is not specified" :
                                                                             specificMaterial;
        }

        #endregion

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
