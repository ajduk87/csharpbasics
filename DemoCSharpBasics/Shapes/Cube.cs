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
            Console.WriteLine("Static cube constructor is called.");

            NumberOfSoldCubes = 0;
        }

        public Cube() : base("cube", Material.PLASTIC, 0.0, SpecificMaterial.PETPLASTIC, Color.WHITE, 0)
        {
            this.a = 0.0;
        }

        public Cube(string Name, double a, Material Material, double Price) :
                    base(Name, Material, Price, SpecificMaterial.PETPLASTIC, Color.WHITE, 0)
        {
            Console.WriteLine("Instance cube constructor is called.");

            this.a = a;
        }

        public Cube(string Name, double a, Material Material, double Price, int OrderAmount) :
                    base(Name, Material, Price, SpecificMaterial.PETPLASTIC, Color.WHITE, OrderAmount)
        {
            Console.WriteLine("Instance cube (derived) constructor is called.");

            this.a = a;
        }

        public Cube(string Name, double a, Material Material, double Price, SpecificMaterial SpecificMaterial) :
                    base(Name, Material, Price, SpecificMaterial, Color.WHITE, 0)
        {
            this.a = a;
        }

        public Cube(string Name,
                    double a,
                    Material Material,
                    double Price,
                    SpecificMaterial SpecificMaterial,
                    Color Color,
                    int OrderAmount) :
                    base(Name, 
                         Material, 
                         Price, 
                         SpecificMaterial,
                         Color,
                         OrderAmount)
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
