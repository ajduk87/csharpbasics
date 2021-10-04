using DemoCSharpBasics.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Shapes
{
    public class Cube : Shape
    {
        private double a;

        public static int NumberOfSoldCubes = 0;


        public static void IncrementNumberOfSoldCubes()
        {
            NumberOfSoldCubes++;
        }

        static Cube()
        {

            NumberOfSoldCubes = 0;
        }

        public Cube() : base("cube", Material.PLASTIC, 0.0, SpecificMaterial.PETPLASTIC, Color.WHITE)
        {
            this.a = 0.0;
        }

        public Cube(string Name, double a, Material Material, double Price) :
                    base(Name, Material, Price, SpecificMaterial.PETPLASTIC, Color.WHITE)
        {

            this.a = a;
        }

        public Cube(string Name, double a, Material Material, double Price, SpecificMaterial SpecificMaterial) :
                    base(Name, Material, Price, SpecificMaterial, Color.WHITE)
        {
            this.a = a;
        }

        public Cube(string Name,
                    double a,
                    Material Material,
                    double Price,
                    SpecificMaterial SpecificMaterial,
                    Color Color) :
                    base(Name, 
                         Material, 
                         Price, 
                         SpecificMaterial,
                         Color)
        {
            this.a = a;
        }
        public double CalculateVolume()
        {
            return Math.Round(Math.Pow(a, 3), 2);
        }

        public double CalculateArea()
        {
            return Math.Round(6 * Math.Pow(a, 2), 2);
        }

        //business rule:
        //if it is purchased over 20 cubes, 1 cubes are free
        public override OrderItem ProcessOrderItem(OrderItem orderItem)
        {
            if (orderItem.OrderAmount > 20)
            {
                orderItem.PayedAmount = orderItem.OrderAmount - 1;
                orderItem.Value = this.Price * orderItem.PayedAmount;
            }
            else
            {
                orderItem.PayedAmount = orderItem.OrderAmount;
                orderItem.Value = this.Price * orderItem.OrderAmount;
            }

            orderItem.Discount = 0;

            return orderItem;
        }
    }
}
