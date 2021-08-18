using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class VolumeCalculator
    {
        private double PI;

        public VolumeCalculator() 
        {
            PI = 3.14;
        }

        public double CalculateSphereVolume(double r) 
        {
            return 4 * Math.Pow(r, 3) * PI / 3;
        }

        public double CalculateCylinderVolume(double r, double H)
        {
            return Math.Pow(r, 2) * PI * H;
        }

        public double CalculateCubeVolume(double a)
        {
            return Math.Pow(a, 3);
        }
    }
}
