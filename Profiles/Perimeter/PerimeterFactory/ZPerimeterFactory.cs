using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateZ(IZ profile)
        {
            return new Perimeter(new List<ILocalPoint2d>()
            {
                new LocalPoint2d(-profile.Thickness / 2, profile.Height / 2),
                new LocalPoint2d(-profile.Thickness / 2 + profile.TopFlangeWidth, profile.Height / 2),
                new LocalPoint2d(-profile.Thickness / 2 + profile.TopFlangeWidth, profile.Height / 2 - profile.TopLip),
                new LocalPoint2d(-profile.Thickness * 1.5 + profile.TopFlangeWidth, profile.Height / 2 - profile.TopLip),
                new LocalPoint2d(-profile.Thickness * 1.5 + profile.TopFlangeWidth, profile.Height / 2 - profile.Thickness),
                new LocalPoint2d(profile.Thickness / 2, profile.Height / 2 - profile.Thickness),
                new LocalPoint2d(profile.Thickness / 2, -profile.Height / 2),
                new LocalPoint2d(profile.Thickness / 2 - profile.BottomFlangeWidth, -profile.Height / 2),
                new LocalPoint2d(profile.Thickness / 2 - profile.BottomFlangeWidth, -profile.Height / 2 + profile.BottomLip),
                new LocalPoint2d(profile.Thickness * 1.5 - profile.BottomFlangeWidth, -profile.Height / 2 + profile.BottomLip),
                new LocalPoint2d(profile.Thickness * 1.5 - profile.BottomFlangeWidth, -profile.Height / 2 + profile.Thickness),
                new LocalPoint2d(-profile.Thickness / 2, -profile.Height / 2 + profile.Thickness),
                new LocalPoint2d(-profile.Thickness / 2, profile.Height / 2),
            });
        }
    }
}
