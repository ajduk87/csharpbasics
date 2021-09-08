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

            List<Shape> shapesInStore = new List<Shape>();

            //For date 1 September 2021
            Sphere plasticSphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6);
            Cube plusticCube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8);
            Cylinder plasticCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10);

            Sphere woodSphere = new Sphere(name: "sphere", r: 2, Material.WOOD, price: 18.5);
            Cube woodCube = new Cube(name: "cube", a: 2, Material.WOOD, price: 22);
            Cylinder woodCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.WOOD, price: 27);

            Sphere metalSphere = new Sphere(name: "sphere", r: 2, Material.METAL, price: 29.5);
            Cube metalCube = new Cube(name: "cube", a: 2, Material.METAL, price: 34);
            Cylinder metalCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.METAL, price: 38);

            Sphere glassSphere = new Sphere(name: "sphere", r: 2, Material.GLASS, price: 29.5);
            Cube glassCube = new Cube(name: "cube", a: 2, Material.GLASS, price: 34);
            Cylinder glassCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.GLASS, price: 38);

            shapesInStore.Add(plasticSphere);
            shapesInStore.Add(plusticCube);
            shapesInStore.Add(plasticCylinder);

            shapesInStore.Add(woodSphere);
            shapesInStore.Add(woodCube);
            shapesInStore.Add(woodCylinder);

            shapesInStore.Add(metalSphere);
            shapesInStore.Add(metalCube);
            shapesInStore.Add(metalCylinder);

            shapesInStore.Add(glassSphere);
            shapesInStore.Add(glassCube);
            shapesInStore.Add(glassCylinder);

            Console.WriteLine("Welcome to the application of our store");
            Console.WriteLine("How much money you want to spend on our products ?" + System.Environment.NewLine);
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Our products are sphere, cube and cylinder" + System.Environment.NewLine);
            Console.WriteLine("What do you want to buy from our products ?");
            string wantedShape = Console.ReadLine();
            Console.WriteLine("How many copies of our product do you want to buy ?");
            int desiredAmount = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Does it matter to you what material the desired product is made of (y/n)?");
            string isSpecificMaterialWantedInput = Console.ReadLine();
            isSpecificMaterialWantedInput.ToLower();

            bool isSpecificMaterialWanted = false;
            if (isSpecificMaterialWantedInput.Equals("y")) 
            {
                isSpecificMaterialWanted = true;
            }

            if (isSpecificMaterialWantedInput.Equals("n"))
            {
                isSpecificMaterialWanted = false;
            }

            if (isSpecificMaterialWanted == true)
            {
                Console.WriteLine("What material do you want the desired product to be made of?");
                Console.WriteLine("Plastic, wood, metal and glass products are available in our store.");
                string wantedMaterialInput = Console.ReadLine();
                wantedMaterialInput.ToUpper();
                Enum.TryParse(wantedMaterialInput, out Material wantedMaterial);

                List<Shape> shapes = shapesInStore.FindAll(shape => shape.Name.Equals(wantedShape));
                ShapeFinder shapeFinder = new ShapeFinder(shapes.ToArray());
                Shape shape;

                switch (wantedMaterial) 
                {
                    case Material.GLASS: shape = shapeFinder["GLASS"]; break;
                    case Material.METAL: shape = shapeFinder["METAL"]; break;
                    case Material.WOOD: shape = shapeFinder["WOOD"]; break;
                    case Material.PLASTIC: shape = shapeFinder["PLASTIC"]; break;
                    default: shape = null; break;
                }

             


                if (money >= shape.Price * desiredAmount)
                {
                    Console.WriteLine($"You can buy the wanted shape made of {wantedMaterial}.");
                }
                else 
                {
                    Console.WriteLine("You can not buy the wanted shape.");
                }
            }
            else 
            {
                Shape glassShape = shapesInStore.Find(shape => shape.Name.Equals(wantedShape) &&
                                                          shape.Material.Equals(Material.GLASS));
                Shape metalShape = shapesInStore.Find(shape => shape.Name.Equals(wantedShape) &&
                                                          shape.Material.Equals(Material.METAL));
                Shape woodShape = shapesInStore.Find(shape => shape.Name.Equals(wantedShape) &&
                                                          shape.Material.Equals(Material.WOOD));
                Shape plasticShape = shapesInStore.Find(shape => shape.Name.Equals(wantedShape) &&
                                                          shape.Material.Equals(Material.PLASTIC));

                Material bestMaterialYouCanBuy;

                if (money >= glassShape.Price * desiredAmount)
                {
                    bestMaterialYouCanBuy = Material.GLASS;                    
                }
                else if (money >= metalShape.Price * desiredAmount)
                {
                    bestMaterialYouCanBuy = Material.METAL;                    
                }
                else if (money >= woodShape.Price * desiredAmount)
                {
                    bestMaterialYouCanBuy = Material.WOOD;                    
                }
                else if (money >= plasticShape.Price * desiredAmount)
                {
                    bestMaterialYouCanBuy = Material.PLASTIC;                    
                }
                else 
                {
                    bestMaterialYouCanBuy = Material.NOTEXISTING;
                }

        switch (bestMaterialYouCanBuy)
        {
            case Material.GLASS: Console.WriteLine($"You can buy the wanted shape made of {bestMaterialYouCanBuy.ToString().ToLower()}.");
                                    break;
            case Material.METAL: Console.WriteLine($"You can buy the wanted shape made of {bestMaterialYouCanBuy.ToString().ToLower()}."); 
                                    break;
            case Material.WOOD: Console.WriteLine($"You can buy the wanted shape made of {bestMaterialYouCanBuy.ToString().ToLower()}."); 
                                    break;
            case Material.PLASTIC: Console.WriteLine($"You can buy the wanted shape made of {bestMaterialYouCanBuy.ToString().ToLower()}."); 
                                    break;
            default: Console.WriteLine("You can not buy the wanted shape."); break;
        }
            }


            Console.WriteLine("Thanks for using our application.");
            Console.ReadKey();
        }
    }
}
