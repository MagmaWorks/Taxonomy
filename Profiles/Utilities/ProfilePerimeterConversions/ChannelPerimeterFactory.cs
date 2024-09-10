using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateChannel(IChannel profile)
        {
            if (profile is IC c)
            {
                return CreateC(c);
            }

            return new Perimeter(new List<IPoint2d>()
            {
                new Point2d(Length.Zero, profile.Height / 2),
                new Point2d(profile.Width, profile.Height / 2),
                new Point2d(profile.Width, profile.Height / 2 - profile.FlangeThickness),
                new Point2d(profile.WebThickness, profile.Height / 2 - profile.FlangeThickness),
                new Point2d(profile.WebThickness, -profile.Height / 2 + profile.FlangeThickness),
                new Point2d(profile.Width, -profile.Height / 2 + profile.FlangeThickness),
                new Point2d(profile.Width, -profile.Height / 2),
                new Point2d(Length.Zero, -profile.Height / 2),
                new Point2d(Length.Zero, profile.Height / 2),
            });
        }
    }
}
