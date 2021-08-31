using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Sphere : Shape, IVolumeCalculator
    {
        private double PI;
        private double r;

        public Sphere(string name, double r, string color) : base(name, color)
        {
            this.r = r;
            PI = 3.14;
        }

        public double Calculate() 
        {
            return 4 * Math.Pow(r, 3) * PI / 3;
        }
    }
}
