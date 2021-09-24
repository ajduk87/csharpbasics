using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Shapes
{
    public class Cube
    {
        private double a;

        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }
        public SpecificMaterial SpecificMaterial { get; set; }
        public Color Color { get; set; }
        public int OrderAmount { get; set; }



        public static int NumberOfSoldCubes = 0;


        public static void IncrementNumberOfSoldCubes()
        {
            NumberOfSoldCubes++;
        }

        static Cube()
        {
            Console.WriteLine("Static sphere constructor is called.");

            NumberOfSoldCubes = 0;
        }

        public Cube()
        {
            this.a = 0.0;

            this.Name = "cube";
            this.Material = Material.PLASTIC;
            this.Price = 0.0;
            this.SpecificMaterial = SpecificMaterial.PETPLASTIC;
            this.Color = Color.WHITE;
        }

        public Cube(string Name, double a, Material Material, double Price)
        {
            Console.WriteLine("Instance cube constructor is called.");

            this.a = a;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            SpecificMaterial = SpecificMaterial.PETPLASTIC;
            Color = Color.WHITE;
        }

        public Cube(string Name, double a, Material Material, double Price, int OrderAmount)
        {
            Console.WriteLine("Instance cube constructor is called.");

            this.a = a;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.OrderAmount = OrderAmount;
        }

        public Cube(string Name, double a, Material Material, double Price, SpecificMaterial SpecificMaterial)
        {
            this.a = a;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
        }

        public Cube(string Name, double a, Material Material, double Price, SpecificMaterial SpecificMaterial, Color Color)
        {
            this.a = a;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
            this.Color = Color;
        }
        public double CalculateVolume()
        {
            return Math.Round(Math.Pow(a, 3), 2);
        }

        public double CalculateArea()
        {
            return Math.Round(6 * Math.Pow(a, 2), 2);
        }

        //business rule:
        //if over 20 purchased pieces received a five percent discount
        public double CalculateOrderItemValue()
        {
            double orderItemValue = this.OrderAmount > 20 ? 0.95 * this.Price * this.OrderAmount :
                                                            this.Price * this.OrderAmount;

            return orderItemValue;
        }
    }
}
