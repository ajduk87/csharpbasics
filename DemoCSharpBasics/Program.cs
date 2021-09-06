using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
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
            Cone cone = new Cone(name: "cone", r: 2, H: 3);

            //Add()
            soldShapes.Add(plastricSphere);
            soldShapes.Add(plasticCube);
            soldShapes.Add(plasticCylinder);
            //soldShapes.Add(cone);

            Console.WriteLine("Add()" + System.Environment.NewLine);
            WriteListItems(soldShapes);

            //AddRange()
            Sphere woodSphere = new Sphere(name: "sphere", r: 2, Material.WOOD, price: 16);
            Cube woodCube = new Cube(name: "cube", a: 2, Material.WOOD, price: 18);
            Cylinder woodCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.WOOD, price: 20);
            List<Shape> soldWoodShapes = new List<Shape>();
            soldWoodShapes.Add(woodSphere);
            soldWoodShapes.Add(woodCube);
            soldWoodShapes.Add(woodCylinder);

            soldShapes.AddRange(soldWoodShapes);

            Console.WriteLine("AddRange(soldWoodShapes)" + System.Environment.NewLine);
            WriteListItems(soldShapes);            

            //Insert()
            Sphere metalSphere = new Sphere(name: "sphere", r: 2, Material.METAL, price: 26);
            soldShapes.Insert(0, metalSphere);

            Console.WriteLine("Insert(0, metalSphere)" + System.Environment.NewLine);
            WriteListItems(soldShapes);

            //InsertRange()
            Cube metalCube = new Cube(name: "cube", a: 2, Material.METAL, price: 30);
            Cylinder metalCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.METAL, price: 32);
            List<Shape> soldMetalShapes = new List<Shape>();
            soldMetalShapes.Add(metalCube);
            soldMetalShapes.Add(metalCylinder);
            soldShapes.InsertRange(0, soldMetalShapes);

            Console.WriteLine("InsertRange(0, soldMetalShapes)" + System.Environment.NewLine);
            WriteListItems(soldShapes);

            //GetRange()
            List<Shape> firstThreeSoldShapes = soldShapes.GetRange(0, 3);

            Console.WriteLine("firstThreeSoldShapes = GetRange(0, 3)" + System.Environment.NewLine);
            WriteListItems(firstThreeSoldShapes);

            //Find()

            Shape firstSoldWoodShape = soldShapes.Find(soldShape => soldShape.Material == Material.WOOD);
            
            Console.WriteLine("firstSoldWoodShape = soldShapes.Find(soldShape => soldShape.Material == Material.WOOD)" + System.Environment.NewLine);
            WriteItem(firstSoldWoodShape);

            //FindLast()
            Shape lastSoldWoodShape = soldShapes.FindLast(soldShape => soldShape.Material == Material.WOOD);

            Console.WriteLine("lastSoldWoodShape = soldShapes.FindLast(soldShape => soldShape.Material == Material.WOOD)" + System.Environment.NewLine);
            WriteItem(lastSoldWoodShape);

            //FindAll()
            List<Shape> allSoldWoodShapes = soldShapes.FindAll(soldShape => soldShape.Material == Material.WOOD);

            Console.WriteLine("allSoldWoodShapes = soldShapes.FindAll(soldShape => soldShape.Material == Material.WOOD)" + System.Environment.NewLine);
            WriteListItems(allSoldWoodShapes);

            //FindIndex()
            int firstSoldWoodShapeIndexInList = soldShapes.FindIndex(soldShape => soldShape.Material == Material.WOOD);

            Console.WriteLine("First sold wood shape index in list is " + firstSoldWoodShapeIndexInList + System.Environment.NewLine);

            //FindLastIndex()
            int lastSoldWoodShapeIndexInList = soldShapes.FindLastIndex(soldShape => soldShape.Material == Material.WOOD);

            Console.WriteLine("Last sold wood shape index in list is " + lastSoldWoodShapeIndexInList + System.Environment.NewLine);

            //IndexOf()
            firstSoldWoodShapeIndexInList = soldShapes.IndexOf(firstSoldWoodShape);

            Console.WriteLine("[soldShapes.IndexOf(firstSoldWoodShape)]");
            Console.WriteLine("First sold wood shape index in list is " + firstSoldWoodShapeIndexInList + System.Environment.NewLine);

            //Contains()
            Cube glassCube = new Cube(name: "cube", a: 2, Material.GLASS, price: 60);
            bool isAnyWoodCubeIsSold = soldShapes.Contains(woodCube);

            Console.WriteLine("[soldShapes.Contains(woodCube)]");
            Console.WriteLine("Is any wood cube is sold? - " + isAnyWoodCubeIsSold + System.Environment.NewLine);

            bool isAnyGlassCubeIsSold = soldShapes.Contains(glassCube);

            Console.WriteLine("[soldShapes.Contains(glassCube)]");
            Console.WriteLine("Is any glass cube is sold? - " + isAnyGlassCubeIsSold + System.Environment.NewLine);

            //Exists()
            isAnyWoodCubeIsSold = soldShapes.Exists(soldShape => soldShape.Name.Equals("cube") && soldShape.Material == Material.WOOD) == true;
                Console.WriteLine("[isAnyWoodCubeIsSold = soldShapes.Exists(soldShape => soldShape.Name.Equals(\"cube\") && soldShape.Material == Material.WOOD) == true]");
                Console.WriteLine("Is any wood cube is sold? - " + isAnyWoodCubeIsSold +  System.Environment.NewLine);

            isAnyGlassCubeIsSold = soldShapes.Exists(soldShape => soldShape.Name.Equals("glass") && soldShape.Material == Material.GLASS) == false;
                Console.WriteLine("[isAnyGlassCubeIsSold = soldShapes.Exists(soldShape => soldShape.Name.Equals(\"glass\") && soldShape.Material == Material.GLASS) == false;]");
                Console.WriteLine("Is any glass cube is sold? - " + isAnyGlassCubeIsSold + System.Environment.NewLine);

            //Sort()
            List<double> prices = new List<double> { 6, 8, 10, 16, 18, 20, 60, 26, 30, 32};
            prices.Sort();

            Console.WriteLine("Prices by ascending order");
            Console.WriteLine(string.Join(",", prices) + System.Environment.NewLine);

            //Reverse()
            prices.Reverse();
            Console.WriteLine("Prices by descending order");
            Console.WriteLine(string.Join(",", prices) + System.Environment.NewLine);

            //AsReadOnly()
            List<ChessField> fields = ChessField.CreateChessFields();
            ReadOnlyCollection<ChessField> chessFields = fields.AsReadOnly();

            fields.Add(new ChessField('J',2));
            //chessFields.Add(new ChessField('J', 2));

            //TrueForAll()
            double priceOfPlacticCone = 3.5;

            bool isAnysoldShapeCheaperThanPlacticCone = soldShapes.TrueForAll(soldShape => soldShape.Price > priceOfPlacticCone ) ;
            Console.WriteLine("Are all sold shapes more expensive than plastic cone? - " + isAnysoldShapeCheaperThanPlacticCone + System.Environment.NewLine);

            //TrimExcess()
            List<Shape> expectedSoldShapes = new List<Shape>(100);
            expectedSoldShapes.AddRange(soldShapes);

            Console.WriteLine("Capacity of expectedSoldShapes before TrimExcess is " + expectedSoldShapes.Capacity + System.Environment.NewLine);

            expectedSoldShapes.TrimExcess();

            Console.WriteLine("Capacity of expectedSoldShapes after TrimExcess is " + expectedSoldShapes.Capacity + System.Environment.NewLine);

            //RemoveAt()
            soldShapes.RemoveAt(firstSoldWoodShapeIndexInList);

            Console.WriteLine("[soldShapes.RemoveAt(firstSoldWoodShapeIndexInList)]");
            WriteListItems(soldShapes);

            //RemoveRange()
            soldShapes.RemoveRange(0,3);

            Console.WriteLine("[soldShapes.RemoveRange(0,3)]");
            WriteListItems(soldShapes);

            //RemoveAll()
            soldShapes.RemoveAll(soldShape => soldShape.Material == Material.PLASTIC);

            Console.WriteLine("[soldShapes.RemoveAll(soldShape => soldShape.Material == Material.PLASTIC)]");
            WriteListItems(soldShapes);

            //Clear()
            soldShapes.Clear();

            Console.WriteLine("soldShapes content is after calling clear method");
            WriteListItems(soldShapes);

            Console.ReadKey();
        }
    }
}
