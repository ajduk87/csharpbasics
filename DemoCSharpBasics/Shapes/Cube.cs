using DemoCSharpBasics.Orders;
using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Cube : Shape
    {
        private double a;

        public Cube(string name, double a, Material material, double price) : base(name, material, price)
        {
            this.a = a;
        }

        private double CalculateVolume() 
        {
            return Math.Pow(a, 3);
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
              (order.Amount >= 15 && order.Amount <= 20) ? this.Price * (order.Amount - 2) :
                                                       this.Price * order.Amount;

            if (order.Amount >= 15 && order.Amount <= 20)
            {
                order.Amount = order.Amount - 2;
            }

            return orderItemValue;
        }
    }
}
