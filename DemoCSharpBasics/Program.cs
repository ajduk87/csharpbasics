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

            //Array with reference types example
            Shape[] shapes = new Shape[4];
            shapes[0] = new Cube(name: "cube", a: 2);
            shapes[1] = new Cylinder(name: "cylinder", r: 2, H: 10);
            shapes[2] = new Sphere(name: "sphere", r: 6);
            ShapeFinder shapeFinder = new ShapeFinder(shapes);


            //shapes[3] = new Cone(name: "cone", r: 2, H:10);(compile error)
            //shapes[8] = new Sphere(name: "sphere", r: 6);//(runtime error)

            /********************************************/
            // a lot of code lines




            // a lot of code lines


            // a lot of code lines

            // a lot of code lines







            // a lot of code lines



            // a lot of code lines
            /********************************************/

            //we want to find sphere from shapeFinder.
            //How?
            //we will use indexers in c#.
            Shape sphere = shapeFinder["sphere"];

            //Much better ?
            //i think yes.
            //No magic number , we wanted sphere from shapeFinder and only wrote sphere
            //AND AGAIN => AVOIDING MAGIC NUMBERS !!!!!!!!!!!!!!!!!!!!!!!

            Console.ReadKey();
        }
    }
}
