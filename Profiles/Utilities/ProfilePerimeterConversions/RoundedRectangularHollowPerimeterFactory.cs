using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateRoundedRectangularHollow(IRoundedRectangularHollow profile, int divisions)
        {
            List<IPoint2d> outerEdge = PerimeterFactoryUtility.CreateRoundedRectanglePoints(
                profile.Height, profile.Width, profile.FlatHeight, profile.FlatWidth, divisions);
            List<IPoint2d> voidEdge = PerimeterFactoryUtility.CreateRoundedRectanglePoints(
                profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness,
                profile.FlatHeight - 2 * profile.Thickness, profile.FlatWidth - 2 * profile.Thickness, divisions);
            return new Perimeter(new Polygon2d(outerEdge), new List<IPolygon2d>() { new Polygon2d(voidEdge) });
        }
    }
}
