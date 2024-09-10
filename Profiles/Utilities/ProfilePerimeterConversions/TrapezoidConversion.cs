using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class TrapezoidConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : ITrapezoid
        {
            return new Perimeter(new List<IPoint2d>()
            {
                new Point2d(-profile.TopWidth / 2, profile.Height / 2),
                new Point2d(profile.TopWidth / 2, profile.Height / 2),
                new Point2d(profile.BottomWidth / 2, -profile.Height / 2),
                new Point2d(-profile.BottomWidth / 2, -profile.Height / 2),
                new Point2d(-profile.TopWidth / 2, profile.Height / 2),
            });
        }
    }
}
