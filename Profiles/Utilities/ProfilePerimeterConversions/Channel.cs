﻿using MagmaWorks.Geometry;
using OasysUnits;
using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class ChannelConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : IChannel
        {
            return new Perimeter(new List<IPoint2d>()
            {
                new Point2d(Length.Zero, profile.Height / 2),
                new Point2d(profile.Width, profile.Height / 2),
                new Point2d(profile.Width, profile.Height / 2 - profile.FlangeThickness),
                new Point2d(profile.WebThickness, profile.Height / 2 - profile.FlangeThickness),
                new Point2d(profile.WebThickness, -profile.Height / 2 + profile.FlangeThickness),
                new Point2d(profile.Width, -profile.Height / 2 + profile.FlangeThickness),
                new Point2d(profile.Width, -profile.Height / 2),
                new Point2d(Length.Zero, profile.Height / 2),
            });
        }
    }
}