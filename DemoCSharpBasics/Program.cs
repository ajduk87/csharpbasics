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
            int firstIntegerNumber = 10;
            int secondIntegerNumber = 6;
            long firstLongNumber = 10;
            long secondLongNumber = 6;
            double firstRealNumber = 10.0;
            double secondRealNumber = 6.0;

            //Comparison operators
            bool result = firstIntegerNumber == firstLongNumber;
            Console.WriteLine("Does firstIntegernumber equal to firstLongNumber? " + result);

            result = firstIntegerNumber == firstRealNumber;
            Console.WriteLine("Does firstIntegernumber equal to firstRealNumber? " + result);

            result = firstIntegerNumber != firstLongNumber;
            Console.WriteLine("Does NOT firstIntegernumber equal to firstLongNumber? " + result);

            result = firstIntegerNumber != firstRealNumber;
            Console.WriteLine("Does NOT firstIntegernumber equal to firstRealNumber? " + result);

            result = secondIntegerNumber < firstIntegerNumber;
            Console.WriteLine("Does secondIntegernumber less than firstIntegernumber? " + result);

            result = secondIntegerNumber <= firstIntegerNumber;
            Console.WriteLine("Does secondIntegernumber less or equal than firstIntegernumber? " + result);

            result = firstIntegerNumber > secondIntegerNumber;
            Console.WriteLine("Does firstIntegernumber greater than secondIntegernumber? " + result);

            result = firstIntegerNumber >= secondIntegerNumber;
            Console.WriteLine("Does firstIntegernumber greater or equal than secondIntegernumber? " + result);

            //Conditional operators
            if (firstIntegerNumber == firstLongNumber && firstIntegerNumber == firstRealNumber) 
            {
                Console.WriteLine("Does firstIntegernumber equal to firstLongNumber AND firstIntegernumber equal to firstRealNumber? " + result);
            }

            if (firstIntegerNumber != firstLongNumber || firstIntegerNumber == firstRealNumber)
            {
                Console.WriteLine("Does NOT firstIntegernumber equal to firstLongNumber OR firstIntegernumber equal to firstRealNumber? " + result);
            }

            //Ternary operator
           
            //if (firstIntegernumber == firstRealNumber)
            //{
            //    string resultMessage = "FirstIntegernumber equals to firstRealNumber.";
            //}
            //else 
            //{
            //    string resultMessage = "FirstIntegernumber does not equal to firstRealNumber.";
            //}
            
            string resultMessage = firstIntegerNumber == firstRealNumber ? "FirstIntegernumber equals to firstRealNumber." :
                                                                           "FirstIntegernumber does not equal to firstRealNumber.";

            //firstIntegernumber == firstRealNumber ? Console.WriteLine("FirstIntegernumber equals to firstRealNumber."):
            //                                        Console.WriteLine("FirstIntegernumber does not equal to firstRealNumber.");

            Console.WriteLine(resultMessage);

            //Null Coalesing operators
            Cube defaultCube = new Cube(2);
            Cube cube = null;

            //if (cube == null)
            //{
            //    cube = defaultCube;
            //}
            cube = cube ?? defaultCube;
            Console.WriteLine("Cube volume is " + cube.Calculate());

            cube = null;
            cube ??= defaultCube;
            Console.WriteLine("Cube volume again is " + cube.Calculate());

            //Arithmetic operators
            //[+]
            int arithmeticIntegerResult = firstIntegerNumber + secondIntegerNumber;
            Console.WriteLine("firstIntegernumber + secondIntegernumber = " + arithmeticIntegerResult);
            long arithmeticLongResult = firstLongNumber + secondLongNumber;
            Console.WriteLine("firstLongNumber + secondLongNumber = " + arithmeticLongResult);
            double arithmeticRealResult = firstRealNumber + secondRealNumber;
            Console.WriteLine("firstRealNumber + secondRealNumber = " + arithmeticRealResult);

            //[-]
            arithmeticIntegerResult = firstIntegerNumber - secondIntegerNumber;
            Console.WriteLine("firstIntegernumber - secondIntegernumber = " + arithmeticIntegerResult);
            arithmeticLongResult = firstLongNumber - secondLongNumber;
            Console.WriteLine("firstLongNumber - secondLongNumber = " + arithmeticLongResult);
            arithmeticRealResult = firstRealNumber - secondRealNumber;
            Console.WriteLine("firstRealNumber - secondRealNumber = " + arithmeticRealResult);

            //[*]
            arithmeticIntegerResult = firstIntegerNumber * secondIntegerNumber;
            Console.WriteLine("firstIntegernumber * secondIntegernumber = " + arithmeticIntegerResult);
            arithmeticLongResult = firstLongNumber * secondLongNumber;
            Console.WriteLine("firstLongNumber * secondLongNumber = " + arithmeticLongResult);
            arithmeticRealResult = firstRealNumber * secondRealNumber;
            Console.WriteLine("firstRealNumber * secondRealNumber = " + arithmeticRealResult);

            //[/]
            arithmeticIntegerResult = firstIntegerNumber / secondIntegerNumber;
            Console.WriteLine("firstIntegernumber / secondIntegernumber = " + arithmeticIntegerResult);
            arithmeticLongResult = firstLongNumber / secondLongNumber;
            Console.WriteLine("firstLongNumber / secondLongNumber = " + arithmeticLongResult);
            arithmeticRealResult = firstRealNumber / secondRealNumber;
            Console.WriteLine("firstRealNumber / secondRealNumber = " + arithmeticRealResult);

            //[%]
            arithmeticIntegerResult = firstIntegerNumber % secondIntegerNumber;
            Console.WriteLine("firstIntegernumber % secondIntegernumber = " + arithmeticIntegerResult);
            arithmeticLongResult = firstLongNumber % secondLongNumber;
            Console.WriteLine("firstLongNumber % secondLongNumber = " + arithmeticLongResult);
            arithmeticRealResult = firstRealNumber % secondRealNumber;
            Console.WriteLine("firstRealNumber % secondRealNumber = " + arithmeticRealResult);

            Console.ReadKey();
        }
    }
}
