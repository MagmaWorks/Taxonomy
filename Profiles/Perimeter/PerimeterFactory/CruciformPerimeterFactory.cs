using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateCruciform(ICruciform profile)
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
                new Point2d(-profile.Width / 2, -profile.FlangeThickness / 2),
                new Point2d(-profile.Width / 2, profile.FlangeThickness / 2),
                new Point2d(-profile.WebThickness / 2, profile.FlangeThickness / 2),
            });
        }
    }
}
