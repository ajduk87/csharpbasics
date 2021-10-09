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

        public Sphere() : base("sphere", "PLASTIC", 0.0, "PETPLASTIC", "WHITE")
        {
        }

        public Sphere(string Name, double r, string Material, double Price) :
                     base(Name, Material, Price, "PETPLASTIC", "WHITE")
        {
            this.r = r;
        }


        public Sphere(string Name, double r, string Material, double Price, string SpecificMaterial) :
            base(Name, Material, Price, SpecificMaterial, "WHITE")
        {
            this.r = r;
        }

        public Sphere(string Name, 
                      double r, 
                      string Material, 
                      double Price, 
                      string SpecificMaterial, 
                      string Color) :

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
