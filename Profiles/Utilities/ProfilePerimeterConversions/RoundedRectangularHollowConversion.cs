using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class RoundedRectangularHollowConversion
    {
        internal static IPerimeter GetPerimeter<T>(this T profile, int divisions) where T : IRoundedRectangularHollow
        {
            List<IPoint2d> outerEdge = RoundedRectangleConversion.GetPoints(
                profile.Height, profile.Width, profile.FlatHeight, profile.FlatWidth, divisions);
            List<IPoint2d> voidEdge = RoundedRectangleConversion.GetPoints(
                profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness,
                profile.FlatHeight - 2 * profile.Thickness, profile.FlatWidth - 2 * profile.Thickness, divisions);
            return new Perimeter(new Polygon2d(outerEdge), new List<IPolygon2d>() { new Polygon2d(voidEdge) });
        }
    }
}
