using DemoCSharpBasics.Bills.Wood;
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

        private Dictionary<SpecificMaterial, IBillsCalculator> dictIBillsCalculatorsForWood;

        public BillsCalculatorForWood() 
        {
            dictIBillsCalculatorsForWood = new Dictionary<SpecificMaterial, IBillsCalculator>();
            dictIBillsCalculatorsForWood.Add(SpecificMaterial.PINEWOOD, new BillsCalculatorForPineWood());
            dictIBillsCalculatorsForWood.Add(SpecificMaterial.ASHWOOD, new BillsCalculatorForAshWood());
            dictIBillsCalculatorsForWood.Add(SpecificMaterial.BIRCHWOOD, new BillsCalculatorForBirchWood());
            dictIBillsCalculatorsForWood.Add(SpecificMaterial.CHERRYWOOD, new BillsCalculatorForCherryWood());
            dictIBillsCalculatorsForWood.Add(SpecificMaterial.MAHOGANYWOOD, new BillsCalculatorForMahoganyWood());
        }

        public void Calculate(Shape shape, int desiredAmount) 
        {

            IBillsCalculator billsCalculator = dictIBillsCalculatorsForWood[shape.SpecificMaterial];
            billsCalculator.Calculate(shape, desiredAmount);
        }
    }
}
