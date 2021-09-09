using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using DemoCSharpBasics.Bills;

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
                SpecificMaterial specificMaterial = SpecificMaterial.ACIDGLASS;

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
                //1. If more than 30 shapes of laminated glass are ordered, the discount is 5 percent.
                //2. If more than 30 shapes of insulated glass are ordered, the discount is 6 percent.
                //3. If more than 30 shapes of coated glass are ordered, the discount is 7 percent.
                //4. If more than 30 shapes of acid glass are ordered, the discount is 8 percent.
                //5. If more than 40 shapes of iron metal are ordered, the discount is 10 percent.
                //6. If more than 40 shapes of copper metal are ordered, the discount is 11 percent.
                //7. If more than 40 shapes of aluminium metal are ordered, the discount is 12 percent.
                //8. If more than 40 shapes of bronze metal are ordered, the discount is 13 percent.
                //9. If more than 40 shapes of zinc metal are ordered, the discount is 14 percent.
                //10. If more than 50 shapes of pine wood are ordered, the discount is 15 percent.
                //11. If more than 50 shapes of ash wood are ordered, the discount is 16 percent.
                //12. If more than 50 shapes of birch wood are ordered, the discount is 17 percent.
                //13. If more than 50 shapes of cherry wood are ordered, the discount is 18 percent.
                //14. If more than 50 shapes of mahogany wood are ordered, the discount is 19 percent.
                //15. If more than 60 shapes of pet plastic are ordered, the discount is 20 percent.
                //16. If more than 60 shapes of hdpe plastic are ordered, the discount is 21 percent.
                //17. If more than 60 shapes of pp plastic are ordered, the discount is 22 percent.
                //18. If more than 60 shapes of pst plastic are ordered, the discount is 23 percent.

                BillsCalculator billsCalculator = new BillsCalculator();
                switch (bestMaterialYouCanBuy) 
                {
                    case Material.GLASS: 
                    {
                        billsCalculator.Calculate(glassShape, desiredAmount);
                        break;
                    }
                    case Material.METAL:
                    {
                        billsCalculator.Calculate(metalShape, desiredAmount);
                        break;
                    }
                    case Material.WOOD:
                    {
                        billsCalculator.Calculate(woodShape, desiredAmount);
                        break;
                    }
                    case Material.PLASTIC:
                    {
                        billsCalculator.Calculate(plasticShape, desiredAmount);
                        break;
                    }
                }



                switch (specificMaterial)
                {
                    case SpecificMaterial.LAMINATEDGLASS: 
                        {
                            yourBill = desiredAmount > 30 ? 0.95 * glassShape.Price * desiredAmount : 
                                                            glassShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of laminated glass.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case SpecificMaterial.INSULATEDGLASS:
                        {
                            yourBill = desiredAmount > 30 ? 0.94 * glassShape.Price * desiredAmount :
                                                            glassShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of insulated glass.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case SpecificMaterial.COATEDGLASS:
                        {
                            yourBill = desiredAmount > 30 ? 0.93 * glassShape.Price * desiredAmount :
                                                            glassShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of coated glass.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case SpecificMaterial.ACIDGLASS:
                        {
                            yourBill = desiredAmount > 30 ? 0.92 * glassShape.Price * desiredAmount :
                                                            glassShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of acid glass.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case SpecificMaterial.IRONMETAL:
                        {
                            yourBill = desiredAmount > 40 ? 0.90 * metalShape.Price * desiredAmount :
                                                            metalShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of iron metal.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case SpecificMaterial.COPPERMETAL:
                        {
                            yourBill = desiredAmount > 40 ? 0.89 * metalShape.Price * desiredAmount :
                                                            metalShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of copper metal.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case SpecificMaterial.ALUMINIUMMETAL:
                        {
                            yourBill = desiredAmount > 40 ? 0.88 * metalShape.Price * desiredAmount :
                                                            metalShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of aluminium metal.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case SpecificMaterial.BRONZEMETAL:
                        {
                            yourBill = desiredAmount > 40 ? 0.87 * metalShape.Price * desiredAmount :
                                                            metalShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of bronze metal.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    case SpecificMaterial.ZINCMETAL:
                        {
                            yourBill = desiredAmount > 40 ? 0.86 * metalShape.Price * desiredAmount :
                                                            metalShape.Price * desiredAmount;
                            Console.WriteLine("You can buy the wanted shape made of zinc metal.");
                            Console.WriteLine($"You bill is {yourBill} dollars.");
                            break;
                        }
                    
                  
                }

            }


            Console.WriteLine("Thanks for using our application.");
            Console.ReadKey();
        }
    }
}
