using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Sphere
    {
       
        private double r;


        public static int NumberOfSoldSpheres;
        private static double PI;

        public static void IncrementNumberOfSoldSpheres()
        {
            NumberOfSoldSpheres++;
        }

        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }
        public SpecificMaterial SpecificMaterial { get; set; }
        public Color Color { get; set; }
        public int OrderAmount { get; set; }

        static Sphere() 
        {
            Console.WriteLine("Static sphere constructor is called.");

            NumberOfSoldSpheres = 0;
            PI = 3.14;
        }

        public Sphere() 
        {
            this.r = 0.0;

            this.Name = "sphere";
            this.Material = Material.PLASTIC;
            this.Price = 0.0;
            this.SpecificMaterial = SpecificMaterial.PETPLASTIC;
            this.Color = Color.WHITE;
        }

        public Sphere(string Name, double r, Material Material, double Price)
        {
            Console.WriteLine("Instance sphere constructor is called.");

            this.r = r;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            SpecificMaterial = SpecificMaterial.PETPLASTIC;
            Color = Color.WHITE;
        }

        public Sphere(string Name, double r, Material Material, double Price, int OrderAmount)
        {
            Console.WriteLine("Instance sphere constructor is called.");

            this.r = r;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.OrderAmount = OrderAmount;
        }

        public Sphere(string Name, double r, Material Material, double Price, SpecificMaterial SpecificMaterial)
        {
            this.r = r;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
        }

        public Sphere(string Name, double r, Material Material, double Price, SpecificMaterial SpecificMaterial, Color Color)
        {
            this.r = r;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
            this.Color = Color;
        }
        public  double CalculateVolume() 
        {
            return Math.Round(4 * Math.Pow(r, 3) * PI / 3, 2);
        }

        public double CalculateArea()
        {
            return Math.Round(4 * Math.Pow(r, 3) * PI / 3, 2);
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
