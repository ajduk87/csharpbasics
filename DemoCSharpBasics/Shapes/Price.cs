using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics.Shapes
{
    public struct Price
    {
        private int roundDecimal;

        public double Value { get; set; }
        public string Currency { get; set; }

        public Price(double Value, string Currency, int roundDecimal) 
        {
            this.Value = Value;
            this.Currency = Currency;
            this.roundDecimal = roundDecimal;
            this.Value = Math.Round(this.Value, this.roundDecimal);
        }

        public string Print() 
        {
            return $"{this.Value} {this.Currency}";
        }
    }
}
