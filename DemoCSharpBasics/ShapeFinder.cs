using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class ShapeFinder
    {
        public Shape[] Shapes { get; set; }

        public ShapeFinder(Shape[] shapes) 
        {
            Shapes = shapes;
        }

        public Shape this[string materialOfShape] 
        {
            get 
            {
                return Shapes.FirstOrDefault(shape => shape.Material.Equals(materialOfShape));
            }
        }
    }
}
