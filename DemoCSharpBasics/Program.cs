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
            Sphere plastricSphere = new Sphere(name: "sphere", r: 2, Material.PLASTIC, price: 6, orderAmount: 10);
            Cube plasticCube = new Cube(name: "cube", a: 2, Material.PLASTIC, price: 8, orderAmount: 10);
            Cylinder plasticCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.PLASTIC, price: 10, orderAmount: 10);

            Sphere woodSphere = new Sphere(name: "sphere", r: 2, Material.WOOD, price: 20, orderAmount: 10);
            Cube woodCube = new Cube(name: "cube", a: 2, Material.WOOD, price: 18, orderAmount: 10);
            Cylinder woodCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.WOOD, price: 22, orderAmount: 10);

            Sphere metalSphere = new Sphere(name: "sphere", r: 2, Material.METAL, price: 26, orderAmount: 10);
            Cube metalCube = new Cube(name: "cube", a: 2, Material.METAL, price: 30, orderAmount: 10);
            Cylinder metalCylinder = new Cylinder(name: "cylinder", r: 2, H: 3, Material.METAL, price: 32, orderAmount: 10);

            int[] orderAmountPerRate = new int[] { 4, 10, 6 };

            Console.WriteLine("business rules: ");
            Console.WriteLine("1. if it is purchased over 20 pieces you will receive a five percent discount");
            Console.WriteLine("2. if it is purchased between 15 and 20 pieces you are not charged 2 pieces");

            Console.WriteLine($"It is ordered {orderAmountPerRate.Sum()} pieces.");

            double yourBill = woodSphere.CalculateOrderItemValue(orderAmountPerRate);

            Console.WriteLine($"It is payed {woodSphere.OrderAmount} pieces for unit price {woodSphere.Price} dollars.");
            Console.WriteLine($"You have to pay {yourBill} dollars.");


            Console.ReadKey();
        }
    }
}
