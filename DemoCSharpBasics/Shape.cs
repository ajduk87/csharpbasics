using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Shape
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public Shape(string name, string color) 
        {
            Name = name;
            Color = color;
        }
    }
}
