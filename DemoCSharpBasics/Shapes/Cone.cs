using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Shapes
{
    public class Cone : Shape
    {
        private static double PI = 3.14;
        private double r;
        private double H;
        private double l;


        public Cone(string Name,
                   double r,
                   double H,
                   Material Material,
                   double Price) :
                       base(Name,
                            Material,
                            Price,
                            SpecificMaterial.PETPLASTIC,
                            Color.WHITE)
        {
            this.r = r;
            this.H = H;
            this.l = Math.Sqrt(Math.Pow(r, 2) + Math.Pow(H, 2));
        }


        public Cone(string Name, 
                    double r, 
                    double H, 
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
            this.H = H;
            this.l = Math.Sqrt(Math.Pow(r, 2) + Math.Pow(H, 2));
        }

        public double CalculateVolume()
        {
            return Math.Round(Math.Pow(r, 2) * PI * H / 3, 2);
        }

        public double CalculateArea()
        {
            return Math.Round(PI * r * (r + l), 2);
        }
    }
}
