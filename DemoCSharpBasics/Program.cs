using System;

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
            double cubeVolume = 0;
            double cylinderVolume = 0;
            double sphereVolume = 0;
            VolumeCalculator volumeCalculator = new VolumeCalculator();

            Console.WriteLine("Enter figure (cube, cylinder, sphere)");

            string figure = Console.ReadLine();

            cubeVolume = CubeVolume(figure, volumeCalculator);
            cylinderVolume = CylinderVolume(figure, volumeCalculator);
            sphereVolume = SphereVolume(figure, volumeCalculator);

            Console.WriteLine("Cube volume is " + Math.Round(cubeVolume, 2));
            Console.WriteLine("Cylinder volume is " + Math.Round(cylinderVolume, 2));
            Console.WriteLine("Sphere volume is " + Math.Round(sphereVolume, 2));

            Console.ReadKey();
        }
    }
}
