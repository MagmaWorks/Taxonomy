using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateC(IC profile)
        {
            return new Perimeter(new List<IPoint2d>()
            {
                new Point2d(Length.Zero, profile.Height / 2),
                new Point2d(profile.Width, profile.Height / 2),
                new Point2d(profile.Width, profile.Height / 2 - profile.Lip),
                new Point2d(profile.Width - profile.FlangeThickness, profile.Height / 2 - profile.Lip),
                new Point2d(profile.Width - profile.FlangeThickness, profile.Height / 2 - profile.FlangeThickness),
                new Point2d(profile.WebThickness, profile.Height / 2 - profile.FlangeThickness),
                new Point2d(profile.WebThickness, -profile.Height / 2 + profile.FlangeThickness),
                new Point2d(profile.Width - profile.FlangeThickness, -profile.Height / 2 + profile.FlangeThickness),
                new Point2d(profile.Width - profile.FlangeThickness, -profile.Height / 2 + profile.Lip),
                new Point2d(profile.Width, -profile.Height / 2 + profile.Lip),
                new Point2d(profile.Width, -profile.Height / 2),
                new Point2d(Length.Zero, -profile.Height / 2),
                new Point2d(Length.Zero, profile.Height / 2),
            });
        }
    }
}
