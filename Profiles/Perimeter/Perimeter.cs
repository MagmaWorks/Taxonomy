using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public class Perimeter : IPerimeter
    {
        public ILocalPolygon2d OuterEdge
        {
            get { return _outerEdge; }
            set
            {
                _outerEdge = EnsureClosedPolygon(value);
            }
        }

        public IList<ILocalPolygon2d> VoidEdges
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

        private ILocalPolygon2d _outerEdge;
        private IList<ILocalPolygon2d> _voidEdges;

        private Perimeter() { }

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

        private static ILocalPolygon2d EnsureClosedPolygon(ILocalPolygon2d polygon)
        {
            if (polygon.IsClosed)
            {
                return polygon;
            }

            var closed = new LocalPolygon2d(polygon.Points);
            closed.Points.Add(closed.Points[0]);
            return closed;
        }
    }
}
