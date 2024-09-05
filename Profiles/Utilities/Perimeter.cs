using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Perimeter : IPerimeter
    {
        public IPolygon2d OuterEdge { get; set; }
        public IList<IPolygon2d> VoidEdges { get; set; }

        public Perimeter(IPolygon2d edge)
        {
            OuterEdge = edge;
        }

        public Perimeter(IList<IPoint2d> edgePoints) : this(new Polygon2d(edgePoints)) { }

        public Perimeter(IPolygon2d outerEdge, IList<IPolygon2d> voidEdges)
        {
            OuterEdge = outerEdge;
            VoidEdges = voidEdges;
        }
    }
}
