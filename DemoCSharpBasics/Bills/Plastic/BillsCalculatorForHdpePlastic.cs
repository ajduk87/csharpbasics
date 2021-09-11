﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills.Plastic
{
    public class BillsCalculatorForHdpePlastic : IBillsCalculator
    {
        public void Calculate(Shape shape, int desiredAmount) 
        {
            double yourBill = 0.0;

            yourBill = desiredAmount > 60 ? 0.79 * shape.Price * desiredAmount :
                                                     shape.Price * desiredAmount;
            Console.WriteLine("You can buy the wanted shape made of hdpe plastic.");
            Console.WriteLine($"You bill is {yourBill} dollars.");
        }
    }
}
