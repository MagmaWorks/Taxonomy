using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateAngle(IAngle profile)
        {
            return new Perimeter(new List<ILocalPoint2d>()
            {
                new LocalPoint2d(Length.Zero, Length.Zero),
                new LocalPoint2d(Length.Zero, profile.Height),
                new LocalPoint2d(profile.WebThickness, profile.Height),
                new LocalPoint2d(profile.WebThickness, profile.FlangeThickness),
                new LocalPoint2d(profile.Width, profile.FlangeThickness),
                new LocalPoint2d(profile.Width, Length.Zero),
                new LocalPoint2d(Length.Zero, Length.Zero),
            });
        }
    }
}
