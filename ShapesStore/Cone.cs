using System;

namespace ShapesStore
{
    public class Cone : IVolumeCalculator
    {
        private double PI;
        private double r;
        private double H;

        public Cone(string name, double r, double H)
        {
            this.r = r;
            this.H = H;
            PI = 3.14;
        }

        public double Calculate()
        {
            return Math.Pow(r, 2) * PI * H / 3;
        }
    }
}