using DemoCSharpBasics.Bills.Metal;
using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills
{
    public class BillsCalculatorForMetal : IBillsCalculator
    {

        private Dictionary<SpecificMaterial, IBillsCalculator> dictIBillsCalculatorsForMetal;

        public BillsCalculatorForMetal()
        {
            dictIBillsCalculatorsForMetal = new Dictionary<SpecificMaterial, IBillsCalculator>();
            dictIBillsCalculatorsForMetal.Add(SpecificMaterial.ALUMINIUMMETAL, new BillsCalculatorForAluminiumMetal());
            dictIBillsCalculatorsForMetal.Add(SpecificMaterial.BRONZEMETAL, new BillsCalculatorForBronzeMetal());
            dictIBillsCalculatorsForMetal.Add(SpecificMaterial.COPPERMETAL, new BillsCalculatorForCopperMetal());
            dictIBillsCalculatorsForMetal.Add(SpecificMaterial.IRONMETAL, new BillsCalculatorForIronMetal());
            dictIBillsCalculatorsForMetal.Add(SpecificMaterial.ZINCMETAL, new BillsCalculatorForZincMetal());
        }

        public void Calculate(Shape shape, int desiredAmount)
        {

            IBillsCalculator billsCalculator = dictIBillsCalculatorsForMetal[shape.SpecificMaterial];
            billsCalculator.Calculate(shape, desiredAmount);
        }
    }
}
