using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Perimeter : IPerimeter
    {
        public ILocalPolyline2d OuterEdge
        {
            get { return _outerEdge; }
            set
            {
                _outerEdge = EnsureClosedPolygon(value);
            }
        }

        public IList<ILocalPolyline2d> VoidEdges
        {
            get { return _voidEdges; }
            set
            {
                if (value != null)
                {
                    _voidEdges = value.Select(edge => EnsureClosedPolygon(edge)).ToList();
                }
            }
        }

        private ILocalPolyline2d _outerEdge;
        private IList<ILocalPolyline2d> _voidEdges;

        private Perimeter() { }

        public Perimeter(ILocalPolyline2d edge)
        {
            OuterEdge = edge;
        }

        public Perimeter(IList<ILocalPoint2d> edgePoints) : this(new LocalPolyline2d(edgePoints)) { }

        public Perimeter(ILocalPolyline2d outerEdge, IList<ILocalPolyline2d> voidEdges)
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

        private static ILocalPolyline2d EnsureClosedPolygon(ILocalPolyline2d polygon)
        {
            if (polygon.IsClosed)
            {
                return polygon;
            }

            var closed = new LocalPolyline2d(polygon.Points);
            closed.Points.Add(closed.Points[0]);
            return closed;
        }
    }
}
