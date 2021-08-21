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
            //Assignment operator
            int firstIntegernumber = 10;
            int secondIntegernumber = 6;
            long firstLongNumber = 10;
            long secondLongNumber = 6;
            double firstRealNumber = 10.0;
            double secondRealNumber = 6.0;

            //Comparison operators
            bool result = firstIntegernumber == firstLongNumber;
            Console.WriteLine("Does firstIntegernumber equal to firstLongNumber? " + result);

            result = firstIntegernumber == firstRealNumber;
            Console.WriteLine("Does firstIntegernumber equal to firstRealNumber? " + result);

            result = firstIntegernumber != firstLongNumber;
            Console.WriteLine("Does NOT firstIntegernumber equal to firstLongNumber? " + result);

            result = firstIntegernumber != firstRealNumber;
            Console.WriteLine("Does NOT firstIntegernumber equal to firstRealNumber? " + result);

            result = secondIntegernumber < firstIntegernumber;
            Console.WriteLine("Does secondIntegernumber less than firstIntegernumber? " + result);

            result = secondIntegernumber <= firstIntegernumber;
            Console.WriteLine("Does secondIntegernumber less or equal than firstIntegernumber? " + result);

            result = firstIntegernumber > secondIntegernumber;
            Console.WriteLine("Does firstIntegernumber greater than secondIntegernumber? " + result);

            result = firstIntegernumber >= secondIntegernumber;
            Console.WriteLine("Does firstIntegernumber greater or equal than secondIntegernumber? " + result);

            //Conditional operators
            if (firstIntegernumber == firstLongNumber && firstIntegernumber == firstRealNumber) 
            {
                Console.WriteLine("Does firstIntegernumber equal to firstLongNumber AND firstIntegernumber equal to firstRealNumber? " + result);
            }

            if (firstIntegernumber != firstLongNumber || firstIntegernumber == firstRealNumber)
            {
                Console.WriteLine("Does NOT firstIntegernumber equal to firstLongNumber OR firstIntegernumber equal to firstRealNumber? " + result);
            }

            //Ternary operator
            //firstIntegernumber == firstRealNumber ? Console.WriteLine("FirstIntegernumber equals to firstRealNumber."):
            //                                        Console.WriteLine("FirstIntegernumber does not equal to firstRealNumber.");
            string resultMessage = firstIntegernumber == firstRealNumber ? "FirstIntegernumber equals to firstRealNumber." :
                                                                           "FirstIntegernumber does not equal to firstRealNumber.";
            Console.WriteLine(resultMessage);

            //Null Coalesing operators
            Cube defaultCube = new Cube(2);
            Cube cube = null;
            cube = cube ?? defaultCube;
            Console.WriteLine("Cube volume is " + cube.Calculate());

            cube = null;
            cube ??= defaultCube;
            Console.WriteLine("Cube volume again is " + cube.Calculate());

            Console.ReadKey();
        }
    }
}
