using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Bills
{
    public interface IBillsCalculator
    {
        void Calculate(Shape shape, int desiredAmount);
    }
}
