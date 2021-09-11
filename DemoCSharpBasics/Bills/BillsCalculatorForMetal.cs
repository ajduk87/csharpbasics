using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills
{
    public class BillsCalculatorForMetal
    {
        public void Calculate(Shape shape, int desiredAmount)
        {
            double yourBill = 0.0;

            switch (shape.SpecificMaterial)
            {
                case SpecificMaterial.IRONMETAL:
                    {
                        yourBill = desiredAmount > 40 ? 0.90 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of iron metal.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.COPPERMETAL:
                    {
                        yourBill = desiredAmount > 40 ? 0.89 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of copper metal.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.ALUMINIUMMETAL:
                    {
                        yourBill = desiredAmount > 40 ? 0.88 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of aluminium metal.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.BRONZEMETAL:
                    {
                        yourBill = desiredAmount > 40 ? 0.87 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of bronze metal.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                case SpecificMaterial.ZINCMETAL:
                    {
                        yourBill = desiredAmount > 40 ? 0.86 * shape.Price * desiredAmount :
                                                        shape.Price * desiredAmount;
                        Console.WriteLine("You can buy the wanted shape made of zinc metal.");
                        Console.WriteLine($"You bill is {yourBill} dollars.");
                        break;
                    }
                default: Console.WriteLine("You can not buy the wanted shape."); break;
            }
        }
    }
}
