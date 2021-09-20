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
        private double PI;
        private double r;


        public static int NumberOfSoldSpheres = 0;

        public static void IncrementNumberOfSoldSpheres()
        {
            NumberOfSoldSpheres++;
        }

        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }
        public SpecificMaterial SpecificMaterial { get; set; }
        public Color Color { get; set; }


        public Sphere() : this("sphere",
                               0.0,
                               Material.PLASTIC,
                               0.0,
                               SpecificMaterial.PETPLASTIC,
                               Color.WHITE)
        {
            this.r = 0.0;
            PI = 3.14;

            this.Name = "sphere";
            this.Material = Material.PLASTIC;
            this.Price = 0.0;
            this.SpecificMaterial = SpecificMaterial.PETPLASTIC;
            this.Color = Color.WHITE;
        }

        public Sphere(string Name, 
                      double r, 
                      Material Material, 
                      double Price) : this(Name,
                                           r,
                                           Material,
                                           Price,
                                           SpecificMaterial.PETPLASTIC,
                                           Color.WHITE)
        {
            PI = 3.14;
        }

        public Sphere(string Name, 
                      double r, 
                      Material Material, 
                      double Price, 
                      SpecificMaterial SpecificMaterial) : this(Name,
                                                                r,
                                                                Material,
                                                                Price,
                                                                SpecificMaterial,
                                                                Color.WHITE)
        {
            PI = 3.14;
        }

        public Sphere(string Name, double r, Material Material, double Price, SpecificMaterial SpecificMaterial, Color Color)
        {
            this.r = r;
            PI = 3.14;

            this.Name = Name;
            this.Material = Material;
            this.Price = Price;
            this.SpecificMaterial = SpecificMaterial;
            this.Color = Color;
        }

        private double CalculateVolume()
        {
            return 4 * Math.Pow(r, 3) * PI / 3;
        }

        public  double Calculate() 
        {
            double volume = CalculateVolume();
            return Math.Round(volume, 2);
        }       
    }
}
