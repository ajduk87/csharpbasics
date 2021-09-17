using System;
using System.Collections.Generic;
using DemoCSharpBasics.Shapes;
using DemoCSharpBasics.Sugar;

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
            double totalShapePrice = 0.0;
            List<Shape> soldShapes = new List<Shape>();
            ShapeStore shapeStore = new ShapeStore(soldShapes);
            Sphere plastricSphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6, amount: 7);
            Cube plasticCube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8, amount: 4);
            Cylinder plasticCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10, amount: 6);

            Sphere woodSphere = new Sphere(name: "sphere", r: 2, Material.WOOD, price: 16, amount: 9);
            Cube woodCube = new Cube(name: "cube", a: 2, Material.WOOD, price: 18, amount: 12);
            Cylinder woodCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.WOOD, price: 20, amount: 2);

            Sphere metalSphere = new Sphere(name: "sphere", r: 2, Material.METAL, price: 26, amount: 7);
            Cube metalCube = new Cube(name: "cube", a: 2, Material.METAL, price: 30, amount: 8);
            Cylinder metalCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.METAL, price: 32, amount: 13);

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
                totalShapePrice += soldShape.Price * soldShape.Amount;
            }

            Console.WriteLine("Number of sold shapes is : " + Shape.NumberOfSoldShapes);
            Console.WriteLine("Total value of sold shapes is : " + totalShapePrice + Shape.NumberOfSoldShapes);

            double totalSugarPrice = 0.0;
            List<SugarItem> soldSugar = new List<SugarItem>();
            Cube sugarCube = new Cube(name: "white sugar", price: 23.0, amount: 3);
            Bag sugarBag = new Bag(name: "yellow sugar", price: 12.0, amount: 8);

            soldSugar.Add(sugarCube);
            soldSugar.Add(sugarBag);

            foreach (SugarItem sugarItem in soldSugar) 
            {
                totalSugarPrice += sugarItem.CalculateItemValue();
            }

            Console.WriteLine("Total value of sold sugar is : " + totalSugarPrice + Shape.NumberOfSoldShapes);

            Console.ReadKey();
        }
    }
}
