using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateEllipseHollow(IEllipseHollow profile, int divisions)
        {
            IList<IPoint2d> outerEdge = PerimeterFactoryUtility.CreateEllipsePoints(profile.Height, profile.Width, divisions);
            IList<IPoint2d> voidEdge = PerimeterFactoryUtility.CreateEllipsePoints(
                profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness, divisions);
            return new Perimeter(new Polygon2d(outerEdge), new List<IPolygon2d>() { new Polygon2d(voidEdge) });
        }
    }
}
