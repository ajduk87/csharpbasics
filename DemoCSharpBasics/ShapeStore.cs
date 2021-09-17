using DemoCSharpBasics.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharpBasics
{
    public class ShapeStore
    {
        public List<Shape> SoldShapes { get; set; }

        public ShapeStore(List<Shape> soldShapes) 
        {
            SoldShapes = soldShapes;
        }
    }
}
