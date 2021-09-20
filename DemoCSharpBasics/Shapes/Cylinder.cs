using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Cylinder
    {
        private double PI;
        private double r;
        private double H;

        public static int NumberOfSoldCylinders = 0;

        public static void IncrementNumberOfSoldCylinders()
        {
            NumberOfSoldCylinders++;
        }

        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }

        public SpecificMaterial SpecificMaterial { get; set; }
        public Color Color { get; set; }

        public Cylinder() 
        {
            this.r = 0.0;
            this.H = 0.0;
            PI = 3.14;

            Name = "cylinder";
            Material = Material.PLASTIC;
            Price = 0.0;
            SpecificMaterial = SpecificMaterial.PETPLASTIC;
            Color = Color.WHITE;
        }

        public Cylinder(string name, double r, double H, Material material, double price)
        {
            this.r = r;
            this.H = H;
            PI = 3.14;

            Name = name;
            Material = material;
            Price = price;
        }

        public Cylinder(string name, double r, double H, Material material, double price, SpecificMaterial specificMaterial)
        {
            this.r = r;
            this.H = H;
            PI = 3.14;

            Name = name;
            Material = material;
            Price = price;
            SpecificMaterial = specificMaterial;
        }

        public Cylinder(string name, double r, double H, Material material, double price, SpecificMaterial specificMaterial, Color color)
        {
            this.r = r;
            this.H = H;
            PI = 3.14;

            Name = name;
            Material = material;
            Price = price;
            SpecificMaterial = specificMaterial;
            Color = color;
        }

        public double CalculateVolume()
        {
            return Math.Round(Math.Pow(r, 2) * PI * H, 2);
        }

        public double CalculateArea()
        {
            return Math.Round(Math.Pow(r, 2) * PI * H, 2);
        }
    }
}
