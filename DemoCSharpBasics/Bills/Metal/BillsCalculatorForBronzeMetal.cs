using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills.Metal
{
    public class BillsCalculatorForBronzeMetal : IBillsCalculator
    {
        public void Calculate(Shape shape, int desiredAmount)
        {
            double yourBill = 0.0;

            yourBill = desiredAmount > 40 ? 0.87 * shape.Price * desiredAmount :
                                                       shape.Price * desiredAmount;
            Console.WriteLine("You can buy the wanted shape made of bronze metal.");
            Console.WriteLine($"You bill is {yourBill} dollars.");
        }
    }
}
