﻿using DemoCSharpBasics.Shapes;
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
        private static void WriteSphere(Sphere soldSphere)
        {
            Console.WriteLine($"name: {soldSphere.Name}  " +
                              $"kind: {soldSphere.Material}  " +
                              $"volume: {soldSphere.CalculateVolume()} " +
                              $"area: {soldSphere.CalculateArea()}  " +
                              $"price:{soldSphere.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        private static void WriteCylinder(Cylinder soldCylinder)
        {
            Console.WriteLine($"name: {soldCylinder.Name}  " +
                              $"kind: {soldCylinder.Material}  " +
                              $"volume: {soldCylinder.CalculateVolume()} " +
                              $"area: {soldCylinder.CalculateArea()}  " +
                              $"price:{soldCylinder.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            //It orders:
            //23 plastric sphere
            //12 wood spheres
            //25 plastric cylinder
            //8  wood cylinder
            //11 plactic cubes
            //29 wood cubes
            Sphere plastricSphere = new Sphere(Name: "sphere", r: 2, Material.PLASTIC, Price: 6);
            Sphere woodSphere = new Sphere(Name: "sphere", r: 2, Material.WOOD, Price: 18);

            Cylinder plastricCylinder = new Cylinder(Name: "cylinder", r: 2, H:3, Material.PLASTIC, Price: 10);
            Cylinder woodCylinder = new Cylinder(Name: "cylinder", r: 2, H:4, Material.WOOD, Price: 20);

            Cube plastricCube = new Cube(Name: "cube", a: 3, Material.PLASTIC, Price: 10);
            Cube woodCube = new Cube(Name: "cube", a: 2, Material.WOOD, Price: 20);

            Order order = new Order();

            OrderItem plastricSphereOrderItem = new OrderItem(ProductName: "sphere", Material: Material.PLASTIC, OrderAmount: 24);
            plastricSphereOrderItem = plastricSphere.ProcessOrderItem(plastricSphereOrderItem);
            order.AddOrderItem(plastricSphereOrderItem);

            OrderItem woodSphereOrderItem = new OrderItem(ProductName: "sphere", Material: Material.WOOD, OrderAmount: 16);
            woodSphereOrderItem = woodSphere.ProcessOrderItem(woodSphereOrderItem);
            order.AddOrderItem(woodSphereOrderItem);

            shapeOrderItems.Add(woodSphere);
            shapeOrderItems.Add(plastricCylinder);
            shapeOrderItems.Add(woodCylinder);
            shapeOrderItems.Add(plastricCube);
            shapeOrderItems.Add(woodCube);

            Console.WriteLine("business rules are: ");
            Console.WriteLine("1. if it is purchased over 20 shapes in one order item, you will receive a five percent discount");
            Console.WriteLine("2. if it is purchased over 20 spheres in one order item, 4 spheres are free");


            Console.WriteLine("Your order items are: ");
            foreach (OrderItem orderItem in order.OrderItems)
            {
                Console.WriteLine(orderItem.Print());
            }

            Console.WriteLine(System.Environment.NewLine + "Your bill is: " + order.CalculateBill());

            Console.ReadKey();
        }
    }
}
