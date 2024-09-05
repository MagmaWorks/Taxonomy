using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class RectangleConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : IRectangle
        {
            return new Perimeter(GetPoints(profile.Height, profile.Width));
        }

        internal static List<IPoint2d> GetPoints(Length height, Length width)
        {
            return new List<IPoint2d>()
            {
                new Point2d(-width / 2, height / 2),
                new Point2d(width / 2, height / 2),
                new Point2d(width / 2, -height / 2),
                new Point2d(-width / 2, -height / 2),
                new Point2d(-width / 2, height / 2),
            };
        }
    }
}
