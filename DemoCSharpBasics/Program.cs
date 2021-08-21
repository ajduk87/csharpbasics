using System;
using System.Text;

namespace DemoCSharpBasics
{
    public static class Program
    {

        private static double CubeVolume(string figure, VolumeCalculator volumeCalculator) 
        {
            if (!figure.Equals("cube")) return 0;

            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            return volumeCalculator.CalculateCubeVolume(a);

        }

        private static double CylinderVolume(string figure, VolumeCalculator volumeCalculator)
        {
            if (!figure.Equals("cylinder")) return 0;

            Console.WriteLine("Enter r");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter H");
            double H = Convert.ToDouble(Console.ReadLine());
            return volumeCalculator.CalculateCylinderVolume(r, H);

        }

        private static double SphereVolume(string figure, VolumeCalculator volumeCalculator)
        {
            if (!figure.Equals("sphere")) return 0;

            Console.WriteLine("Enter r");
            double r = Convert.ToDouble(Console.ReadLine());
            return volumeCalculator.CalculateSphereVolume(r);

        }

        public static void Main(string[] args)
        {

            //Nullable types
            int? sideOfCude = null;
            //int a = null;(compiler error)
            int defaultSideOfCube = 2;
            Cube cube = null;

            if (sideOfCude.HasValue)
            {
                cube = new Cube(sideOfCude.Value);
            }
            else 
            {
                cube = new Cube(defaultSideOfCube);
            }
            Console.WriteLine("Cube volume is " + cube.Calculate());

            cube = null;
            cube = sideOfCude.HasValue ? new Cube(sideOfCude.Value) : 
                                         new Cube(defaultSideOfCube);
            Console.WriteLine("Cube volume again is " + cube.Calculate());

            cube = null;
            sideOfCude = sideOfCude ?? defaultSideOfCube;
            cube = new Cube(sideOfCude.Value);
      
            Console.WriteLine("Cube volume again is " + cube.Calculate());


            Console.ReadKey();
        }
    }
}
