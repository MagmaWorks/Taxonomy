using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateC(IC profile)
        {
            return new Perimeter(new List<ILocalPoint2d>()
            {
                new LocalPoint2d(Length.Zero, profile.Height / 2),
                new LocalPoint2d(profile.Width, profile.Height / 2),
                new LocalPoint2d(profile.Width, profile.Height / 2 - profile.Lip),
                new LocalPoint2d(profile.Width - profile.FlangeThickness, profile.Height / 2 - profile.Lip),
                new LocalPoint2d(profile.Width - profile.FlangeThickness, profile.Height / 2 - profile.FlangeThickness),
                new LocalPoint2d(profile.WebThickness, profile.Height / 2 - profile.FlangeThickness),
                new LocalPoint2d(profile.WebThickness, -profile.Height / 2 + profile.FlangeThickness),
                new LocalPoint2d(profile.Width - profile.FlangeThickness, -profile.Height / 2 + profile.FlangeThickness),
                new LocalPoint2d(profile.Width - profile.FlangeThickness, -profile.Height / 2 + profile.Lip),
                new LocalPoint2d(profile.Width, -profile.Height / 2 + profile.Lip),
                new LocalPoint2d(profile.Width, -profile.Height / 2),
                new LocalPoint2d(Length.Zero, -profile.Height / 2),
                new LocalPoint2d(Length.Zero, profile.Height / 2),
            });
        }
    }
}
