using DemoCSharpBasics.Orders;
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
            NumberOfSoldSpheres = 0;
            PI = 3.14;
        }

        public Sphere() : base("sphere", Material.PLASTIC, 0.0, SpecificMaterial.PETPLASTIC, Color.WHITE)
        {
        }

        public Sphere(string Name, double r, Material Material, double Price) :
                     base(Name, Material, Price, SpecificMaterial.PETPLASTIC, Color.WHITE)
        {
            this.r = r;
        }


        public Sphere(string Name, double r, Material Material, double Price, SpecificMaterial SpecificMaterial) :
            base(Name, Material, Price, SpecificMaterial.PETPLASTIC, Color.WHITE)
        {
            this.r = r;
        }

        public Sphere(string Name, 
                      double r, 
                      Material Material, 
                      double Price, 
                      SpecificMaterial SpecificMaterial, 
                      Color Color) :

                      base(Name, 
                           Material, 
                           Price, 
                           SpecificMaterial, 
                           Color)
        {
            this.r = r;
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
