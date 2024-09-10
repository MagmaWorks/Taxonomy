using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateCircularHollow(ICircularHollow profile, int divisions)
        {
            List<IPoint2d> outerEdge = PerimeterFactoryUtility.CreateCirclePoints(profile.Diameter, divisions);
            List<IPoint2d> voidEdge = PerimeterFactoryUtility.CreateCirclePoints(profile.Diameter - 2 * profile.Thickness, divisions);
            return new Perimeter(new Polygon2d(outerEdge), new List<IPolygon2d>() { new Polygon2d(voidEdge) });
        }
    }
}
