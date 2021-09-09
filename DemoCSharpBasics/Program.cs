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

                //Business rules
                //1. If more than 30 shapes of glass are ordered, the discount is 5 percent.
                //2. If more than 40 shapes of metal are ordered, the discount is 10 percent.
                //3. If more than 50 shapes of wood are ordered, the discount is 15 percent.
                //4. If more than 60 shapes of plastic are ordered, the discount is 20 percent.
                double yourBill = 0.0;

                switch (bestMaterialYouCanBuy)
                {
                    case Material.GLASS: 
                        {
                            yourBill = desiredAmount > 30 ? 0.95 * glassShape.Price * desiredAmount : 
                                                            glassShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of glass.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case Material.METAL:
                        {
                            yourBill = desiredAmount > 40 ? 0.90 * metalShape.Price * desiredAmount :
                                                            metalShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of metal.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case Material.WOOD:
                        {
                            yourBill = desiredAmount > 50 ? 0.85 * woodShape.Price * desiredAmount :
                                                            woodShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of wood.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case Material.PLASTIC:
                        {
                            yourBill = desiredAmount > 60 ? 0.80 * plasticShape.Price * desiredAmount :
                                                            plasticShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of plastic.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    default: Console.WriteLine("You can not buy the wanted shape."); break;
                }

            }


            Console.WriteLine("Thanks for using our application.");
            Console.ReadKey();
        }
    }
}
