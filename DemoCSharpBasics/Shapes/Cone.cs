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

        public Cone(string name, double r, double H, Material material, double price, int soldAmount) :base(name,material, price, soldAmount)
        {
            this.r = r;
            this.H = H;
            PI = 3.14;
        }

        public override double Calculate()
        {
            return Math.Round(Math.Pow(r, 2) * PI * H / 3, 2);
        }
    }
}
