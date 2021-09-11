using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills
{
    public class BillsCalculatorForGlass : IBillsCalculator
    {
        public void Calculate(Shape shape, int desiredAmount)
        {
            double yourBill = 0.0;

            switch (shape.SpecificMaterial)
            {
                case SpecificMaterial.LAMINATEDGLASS:
                    {
                        yourBill = desiredAmount > 30 ? 0.95 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of laminated glass.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.INSULATEDGLASS:
                    {
                        yourBill = desiredAmount > 30 ? 0.94 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of insulated glass.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.COATEDGLASS:
                    {
                        yourBill = desiredAmount > 30 ? 0.93 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of coated glass.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.ACIDGLASS:
                    {
                        yourBill = desiredAmount > 30 ? 0.92 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of acid glass.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }

                default: Console.WriteLine("You can not buy the wanted shape."); break;
            }
        }
    }
}
