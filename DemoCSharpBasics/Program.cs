using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoCSharpBasics
{
    public static class Program
    {
        private static void WriteSphere(Sphere soldSphere)
        {
            Console.WriteLine($"name: {soldSphere.Name}  " +
                              $"kind: {soldSphere.Material}  " +
                              $"volume: {soldSphere.CalculateVolume()} " +
                              $"area: {soldSphere.CalculateArea()}  " +
                              $"price:{soldSphere.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        private static void WriteCylinder(Cylinder soldCylinder)
        {
            Console.WriteLine($"name: {soldCylinder.Name}  " +
                              $"kind: {soldCylinder.Material}  " +
                              $"volume: {soldCylinder.CalculateVolume()} " +
                              $"area: {soldCylinder.CalculateArea()}  " +
                              $"price:{soldCylinder.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

          

            Sphere plastricSphere = new Sphere(Name: "sphere", r: 2, Material.PLASTIC, Price: 6);          


            Console.ReadKey();
        }
    }
}
