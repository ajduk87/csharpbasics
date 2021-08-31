﻿using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Cylinder : Shape
    {
        private double PI;
        private double r;
        private double H;

        public Cylinder(string name, double r, double H, Material material, double price) : base(name, material, price)
        {
            this.r = r;
            this.H = H;
            PI = 3.14;
        }

        public override double Calculate()
        {
            return Math.Round(Math.Pow(r, 2) * PI * H, 2);
        }
    }
}