using System;

namespace DemoCSharpBasics
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            double volume = 0;
            VolumeCalculator volumeCalculator = new VolumeCalculator();

            Console.WriteLine("Enter figure (cube, cylinder, sphere)");

            string figure = Console.ReadLine();

            if (figure.Equals("cube"))
            {
                Console.WriteLine("Enter a");
                double a = Convert.ToDouble(Console.ReadLine());
                volume = volumeCalculator.CalculateCubeVolume(a);
                Console.WriteLine("Cube volume is " + Math.Round(volume, 2));
            }

            if (figure.Equals("cylinder"))
            {
                Console.WriteLine("Enter r");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter H");
                double H = Convert.ToDouble(Console.ReadLine());
                volume = volumeCalculator.CalculateCylinderVolume(r, H);
                Console.WriteLine("Cylinder volume is " + Math.Round(volume, 2));
            }

            if (figure.Equals("sphere"))
            {
                Console.WriteLine("Enter r");
                double r = Convert.ToDouble(Console.ReadLine());
                volume = volumeCalculator.CalculateSphereVolume(r);
                Console.WriteLine("Sphere volume is " + Math.Round(volume, 2));
            }

            Console.ReadKey();
        }
    }
}
