using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Cylinder : IVolumeCalculator
    {
        private double PI;
        private double r;
        private double H;

        public Cylinder(double r, double H)
        {
            this.r = r;
            this.H = H;
            PI = 3.14;
        }

        public double Calculate()
        {
            return Math.Pow(r, 2) * PI * H;
        }
    }
}
