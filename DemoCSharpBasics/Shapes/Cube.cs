using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Cube : Shape
    {
        private double a;

        public Cube(string name, double a, Material material, double price, int orderAmount) : base(name, material, price, orderAmount)
        {
            this.a = a;
        }

        private double CalculateVolume() 
        {
            return Math.Pow(a, 3);
        }

        public override double Calculate() 
        {
            double volume = CalculateVolume();
            return Math.Round(volume, 2);            
        }
    }
}
