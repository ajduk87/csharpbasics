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
        public int OrderAmount { get; set; }

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
            this.OrderAmount = OrderAmount;
        }

        //business rule:
        //if it is purchased over 20 pieces you will receive a five percent discount
        public double CalculateOrderItemValue()
        {
            double orderItemValue = this.OrderAmount > 20 ? 0.95 * this.Price * this.OrderAmount :
                                                            this.Price * this.OrderAmount;

            return orderItemValue;
        }
    }
}
