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

            Dictionary<string, Shape> shapesInStore = new Dictionary<string, Shape>();

            Sphere sphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6);
            Cube cube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8);
            Cylinder cylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10);

            //Add()
            shapesInStore.Add("sphere", sphere);
            shapesInStore.Add("cube", cube);
            shapesInStore.Add("cylinder", cylinder);

            Console.WriteLine("Add()" + System.Environment.NewLine);
            WriteDictionaryItems(shapesInStore);

            //write all shape names in store
            List<string> allShapeNames = shapesInStore.Keys.ToList();
            Console.WriteLine("All shape names in store are :");
            foreach (string name in allShapeNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("========================================");
            Console.WriteLine();

            //write all shapes in store
            List<Shape> allShapes = shapesInStore.Values.ToList();
            Console.WriteLine("All shapes in store are :");
            foreach (Shape shapeItem in allShapes)
            {
                WriteItem(shapeItem);
            }

            Console.WriteLine("========================================");
            Console.WriteLine();

            //get shape
            Shape shape = shapesInStore["sphere"];
            Console.WriteLine("Selected shape is :");

            WriteItem(shape);

            Console.WriteLine("========================================");
            Console.WriteLine();

            //try to get shape which is not exist in dictionary
            //shape = shapesInStore["cone"];

            //WriteItem(shape);

            //Console.WriteLine("========================================");
            //Console.WriteLine();

            //ContainsKey()
            bool isCubeInShapesInStore = shapesInStore.ContainsKey("cube");
            shape = isCubeInShapesInStore ? shapesInStore["cube"] : new Cube(name: "cube", a: 0, Material.PLASTIC, price: 0);

            Console.WriteLine("Selected shape is :");
            WriteItem(shape);

            Console.WriteLine("========================================");
            Console.WriteLine();

            bool isConeInShapesInStore = shapesInStore.ContainsKey("cone");
            shape = isConeInShapesInStore ? shapesInStore["cone"] : new Cone(name: "cone", r: 0, H: 0, Material.PLASTIC, price: 0);

            Console.WriteLine("Selected shape is :");
            WriteItem(shape);

            Console.WriteLine("========================================");
            Console.WriteLine();

            //TryGetValue()
            isCubeInShapesInStore = shapesInStore.TryGetValue("sphere", out shape);
            if (isCubeInShapesInStore) 
            {
                Console.WriteLine("Selected shape is :");
                WriteItem(shape);

                Console.WriteLine("========================================");
                Console.WriteLine();
            }

            //Count()
            int count = shapesInStore.Count();

            Console.WriteLine("Count of shapes in store is :" + count);
            Console.WriteLine();

            count = shapesInStore.Count(shape => shape.Value.Price > 7.0);

            Console.WriteLine("Count of shapes in store more expensive than 7.0 is :" + count);
            Console.WriteLine();

            //Remove()

            Console.WriteLine("Dictionary content before removing cube is :");
            WriteDictionaryItems(shapesInStore);

            shapesInStore.Remove("cube");

            Console.WriteLine("Dictionary content after removing cube is :");
            WriteDictionaryItems(shapesInStore);

            //Clear()
            shapesInStore.Clear();

            Console.WriteLine("Dictionary content after using clear method is :");
            WriteDictionaryItems(shapesInStore);


            Console.ReadKey();
        }
    }
}
