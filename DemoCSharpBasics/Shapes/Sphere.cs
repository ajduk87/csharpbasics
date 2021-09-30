using DemoCSharpBasics.Orders;
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
        public double CalculateOrderItemValue(Order order)
        {
            double orderItemValue = order.Amount > 20 ? 0.95 * this.Price * order.Amount :
              (order.Amount >= 15 && order.Amount <= 20) ? this.Price * (order.Amount - 2)  :
                                                       this.Price * order.Amount;

            if (order.Amount >= 15 && order.Amount <= 20) 
            {
                order.Amount = order.Amount - 2;
            }

            return orderItemValue;
        }
    }
}
