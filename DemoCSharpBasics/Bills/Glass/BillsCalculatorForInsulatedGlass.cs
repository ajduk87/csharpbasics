using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills.Glass
{
    public class BillsCalculatorForInsulatedGlass : IBillsCalculator
    {
        public void Calculate(Shape shape, int desiredAmount)
        {
            double yourBill = 0.0;

            yourBill = desiredAmount > 30 ? 0.94 * shape.Price * desiredAmount :
                                                      shape.Price * desiredAmount;
            Console.WriteLine("You can buy the wanted shape made of insulated glass.");
            Console.WriteLine($"You bill is {yourBill} dollars.");
        }
    }
}
