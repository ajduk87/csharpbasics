using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Cone : Shape, IVolumeCalculator
    {
        private double PI;
        private double r;
        private double H;

        public Cone(string name, Material material, double price, double r, double H): base(name, material, price)
        {
            this.r = r;
            this.H = H;
            PI = 3.14;
        }

        public override double Calculate()
        {
            return Math.Pow(r, 2) * PI * H / 3;
        }
    }
}
