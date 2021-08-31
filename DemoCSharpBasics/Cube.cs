using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Cube : Shape, IVolumeCalculator
    {
        private double a;

        public Cube(string name, double a, string color) : base(name, color)
        {
            this.a = a;
        }

        public double Calculate() 
        {
            return Math.Pow(a, 3);            
        }
    }
}
