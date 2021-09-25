using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{  

    public class Cylinder : Shape
    {
        private double r;
        private double H;

        public static int NumberOfSoldCylinders;
        private static double PI;


        public static void IncrementNumberOfSoldCylinders()
        {
            NumberOfSoldCylinders++;
            PI = 3.14;
        }

        static Cylinder()
        {
            Console.WriteLine("Static cylinder constructor is called.");

            NumberOfSoldCylinders = 0;
            PI = 3.14;
        }

        public Cylinder() : base("cylinder", Material.PLASTIC, 0.0, SpecificMaterial.PETPLASTIC, Color.WHITE, 0)
        {
            this.r = 0.0;
            this.H = 0.0;
        }

        public Cylinder(string Name, double r, double H, Material Material, double Price) :
                        base(Name, Material, Price, SpecificMaterial.PETPLASTIC, Color.WHITE, 0)
        {
            this.r = r;
            this.H = H;
        }

        public Cylinder(string Name, double r, double H, Material Material, double Price, int OrderAmount) :
                        base(Name, Material, Price, SpecificMaterial.PETPLASTIC, Color.WHITE, OrderAmount)
        {
            Console.WriteLine("Instance cylinder (derived) constructor is called.");

            this.r = r;
            this.H = H;
        }

        public Cylinder(string Name, 
                        double r, 
                        double H, 
                        Material Material, 
                        double Price, 
                        SpecificMaterial SpecificMaterial,
                        Color Color,
                        int OrderAmount) :
                        base(Name, 
                            Material, 
                            Price,
                            SpecificMaterial,
                            Color,
                            OrderAmount)
        {
            this.r = r;
            this.H = H;
        }

        public double CalculateVolume()
        {
            return Math.Round(Math.Pow(r, 2) * PI * H, 2);
        }

        public double CalculateArea()
        {
            return Math.Round(Math.Pow(r, 2) * PI * H, 2);
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
