using System;

namespace ShapesStore
{
    public class Sphere : Shape
    {
        private double PI;
        private double r;

        public Sphere(string name, double r, Material material, double price, int amount) : base(name, material, price, amount)
        {
            this.r = r;
            PI = 3.14;
        }

        private double CalculateVolume()
        {
            return 4 * Math.Pow(r, 3) * PI / 3;
        }

        public override double Calculate()
        {
            double volume = CalculateVolume();
            return Math.Round(volume, 2);
        }
    }
}