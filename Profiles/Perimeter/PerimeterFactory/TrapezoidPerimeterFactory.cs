using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateTrapezoid(ITrapezoid profile)
        {
            return new Perimeter(new List<ILocalPoint2d>()
            {
                new LocalPoint2d(-profile.TopWidth / 2, profile.Height / 2),
                new LocalPoint2d(profile.TopWidth / 2, profile.Height / 2),
                new LocalPoint2d(profile.BottomWidth / 2, -profile.Height / 2),
                new LocalPoint2d(-profile.BottomWidth / 2, -profile.Height / 2),
                new LocalPoint2d(-profile.TopWidth / 2, profile.Height / 2),
            });
        }
    }
}
