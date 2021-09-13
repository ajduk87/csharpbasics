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

            Console.WriteLine("Sold shapes elements are [with old prices] : " + System.Environment.NewLine);

            foreach (Shape soldShape in soldShapes)
            {
                WriteItem(soldShape);
            }


            Console.WriteLine("Sold shapes elements are [with new prices] : " + System.Environment.NewLine);

            foreach (Shape soldShape in soldShapes)
            {
                soldShape.Price = 3 * soldShape.Price;
                WriteItem(soldShape);
            }


            Console.ReadKey();
        }
    }
}
