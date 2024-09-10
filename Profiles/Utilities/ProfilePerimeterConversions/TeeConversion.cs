using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class TeeConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : ITee
        {
            return new Perimeter(new List<IPoint2d>()
            {
                new Point2d(-profile.Width / 2, Length.Zero),
                new Point2d(profile.Width / 2, Length.Zero),
                new Point2d(profile.Width / 2, -profile.FlangeThickness),
                new Point2d(profile.WebThickness / 2, -profile.FlangeThickness),
                new Point2d(profile.WebThickness / 2, -profile.Height),
                new Point2d(-profile.WebThickness / 2, -profile.Height),
                new Point2d(-profile.WebThickness / 2, -profile.FlangeThickness),
                new Point2d(-profile.Width / 2, -profile.FlangeThickness),
                new Point2d(-profile.Width / 2, Length.Zero),
            });
        }
    }
}
