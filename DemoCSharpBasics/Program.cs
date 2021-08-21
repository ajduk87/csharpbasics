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

            //Array with value types example
            string[] namesOfChessPieces = new string[6];
            namesOfChessPieces[0] = "king";
            namesOfChessPieces[1] = "queen";
            namesOfChessPieces[2] = "rook";
            namesOfChessPieces[3] = "knight";
            namesOfChessPieces[4] = "bishop";
            namesOfChessPieces[5] = "pawn";

            //namesOfChessPieces[5] = 10;(compile error)
            //namesOfChessPieces[8] = "king";(runtime error)


            Console.ReadKey();
        }
    }
}
