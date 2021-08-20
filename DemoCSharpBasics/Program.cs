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

            string greetingEnglish = "Hello";
            string greetingUs = "Hello";
            string greetingSerbian = "Zdravo";

            Console.WriteLine("Second letter in string greeting is " + greetingEnglish[1]);

            //Comparing two strings
            // 1. way
            if (String.Compare(greetingEnglish, greetingUs) == 0)
            {
                Console.WriteLine(greetingEnglish + " and " + greetingUs + " are equal.");
            }
            else 
            {
                Console.WriteLine(greetingEnglish + " and " + greetingUs + " are not equal.");
            }

            if (String.Compare(greetingEnglish, greetingSerbian) == 0)
            {
                Console.WriteLine(greetingEnglish + " and " + greetingSerbian + " are equal.");
            }
            else
            {
                Console.WriteLine(greetingEnglish + " and " + greetingSerbian + " are not equal.");
            }

            //2.way
            if (greetingEnglish.Equals(greetingUs))
            {
                Console.WriteLine(greetingEnglish + " and " + greetingUs + " are equal.");
            }
            else
            {
                Console.WriteLine(greetingEnglish + " and " + greetingUs + " are not equal.");
            }

            if (greetingEnglish.Equals(greetingSerbian))
            {
                Console.WriteLine(greetingEnglish + " and " + greetingUs + " are equal.");
            }
            else
            {
                Console.WriteLine(greetingEnglish + " and " + greetingUs + " are not equal.");
            }

            //Contains string
            string partofUsGreeting = "Hell";
            if (greetingEnglish.Contains(partofUsGreeting))
            {
                Console.WriteLine("The sequence "+ partofUsGreeting + " was found "+ greetingEnglish + ".");
            }

            //Getting substring
            string partOfSerbianGreeting = greetingSerbian.Substring(1,5);
            Console.WriteLine("The part of serbian greeting is " + partOfSerbianGreeting);

            //Joining strings
            //1. way
            string[] greetings = new string[] { greetingEnglish, greetingUs, greetingSerbian };
            string allGreetings = String.Join(",", greetings);
            Console.WriteLine(allGreetings);

            //2. way
            string allGreetings2 = greetingEnglish + "," + greetingUs + "," + greetingSerbian;
            Console.WriteLine(allGreetings2);

            //3. way
            string allGreetings3 = $"{greetingEnglish},{greetingUs},{greetingSerbian}";
            Console.WriteLine(allGreetings3);

            //Trim string
            string greetingWithBlanks = "  Hello   ";
            Console.WriteLine("Trim string result is " + greetingWithBlanks.Trim());
            Console.WriteLine("TrimStart string result is " + greetingWithBlanks.TrimStart());
            Console.WriteLine("TrimEnd string result is " + greetingWithBlanks.TrimEnd());

            //Starts with
            if (greetingEnglish.StartsWith(partofUsGreeting)) 
            {
                Console.WriteLine(greetingEnglish + "starts with " + partofUsGreeting);
            }

            //Ends with
            if (greetingSerbian.StartsWith(partOfSerbianGreeting)) 
            {
                Console.WriteLine(greetingSerbian + "starts with " + partOfSerbianGreeting);
            }

            //string vs string builder
            string allGreetings4 = greetingEnglish + "," + greetingUs + "," + greetingSerbian;
            Console.WriteLine(allGreetings4);

            StringBuilder allGreetings5 = new StringBuilder(string.Empty);
            allGreetings5.AppendLine(greetingEnglish);
            allGreetings5.AppendLine(greetingUs);
            allGreetings5.AppendLine(greetingSerbian);
            Console.WriteLine(allGreetings5);

            Console.ReadKey();
        }
    }
}
