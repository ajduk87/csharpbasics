using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Sphere : IVolumeCalculator
    {
        private double PI;
        private double r;

        public Sphere(double r) 
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
