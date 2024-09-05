using MagmaWorks.Geometry;
using OasysUnits;
using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class CustomIConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : ICustomI
        {
            return new Perimeter(GetIPoints(profile.Height, profile.TopFlangeWidth, profile.BottomFlangeWidth,
                profile.TopFlangeThickness, profile.BottomFlangeThickness, profile.WebThickness));
        }

        internal static List<IPoint2d> GetIPoints(
            Length height, Length topWidth, Length bottomWidth,
            Length topFlangeThk, Length bottomFlangeThk, Length webThk)
        {
            return new List<IPoint2d>()
            {
                new Point2d(-topWidth / 2, height / 2),
                new Point2d(topWidth / 2, height / 2),
                new Point2d(topWidth / 2, height / 2 - topFlangeThk),
                new Point2d(webThk / 2, height / 2 - topFlangeThk),
                new Point2d(webThk / 2, -height / 2 + bottomFlangeThk),
                new Point2d(bottomWidth / 2, -height / 2 + bottomFlangeThk),
                new Point2d(bottomWidth / 2, -height / 2),
                new Point2d(-bottomWidth / 2, -height / 2),
                new Point2d(-bottomWidth / 2, -height / 2 + bottomFlangeThk),
                new Point2d(-webThk / 2, -height / 2 + bottomFlangeThk),
                new Point2d(-webThk / 2, height / 2 - topFlangeThk),
                new Point2d(-topWidth / 2, height / 2 - topFlangeThk),
                new Point2d(-topWidth / 2, height / 2)
            };
        }
    }
}
