﻿using System;

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
            double volume = 0;
            VolumeCalculator volumeCalculator = new VolumeCalculator();

            Console.WriteLine("Enter figure (cube, cylinder, sphere)");

            string figure = Console.ReadLine();

            volume = CubeVolume(figure, volumeCalculator);
            volume = CylinderVolume(figure, volumeCalculator);
            volume = SphereVolume(figure, volumeCalculator);

            Console.WriteLine("Volume is " + Math.Round(volume, 2));

            Console.ReadKey();
        }
    }
}
