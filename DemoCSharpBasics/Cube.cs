using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Cube : IVolumeCalculator
    {
        private double a;

        public Cube(double a) 
        {
            this.a = a;
        }

        public double Calculate() 
        {
            return Math.Pow(a, 3);            
        }
    }
}
