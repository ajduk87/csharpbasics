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
        private static void WriteSphere(Sphere soldSphere)
        {
            Console.WriteLine($"name: {soldSphere.Name}  kind: {soldSphere.Material}  volume: {soldSphere.Calculate()}  price:{soldSphere.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        private static void WriteCylinder(Cylinder soldCylinder)
        {
            Console.WriteLine($"name: {soldCylinder.Name}  kind: {soldCylinder.Material}  volume: {soldCylinder.Calculate()}  price:{soldCylinder.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

            List<Sphere> soldSpheres = new List<Sphere>();
            List<Cylinder> soldCylinders = new List<Cylinder>();
            Sphere plastricSphere = new Sphere();
            Cylinder plasticCylinder = new Cylinder();

            Sphere woodSphere = new Sphere();
            Cylinder woodCylinder = new Cylinder();

            Sphere metalSphere = new Sphere();
            Cylinder metalCylinder = new Cylinder();

            soldSpheres.Add(plastricSphere);
            Sphere.IncrementNumberOfSoldSpheres();
            soldSpheres.Add(woodSphere);
            Sphere.IncrementNumberOfSoldSpheres();
            soldSpheres.Add(metalSphere);
            Sphere.IncrementNumberOfSoldSpheres();


            soldCylinders.Add(plasticCylinder);
            Cylinder.IncrementNumberOfSoldCylinders();
            soldCylinders.Add(woodCylinder);
            Cylinder.IncrementNumberOfSoldCylinders();
            soldCylinders.Add(metalCylinder);
            Cylinder.IncrementNumberOfSoldCylinders();

            Console.WriteLine("Sold spheres are : " + System.Environment.NewLine);

            foreach (Sphere soldSphere in soldSpheres)
            {
                WriteSphere(soldSphere);
            }

            Console.WriteLine("Number of sold spheres is : " + Sphere.NumberOfSoldSpheres);


            Console.WriteLine("Sold cylinders are : " + System.Environment.NewLine);

            foreach (Cylinder soldCylinder in soldCylinders)
            {
                WriteCylinder(soldCylinder);
            }

            Console.WriteLine("Number of sold cylinders is : " + Cylinder.NumberOfSoldCylinders);


            Console.ReadKey();
        }
    }
}
