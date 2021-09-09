using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills
{
    public class BillsCalculatorForPlastic : IBillsCalculator
    {
        public void Calculate(Shape shape, int desiredAmount) 
        {
            double yourBill = 0.0;

            switch (shape.SpecificMaterial) 
            {
                case SpecificMaterial.PETPLASTIC:
                    {
                        yourBill = desiredAmount > 60 ? 0.80 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of pet plastic.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.HDPEPLASTIC:
                    {
                        yourBill = desiredAmount > 60 ? 0.79 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of hdpe plastic.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.PPLASTIC:
                    {
                        yourBill = desiredAmount > 60 ? 0.78 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of pp plastic.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.PSTPLASTIC:
                    {
                        yourBill = desiredAmount > 60 ? 0.77 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of pst plastic.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                default: Console.WriteLine("You can not buy the wanted shape."); break;
            }
        }
    }
}
