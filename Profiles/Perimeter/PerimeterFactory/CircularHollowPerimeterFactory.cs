using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateCircularHollow(ICircularHollow profile, int divisions)
        {
            List<ILocalPoint2d> outerEdge = PerimeterFactoryUtility.CreateCirclePoints(profile.Diameter, divisions);
            List<ILocalPoint2d> voidEdge = PerimeterFactoryUtility.CreateCirclePoints(profile.Diameter - 2 * profile.Thickness, divisions);
            return new Perimeter(new LocalPolyline2d(outerEdge), new List<ILocalPolyline2d>() { new LocalPolyline2d(voidEdge) });
        }
    }
}
