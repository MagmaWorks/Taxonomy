using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Perimeter : IPerimeter
    {
        public ILocalPolygon2d OuterEdge { get; set; }
        public IList<ILocalPolygon2d> VoidEdges { get; set; }

        public Perimeter(ILocalPolygon2d edge)
        {
            OuterEdge = edge;
        }

        public Perimeter(IList<ILocalPoint2d> edgePoints) : this(new LocalPolygon2d(edgePoints)) { }

        public Perimeter(ILocalPolygon2d outerEdge, IList<ILocalPolygon2d> voidEdges)
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
