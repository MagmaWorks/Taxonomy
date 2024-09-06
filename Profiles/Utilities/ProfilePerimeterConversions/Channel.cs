using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class ChannelConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : IChannel
        {
            if (profile is IC c)
            {
                return CConversion.GetPerimeter(c);
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
