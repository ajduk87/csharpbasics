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
        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }
        public SpecificMaterial SpecificMaterial { get; set; }

        public Shape(string name, Material material, double price, SpecificMaterial specificMaterial) 
        {
            Name = name;
            Material = material;
            Price = price;
            SpecificMaterial = specificMaterial;
        }

        public abstract double Calculate();
    }
}
