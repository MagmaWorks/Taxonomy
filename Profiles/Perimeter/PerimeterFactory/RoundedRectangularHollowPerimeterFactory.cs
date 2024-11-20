using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateRoundedRectangularHollow(IRoundedRectangularHollow profile, int divisions)
        {
            List<ILocalPoint2d> outerEdge = PerimeterFactoryUtility.CreateRoundedRectanglePoints(
                profile.Height, profile.Width, profile.FlatHeight, profile.FlatWidth, divisions);
            List<ILocalPoint2d> voidEdge = PerimeterFactoryUtility.CreateRoundedRectanglePoints(
                profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness,
                profile.FlatHeight - 2 * profile.Thickness, profile.FlatWidth - 2 * profile.Thickness, divisions);
            return new Perimeter(new LocalPolyline2d(outerEdge), new List<ILocalPolyline2d>() { new LocalPolyline2d(voidEdge) });
        }
    }
}
