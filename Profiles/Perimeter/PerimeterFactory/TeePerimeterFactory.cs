using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateTee(ITee profile)
        {
            return new Perimeter(new List<ILocalPoint2d>()
            {
                new LocalPoint2d(-profile.Width / 2, Length.Zero),
                new LocalPoint2d(profile.Width / 2, Length.Zero),
                new LocalPoint2d(profile.Width / 2, -profile.FlangeThickness),
                new LocalPoint2d(profile.WebThickness / 2, -profile.FlangeThickness),
                new LocalPoint2d(profile.WebThickness / 2, -profile.Height),
                new LocalPoint2d(-profile.WebThickness / 2, -profile.Height),
                new LocalPoint2d(-profile.WebThickness / 2, -profile.FlangeThickness),
                new LocalPoint2d(-profile.Width / 2, -profile.FlangeThickness),
                new LocalPoint2d(-profile.Width / 2, Length.Zero),
            });
        }
    }
}
