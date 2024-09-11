using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

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

        public Perimeter(IProfile profile)
        {
            IPerimeter factory = PerimeterFactory.PerimeterFactory.CreatePerimeter(profile);
            OuterEdge = factory.OuterEdge;
            VoidEdges = factory.VoidEdges;
        }

        public Perimeter(IProfile profile, Length tolerance)
        {
            IPerimeter factory = PerimeterFactory.PerimeterFactory.CreatePerimeter(profile, tolerance);
            OuterEdge = factory.OuterEdge;
            VoidEdges = factory.VoidEdges;
        }

        public Perimeter(IProfile profile, int divisions)
        {
            IPerimeter factory = PerimeterFactory.PerimeterFactory.CreatePerimeter(profile, divisions);
            OuterEdge = factory.OuterEdge;
            VoidEdges = factory.VoidEdges;
        }

        public static (IPerimeter, IPerimeter) CreatePerimeters<T>(T profile)
            where T : IProfile, IBackToBack
        {
            return PerimeterFactory.PerimeterFactory.CreateBackToBackPerimeters(profile);
        }
    }
}
