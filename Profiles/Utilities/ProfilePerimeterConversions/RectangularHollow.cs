using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class RectangularHollowConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : IRectangularHollow
        {
            return new Perimeter(
                new Polygon2d(RectangleConversion.GetPoints(profile.Height, profile.Width)),
                new List<IPolygon2d>() {
                    new Polygon2d(RectangleConversion.GetPoints(
                        profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness))
                });
        }
    }
}
