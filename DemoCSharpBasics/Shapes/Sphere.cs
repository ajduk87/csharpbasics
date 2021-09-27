﻿using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Sphere : Shape
    {
        private double PI;
        private double r;

        public Sphere(string name, double r, Material material, double price, int orderAmount) : base(name, material, price, orderAmount)
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

        //business rule:
        //if it is purchased over 20 pieces you will receive a five percent discount
        public double CalculateOrderItemValue()
        {
            double orderItemValue = this.OrderAmount > 20 ? 0.95 * this.Price * this.OrderAmount :
                                                            this.Price * this.OrderAmount;

            return orderItemValue;
        }
    }
}
