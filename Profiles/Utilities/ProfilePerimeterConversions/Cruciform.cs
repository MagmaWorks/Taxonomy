using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class CruciformConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : ICruciform
        {
            return new Perimeter(new List<IPoint2d>()
            {
                new Point2d(-profile.WebThickness / 2, profile.FlangeThickness / 2),
                new Point2d(-profile.WebThickness / 2, profile.Height / 2),
                new Point2d(profile.WebThickness / 2, profile.Height / 2),
                new Point2d(profile.WebThickness / 2, profile.FlangeThickness / 2),
                new Point2d(profile.Width / 2, profile.FlangeThickness / 2),
                new Point2d(profile.Width / 2, -profile.FlangeThickness / 2),
                new Point2d(profile.WebThickness / 2, -profile.FlangeThickness / 2),
                new Point2d(profile.WebThickness / 2, -profile.Height / 2),
                new Point2d(-profile.WebThickness / 2, -profile.Height / 2),
                new Point2d(-profile.WebThickness / 2, -profile.FlangeThickness / 2),
                new Point2d(-profile.Width / 2, profile.FlangeThickness / 2),
                new Point2d(-profile.Width / 2, -profile.FlangeThickness / 2),
                new Point2d(-profile.WebThickness / 2, profile.FlangeThickness / 2),
            });
        }
    }
}
