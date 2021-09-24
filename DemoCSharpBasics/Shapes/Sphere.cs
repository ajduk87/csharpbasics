using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Sphere : Shape
    {
       
        private double r;  
        

        public static int NumberOfSoldSpheres;
        private static double PI = 3.14;


        public static void IncrementNumberOfSoldSpheres()
        {
            NumberOfSoldSpheres++;
        }

       

        static Sphere() 
        {
            Console.WriteLine("Static sphere constructor is called.");

            NumberOfSoldSpheres = 0;
            PI = 3.14;
        }

        public Sphere() : base("sphere", Material.PLASTIC, 0.0, SpecificMaterial.PETPLASTIC, Color.WHITE, 0)
        {
        }

        public Sphere(string Name, double r, Material Material, double Price) :
                     base(Name, Material, Price, SpecificMaterial.PETPLASTIC, Color.WHITE, 0)
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
    }
}
