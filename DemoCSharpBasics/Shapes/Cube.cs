using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Shapes
{
    public class Cube : Shape
    {
        private double a;

        public static int NumberOfSoldCubes = 0;


        public static void IncrementNumberOfSoldCubes()
        {
            NumberOfSoldCubes++;
        }

        static Cube()
        {

            NumberOfSoldCubes = 0;
        }

        public Cube() : base("cube", "PLASTIC", new Price(0.0, "dollars", 2), "PETPLASTIC", "WHITE")
        {
            this.a = 0.0;
        }

        public Cube(string Name, double a, string Material, Price Price) :
                    base(Name, Material, Price, "PETPLASTIC", "WHITE")
        {

            this.a = a;
        }

        public Cube(string Name, double a, string Material, Price Price, string SpecificMaterial) :
                    base(Name, Material, Price, SpecificMaterial, "WHITE")
        {
            this.a = a;
        }

        public Cube(string Name,
                    double a,
                    string Material,
                    Price Price,
                    string SpecificMaterial,
                    string Color) :
                    base(Name, 
                         Material, 
                         Price, 
                         SpecificMaterial,
                         Color)
        {
            this.a = a;
        }
        public double CalculateVolume()
        {
            return Math.Round(Math.Pow(a, 3), 2);
        }

        public double CalculateArea()
        {
            return Math.Round(6 * Math.Pow(a, 2), 2);
        }
    }
}
