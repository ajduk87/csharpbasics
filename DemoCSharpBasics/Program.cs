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

        private static void WriteDictionaryItems(Dictionary<string, Shape> shapesInStore) 
        {
            foreach (KeyValuePair<string, Shape> shapeInStore in shapesInStore)
            {
                Console.WriteLine($"KEY: {shapeInStore.Key}  VALUE: name: {shapeInStore.Value.Name}  kind: {shapeInStore.Value.Material}  volume: {shapeInStore.Value.Calculate()}");
            }
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        private static void WriteItem(Shape shape)
        {
            Console.WriteLine($"name: {shape.Name}  kind: {shape.Material}  volume: {shape.Calculate()}  price:{shape.Price}");
        }

        public static void Main(string[] args)
        {

            Dictionary<string, Shape> historyOfSoldShapesInStore = new Dictionary<string, Shape>();
            List<Shape> soldShapesToday = new List<Shape>();

            //For date 1 September 2021
            Sphere sphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6, soldAmount: 25);
            soldShapesToday.Add(sphere);
            Cube cube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8, soldAmount: 14);
            soldShapesToday.Add(cube);
            Cylinder cylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10, soldAmount: 3);
            soldShapesToday.Add(cylinder);

            foreach (Shape soldShape in soldShapesToday)
            {
                historyOfSoldShapesInStore.Add($"20210901{soldShape.Name}", soldShape);
            }
            soldShapesToday.Clear();

            //For date 2 September 2021
            sphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6, soldAmount: 38);
            soldShapesToday.Add(sphere);
            cube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8, soldAmount: 12);
            soldShapesToday.Add(cube);
            cylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10, soldAmount: 9);
            soldShapesToday.Add(cylinder);

            foreach (Shape soldShape in soldShapesToday)
            {
                historyOfSoldShapesInStore.Add($"20210902{soldShape.Name}", soldShape);
            }
            soldShapesToday.Clear();

            //For date 3 September 2021
            sphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6, soldAmount: 12);
            soldShapesToday.Add(sphere);
            cube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8, soldAmount: 22);
            soldShapesToday.Add(cube);
            cylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10, soldAmount: 13);
            soldShapesToday.Add(cylinder);

            foreach (Shape soldShape in soldShapesToday)
            {
                historyOfSoldShapesInStore.Add($"20210903{soldShape.Name}", soldShape);
            }
            soldShapesToday.Clear();

            //how many did cubes sell at the 2. September 2021
            Shape soldShapes = historyOfSoldShapesInStore["20210902sphere"];
            Console.WriteLine($"At the 2. september 2021 the sphere was sold - {soldShapes.SoldAmount}.");

            Console.ReadKey();
        }
    }
}
