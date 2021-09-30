using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public abstract class Shape : IVolumeCalculator
    {
        public static int NumberOfSoldShapes = 0;

        public static void IncrementNumberOfSoldShapes()
        {
            NumberOfSoldShapes++;
        }

        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }

        public Shape(string name, Material material, double price) 
        {
            Name = name;
            Material = material;
            Price = price;
        }

        public abstract double Calculate();

        public override string ToString()
        {
            return $"name: {this.Name}  kind: {this.Material}  price:{this.Price}";
        }
    }
}
