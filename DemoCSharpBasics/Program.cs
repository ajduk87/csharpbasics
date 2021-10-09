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

            //Name of Shape can not be null
            woodCube.SetName(null);
            //Material have to be one of 4 available materials in shape store (plastic, wood, metal, glass)
            woodCube.SetMaterial("CLAY");
            //if SpecificMaterial is missing type SpecificMaterial is not specified. 
            woodCube.SetSpecificMaterial(string.Empty);
            //Color should be read only
            //woodCube.SetColor("BLACK");
            //Price should always be greater than zero
            woodCube.SetPrice(-15);

            WriteCube(woodCube);

            Console.ReadKey();
        }
    }
}
