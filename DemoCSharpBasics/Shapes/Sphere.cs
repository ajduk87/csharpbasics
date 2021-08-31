using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Sphere : Shape
    {
        private double PI;
        private double r;

        public Sphere(string name, double r, Material material, double price) : base(name, material, price)
        {
            this.r = r;
            PI = 3.14;
        }

        public override double Calculate() 
        {
            return Math.Round(4 * Math.Pow(r, 3) * PI / 3, 2);
        }
    }
}
