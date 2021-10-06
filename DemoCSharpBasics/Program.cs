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
            Sphere plastricSphere = new Sphere(Name: "sphere", r: 2, Material.PLASTIC, Price: 10);
            Sphere woodSphere = new Sphere(Name: "sphere", r: 2, Material.WOOD, Price: 10);

            Cylinder plastricCylinder = new Cylinder(Name: "cylinder", r: 2, H:3, Material.PLASTIC, Price: 10);
            Cylinder woodCylinder = new Cylinder(Name: "cylinder", r: 2, H:4, Material.WOOD, Price: 10);

            Cube plastricCube = new Cube(Name: "cube", a: 3, Material.PLASTIC, Price: 10);
            Cube woodCube = new Cube(Name: "cube", a: 2, Material.WOOD, Price: 10);

            Order order = new Order();

            OrderItem plastricSphereOrderItem = new OrderItem(ProductName: "sphere", Material: Material.PLASTIC, OrderAmount: 23);
            int orderAmount = 23;
            plastricSphereOrderItem = plastricSphere.ProcessOrderItemDeliveryAtOnce(plastricSphereOrderItem, orderAmount);
            order.AddOrderItem(plastricSphereOrderItem);

            OrderItem woodSphereOrderItem = new OrderItem(ProductName: "sphere", Material: Material.WOOD, OrderAmount: 12);
            int firstHalfYearAmount = 8;
            int secondHalfYearAmount = 4;
            woodSphereOrderItem = woodSphere.ProcessOrderItemDeliveryInTwoParts(woodSphereOrderItem, firstHalfYearAmount, secondHalfYearAmount);
            order.AddOrderItem(woodSphereOrderItem);

            OrderItem plastricCylinderOrderItem = new OrderItem(ProductName: "cylinder", Material: Material.PLASTIC, OrderAmount: 25);
            firstHalfYearAmount = 10;
            secondHalfYearAmount = 15;
            plastricCylinderOrderItem = plastricCylinder.ProcessOrderItemDeliveryInTwoParts(woodSphereOrderItem, firstHalfYearAmount, secondHalfYearAmount);
            order.AddOrderItem(plastricCylinderOrderItem);

            OrderItem woodCylinderOrderItem = new OrderItem(ProductName: "cylinder", Material: Material.WOOD, OrderAmount: 8);
            int[] woodCylinderAmounts = new int[4]{ 2,2,2,2 };
            woodCylinderOrderItem = woodCylinder.ProcessOrderItemDeliveryInNParts(woodCylinderOrderItem, woodCylinderAmounts);
            order.AddOrderItem(woodCylinderOrderItem);

            OrderItem plastricCubeOrderItem = new OrderItem(ProductName: "cube", Material: Material.PLASTIC, OrderAmount: 11);
            int[] plastricCubeAmounts = new int[5] { 2, 2, 2, 2, 3 };
            plastricCubeOrderItem = plastricCube.ProcessOrderItemDeliveryInNParts(plastricCubeOrderItem, plastricCubeAmounts);
            order.AddOrderItem(plastricCubeOrderItem);

            OrderItem woodCubeOrderItem = new OrderItem(ProductName: "cube", Material: Material.WOOD, OrderAmount: 29);
            int[] woodCubeAmounts = new int[6] { 4, 8, 2, 7, 4, 3 };
            woodCubeOrderItem = woodCube.ProcessOrderItemDeliveryInNParts(woodCubeOrderItem, woodCubeAmounts);
            order.AddOrderItem(woodCubeOrderItem);

            Console.WriteLine("business rules are: ");
            Console.WriteLine("1. if it is purchased over 20 shapes in one order item, you will receive a five percent discount");
            Console.WriteLine("2. order item processing first way - delivery at the order amount at once");
            Console.WriteLine("3. order item processing second way - delivery at the order amount in two parts");
            Console.WriteLine($"4. order item processing third way - delivery at the order amount in n parts," +
                              $" where n is number between 3 and 12");


            Console.WriteLine("Your order items are: ");
            foreach (OrderItem orderItem in order.OrderItems)
            {
                Console.WriteLine(orderItem.Print());
            }

            Console.WriteLine(System.Environment.NewLine + "Your bill is: " + order.CalculateBill() + " dolars");

            Console.ReadKey();
        }
    }
}
