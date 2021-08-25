using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class Shape
    {
        public string Name { get; set; }
        public Material Material { get; set; }
        public double Price { get; set; }
        public Shape(string name) 
        {
            Name = name;
        }
    }
}
