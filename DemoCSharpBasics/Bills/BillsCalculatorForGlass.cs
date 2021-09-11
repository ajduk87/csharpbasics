using DemoCSharpBasics.Bills.Glass;
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
        private Dictionary<SpecificMaterial, IBillsCalculator> dictIBillsCalculatorsForGlass;

        public BillsCalculatorForGlass()
        {
            dictIBillsCalculatorsForGlass = new Dictionary<SpecificMaterial, IBillsCalculator>();
            dictIBillsCalculatorsForGlass.Add(SpecificMaterial.ACIDGLASS, new BillsCalculatorForAcidGlass());
            dictIBillsCalculatorsForGlass.Add(SpecificMaterial.COATEDGLASS, new BillsCalculatorForCoatedGlass());
            dictIBillsCalculatorsForGlass.Add(SpecificMaterial.INSULATEDGLASS, new BillsCalculatorForInsulatedGlass());
            dictIBillsCalculatorsForGlass.Add(SpecificMaterial.LAMINATEDGLASS, new BillsCalculatorForLaminatedGlass());
        }


        public void Calculate(Shape shape, int desiredAmount)
        {
            IBillsCalculator billsCalculator = dictIBillsCalculatorsForGlass[shape.SpecificMaterial];
            billsCalculator.Calculate(shape, desiredAmount);
        }
    }
}
