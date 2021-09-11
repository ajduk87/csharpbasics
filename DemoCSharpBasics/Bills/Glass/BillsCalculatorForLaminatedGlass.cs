using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills.Glass
{
    public class BillsCalculatorForLaminatedGlass : IBillsCalculator
    {
        public void Calculate(Shape shape, int desiredAmount)
        {
            double yourBill = 0.0;

            yourBill = desiredAmount > 30 ? 0.95 * shape.Price * desiredAmount :
                                                     shape.Price * desiredAmount;
            Console.WriteLine("You can buy the wanted shape made of laminated glass.");
            Console.WriteLine($"You bill is {yourBill} dollars.");
        }
    }
}
