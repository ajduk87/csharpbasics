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
            //It orders:
            //23 plastric sphere
            //12 wood spheres
            //25 plastric cylinder
            //8  wood cylinder
            //11 plactic cubes
            //29 wood cubes
            Sphere plastricSphere = new Sphere(Name: "sphere", r: 2, Material.PLASTIC, Price: 6,OrderAmount: 23);
            Sphere woodSphere = new Sphere(Name: "sphere", r: 2, Material.WOOD, Price: 18, OrderAmount: 12);

            Cylinder plastricCylinder = new Cylinder(Name: "cylinder", r: 2, H:3, Material.PLASTIC, Price: 10, OrderAmount: 25);
            Cylinder woodCylinder = new Cylinder(Name: "cylinder", r: 2, H:4, Material.WOOD, Price: 20, OrderAmount: 8);

            Cube plastricCube = new Cube(Name: "cube", a: 3, Material.PLASTIC, Price: 10, OrderAmount: 25);
            Cube woodCube = new Cube(Name: "cube", a: 2, Material.WOOD, Price: 20, OrderAmount: 8);

            List<Shape> shapeOrderItems = new List<Shape>();
            shapeOrderItems.Add(plastricSphere);
            shapeOrderItems.Add(woodSphere);
            shapeOrderItems.Add(plastricCylinder);
            shapeOrderItems.Add(woodCylinder);
            shapeOrderItems.Add(plastricCube);
            shapeOrderItems.Add(woodCube);

            double yourbill = 0.0;

            foreach (Shape shapeOrderItem in shapeOrderItems)
            {
                yourbill = yourbill + shapeOrderItem.CalculateOrderItemValue();
            }

            Console.WriteLine("Your bill is: " + yourbill);

            Console.ReadKey();
        }
    }
}
