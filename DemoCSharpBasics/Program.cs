using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using DemoCSharpBasics.Orders;
using DemoCSharpBasics.Shapes.Validators;

namespace DemoCSharpBasics
{
    public static class Program
    {
        private static void WriteCube(Cube cube)
        {
            Console.WriteLine($"name: {cube.Name}  " +
                              $"material: {cube.Material}  " +
                              $"specific material: {cube.SpecificMaterial} " +
                              $"color: {cube.Color}  " +
                              $"price:{cube.Price}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Cube woodCube = new Cube(Name: "cube", 
                                     a: 2,
                                     Material: "WOOD", 
                                     Price: 10, 
                                     SpecificMaterial: "ASHWOOD",
                                     Color: "WHITE");
            WriteCube(woodCube);

            Cube newWoodCube = new Cube(Name: null,
                                     a: 2,
                                     Material: "CLAY",
                                     Price: -15,
                                     SpecificMaterial: "ASHWOOD",
                                     Color: "WHITE");

            Validator validator = new Validator();
            List<string> errors = validator.Validate(newWoodCube);

            if (errors.Count() == 0)
            {
                woodCube.Name = newWoodCube.Name;
                woodCube.Material = newWoodCube.Material;
                woodCube.SpecificMaterial = newWoodCube.SpecificMaterial;
                woodCube.Price = newWoodCube.Price;

                WriteCube(woodCube);
            }
            else 
            {
                Console.WriteLine("Errors are:");
                foreach (string error in errors)
                {
                    Console.WriteLine(error);
                }
                Console.WriteLine("Shape is not updated !");
            }
           

            

            Console.ReadKey();
        }
    }
}
