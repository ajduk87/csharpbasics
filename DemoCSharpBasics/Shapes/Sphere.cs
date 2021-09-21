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


        public static int NumberOfSoldSpheres = 0;
        private static double PI = 3.14;

        public static void IncrementNumberOfSoldSpheres()
        {
            NumberOfSoldSpheres++;
        }

        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }
        public SpecificMaterial SpecificMaterial { get; set; }
        public Color Color { get; set; }


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
            this.r = r;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            SpecificMaterial = SpecificMaterial.PETPLASTIC;
            Color = Color.WHITE;
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
