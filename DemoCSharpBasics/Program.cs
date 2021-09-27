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

        private static void WriteListItems(List<Shape> soldShapes) 
        {
            foreach (Shape soldShape in soldShapes)
            {
                Console.WriteLine($"name: {soldShape.Name}  kind: {soldShape.Material}  volume: {soldShape.Calculate()}  price:{soldShape.Price}");
            }
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        private static void WriteItem(Shape soldShape)
        {
            Console.WriteLine($"name: {soldShape.Name}  kind: {soldShape.Material}  volume: {soldShape.Calculate()}  price:{soldShape.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

            List<Shape> soldShapes = new List<Shape>();
            ShapeStore shapeStore = new ShapeStore(soldShapes);
            Sphere plastricSphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6, orderAmount: 35);
            Cube plasticCube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8, orderAmount: 23);
            Cylinder plasticCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10, orderAmount: 45);

            Sphere woodSphere = new Sphere(name: "sphere", r: 2, Material.WOOD, price: 16, orderAmount: 10);
            Cube woodCube = new Cube(name: "cube", a: 2, Material.WOOD, price: 18, orderAmount: 16);
            Cylinder woodCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.WOOD, price: 20, orderAmount: 18);

            Sphere metalSphere = new Sphere(name: "sphere", r: 2, Material.METAL, price: 26, orderAmount: 25);
            Cube metalCube = new Cube(name: "cube", a: 2, Material.METAL, price: 30, orderAmount: 19);
            Cylinder metalCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.METAL, price: 32, orderAmount: 14);

            soldShapes.Add(plastricSphere);
            Shape.IncrementNumberOfSoldShapes();
            soldShapes.Add(plasticCube);
            Shape.IncrementNumberOfSoldShapes();
            soldShapes.Add(plasticCylinder);
            Shape.IncrementNumberOfSoldShapes();

            soldShapes.Add(woodSphere);
            Shape.IncrementNumberOfSoldShapes();
            soldShapes.Add(woodCube);
            Shape.IncrementNumberOfSoldShapes();
            soldShapes.Add(woodCylinder);
            Shape.IncrementNumberOfSoldShapes();

            soldShapes.Add(metalSphere);
            Shape.IncrementNumberOfSoldShapes();
            soldShapes.Add(metalCube);
            Shape.IncrementNumberOfSoldShapes();
            soldShapes.Add(metalCylinder);
            Shape.IncrementNumberOfSoldShapes();

            Console.WriteLine("Sold shapes elements are : " + System.Environment.NewLine);

            foreach (Shape soldShape in soldShapes)
            {
                string soldMessage = soldShape.ToString();
                Console.WriteLine(soldMessage + System.Environment.NewLine);
                double volume = soldShape.Calculate();
                Console.WriteLine("Volume is : " + volume + System.Environment.NewLine);
            }

            Console.WriteLine("Number of sold shapes is : " + Shape.NumberOfSoldShapes);


            Console.ReadKey();
        }
    }
}
