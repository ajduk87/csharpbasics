using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills.Wood
{
    public class BillsCalculatorForBirchWood : IBillsCalculator
    {
        public void Calculate(Shape shape, int desiredAmount)
        {
            double yourBill = 0.0;

            yourBill = desiredAmount > 50 ? 0.83 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
            Console.WriteLine("You can buy the wanted shape made of birch wood.");
            Console.WriteLine($"You bill is {yourBill} dollars.");
        }
    }
}
