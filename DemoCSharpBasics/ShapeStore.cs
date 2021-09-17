using ShapesStore;
using System.Collections.Generic;

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