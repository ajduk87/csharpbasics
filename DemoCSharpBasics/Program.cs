using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using DemoCSharpBasics.Orders;

namespace DemoCSharpBasics
{
    public static class Program
    {
        private static void WriteShape(Shape shape)
        {
            Console.WriteLine($"name: {shape.Name}  " +
                              $"material: {shape.Material}  " +
                              $"price:{shape.Price.Print()}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

            Price price = new Price(10.679, "dollars", 2);

            Cube woodCube = new Cube(Name: "cube", 
                                     a: 2,
                                     Material: "WOOD", 
                                     Price: price);

            price = new Price();
            price.Value = 15.67;
            price.Currency = "dollars";


            Sphere woodSphere = new Sphere(Name: "sphere", 
                                           r: 2, 
                                           Material: "WOOD", 
                                           Price: price);

            price = new Price 
            {
                Value = 19.3456,
                Currency = "dollars"
            };

            Cylinder woodCylinder = new Cylinder(Name: "cylinder", 
                                                 r: 2, 
                                                 H: 4, 
                                                 Material: "WOOD", 
                                                 Price: price);

            List<Shape> shapes = new List<Shape> 
            {
                woodCube,
                woodSphere,
                woodCylinder
            };

            foreach (Shape shape in shapes)
            {
                WriteShape(shape);
            }


            Console.ReadKey();
        }
    }
}
