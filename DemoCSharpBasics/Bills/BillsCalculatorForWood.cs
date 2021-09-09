using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills
{
    public class BillsCalculatorForWood : IBillsCalculator
    {
        public void Calculate(Shape shape, int desiredAmount) 
        {
            double yourBill = 0.0;

            switch (shape.SpecificMaterial)
            {
                case SpecificMaterial.PINEWOOD:
                    {
                        yourBill = desiredAmount > 50 ? 0.85 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of pine wood.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.ASHWOOD:
                    {
                        yourBill = desiredAmount > 50 ? 0.84 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of ash wood.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.BIRCHWOOD:
                    {
                        yourBill = desiredAmount > 50 ? 0.83 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of birch wood.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.CHERRYWOOD:
                    {
                        yourBill = desiredAmount > 50 ? 0.82 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of cherry wood.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.MAHOGANYWOOD:
                    {
                        yourBill = desiredAmount > 50 ? 0.81 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of mahogany wood.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                default: Console.WriteLine("You can not buy the wanted shape."); break;
            }
        }
    }
}
