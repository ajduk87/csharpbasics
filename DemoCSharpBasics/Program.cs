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

            for (int i = 0; i < soldShapes.Count(); i++) 
            {
                WriteItem(soldShapes[i]);
            }

            Console.WriteLine("Sold shapes elements except made from plastic are : " + System.Environment.NewLine);
            for (int i = 0; i < soldShapes.Count(); i++)
            {
                if (soldShapes[i].Material == Material.PLASTIC)
                    continue;
                WriteItem(soldShapes[i]);
            }

            Console.WriteLine("Sold shapes elements made from plastic are  : " + System.Environment.NewLine);
            for (int i = 0; i < soldShapes.Count(); i++)
            {
                if (soldShapes[i].Material != Material.PLASTIC)
                    break;
                WriteItem(soldShapes[i]);
            }

            Console.WriteLine("Sold shapes elements are [foreach] : " + System.Environment.NewLine);

            foreach (Shape soldShape in soldShapes)
            {
                WriteItem(soldShape);
            }

            Console.WriteLine("Sold shapes elements are [reverse order] : " + System.Environment.NewLine);
            for (int i = soldShapes.Count() - 1; i >= 0; i--)
            {
                WriteItem(soldShapes[i]);
            }


            Console.WriteLine("Sold spheres are : " + System.Environment.NewLine);
            for (int i = 0; i < soldShapes.Count(); i=i+3)
            {
                WriteItem(soldShapes[i]);
            }


            //Console.WriteLine("Sold shapes elements are [again with for] : " + System.Environment.NewLine);
            //for (int i = 0; i <= soldShapes.Count(); i++)
            //{
            //    WriteItem(soldShapes[i]);
            //}

            Console.ReadKey();
        }
    }
}
