using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills
{
    public class BillsCalculator
    {
        private Dictionary<Material, IBillsCalculator> dictIBillsCalculators;

        public BillsCalculator() 
        {
            dictIBillsCalculators = new Dictionary<Material, IBillsCalculator>();
            dictIBillsCalculators.Add(Material.PLASTIC, new BillsCalculatorForPlastic());
            dictIBillsCalculators.Add(Material.PLASTIC, new BillsCalculatorForWood());
            dictIBillsCalculators.Add(Material.PLASTIC, new BillsCalculatorForMetal());
            dictIBillsCalculators.Add(Material.PLASTIC, new BillsCalculatorForGlass());
        }


        public void Calculate(Shape shape, int desiredAmount) 
        {
            IBillsCalculator billsCalculator = dictIBillsCalculators[shape.Material];
            billsCalculator.Calculate(shape, desiredAmount);
        }
    }
}
