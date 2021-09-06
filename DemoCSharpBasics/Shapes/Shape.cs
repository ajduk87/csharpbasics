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
        public int SoldAmount { get; set; }

        public Shape(string name, Material material, double price, int soldAmount) 
        {
            Name = name;
            Material = material;
            Price = price;
            SoldAmount = soldAmount;
        }

        public abstract double Calculate();
    }
}
