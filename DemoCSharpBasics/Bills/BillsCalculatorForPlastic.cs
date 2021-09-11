using DemoCSharpBasics.Bills.Plastic;
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

        private Dictionary<SpecificMaterial, IBillsCalculator> dictIBillsCalculatorsForPlastic;

        public BillsCalculatorForPlastic()
        {
            dictIBillsCalculatorsForPlastic = new Dictionary<SpecificMaterial, IBillsCalculator>();
            dictIBillsCalculatorsForPlastic.Add(SpecificMaterial.HDPEPLASTIC, new BillsCalculatorForHdpePlastic());
            dictIBillsCalculatorsForPlastic.Add(SpecificMaterial.PETPLASTIC, new BillsCalculatorForPetPlastic());
            dictIBillsCalculatorsForPlastic.Add(SpecificMaterial.PPLASTIC, new BillsCalculatorForPpPlastic());
            dictIBillsCalculatorsForPlastic.Add(SpecificMaterial.PSTPLASTIC, new BillsCalculatorForPstPlastic());
        }


        public void Calculate(Shape shape, int desiredAmount) 
        {
            IBillsCalculator billsCalculator = dictIBillsCalculatorsForPlastic[shape.SpecificMaterial];
            billsCalculator.Calculate(shape, desiredAmount);
        }
    }
}
