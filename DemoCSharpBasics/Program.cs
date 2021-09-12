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
            Sphere plastricSphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6);
            Cube plasticCube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8);
            Cylinder plasticCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10);

            Sphere woodSphere = new Sphere(name: "sphere", r: 2, Material.WOOD, price: 16);
            Cube woodCube = new Cube(name: "cube", a: 2, Material.WOOD, price: 18);
            Cylinder woodCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.WOOD, price: 20);

            Sphere metalSphere = new Sphere(name: "sphere", r: 2, Material.METAL, price: 26);
            Cube metalCube = new Cube(name: "cube", a: 2, Material.METAL, price: 30);
            Cylinder metalCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.METAL, price: 32);

            soldShapes.Add(plastricSphere);
            soldShapes.Add(plasticCube);
            soldShapes.Add(plasticCylinder);

            soldShapes.Add(woodSphere);
            soldShapes.Add(woodCube);
            soldShapes.Add(woodCylinder);

            soldShapes.Add(metalSphere);
            soldShapes.Add(metalCube);
            soldShapes.Add(metalCylinder);

            Console.WriteLine("Sold shapes elements are : " + System.Environment.NewLine);
            WriteListItems(soldShapes);

            //Initalization
            Console.WriteLine("Sold shapes elements made from plastic are : " + System.Environment.NewLine);

            int indexOfCurrentElement = 0;

            do
            {
                WriteItem(soldShapes[indexOfCurrentElement]);
                indexOfCurrentElement++;
            } while (soldShapes[indexOfCurrentElement].Material == Material.PLASTIC);

            //Initalization
            Console.WriteLine("Sold shapes elements made from glass are : " + System.Environment.NewLine);

            indexOfCurrentElement = 0;
            if (soldShapes.Count(soldShape => soldShape.Material == Material.GLASS) > 0)
            {
                do
                {
                    WriteItem(soldShapes[indexOfCurrentElement]);
                    indexOfCurrentElement++;
                } while (soldShapes[indexOfCurrentElement].Material == Material.GLASS);
            }

            Console.ReadKey();
        }
    }
}
