using DemoCSharpBasics.Shapes;
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

        public Sphere(string name, double r, Material material, double price) : base(name, material, price)
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

        //business rules:
        //1. if it is purchased over 20 pieces you will receive a five percent discount
        //2. if it is purchased between 15 and 20 pieces you are not charged 2 pieces
        public double CalculateOrderItemValue(ref int orderAmount)
        {
            double orderItemValue = orderAmount > 20 ? 0.95 * this.Price * orderAmount :
              (orderAmount>=15 && orderAmount <= 20) ? this.Price * (orderAmount - 2)  :
                                                       this.Price * orderAmount;

            if (orderAmount >= 15 && orderAmount <= 20) 
            {
                orderAmount = orderAmount - 2;
            }

            return orderItemValue;
        }
    }
}
