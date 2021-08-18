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
            sphere = new Sphere(r);
            return sphere.Calculate();
        }

        public double CalculateCylinderVolume(double r, double H)
        {
            cylinder = new Cylinder(r, H);
            return cylinder.Calculate();
        }

        public double CalculateCubeVolume(double a)
        {
            cube = new Cube(a);
            return cube.Calculate();
        }
    }
}
