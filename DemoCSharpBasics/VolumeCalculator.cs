using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class VolumeCalculator
    {
        private Cube cube;
        private Cylinder cylinder;
        private Sphere sphere;


        public double CalculateSphereVolume(double r) 
        {
            sphere = new Sphere("sphere",r);
            return sphere.Calculate();
        }

        public double CalculateCylinderVolume(double r, double H)
        {
            cylinder = new Cylinder("cylinder", r, H);
            return cylinder.Calculate();
        }

        public double CalculateCubeVolume(double a)
        {
            cube = new Cube("cube", a);
            return cube.Calculate();
        }
    }
}
