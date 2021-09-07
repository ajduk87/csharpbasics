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

        public Cube(string name, double a, Material material, double price) : base(name, material, price)
        {
            this.a = a;
        }

        public override double Calculate() 
        {
            return Math.Round(Math.Pow(a, 3), 2);            
        }
    }
}
