using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class ZConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : IZ
        {
            return new Perimeter(new List<IPoint2d>()
            {
                new Point2d(-profile.Thickness / 2, profile.Height / 2),
                new Point2d(-profile.Thickness / 2 + profile.TopFlangeWidth, profile.Height / 2),
                new Point2d(-profile.Thickness / 2 + profile.TopFlangeWidth, profile.Height / 2 - profile.TopLip),
                new Point2d(-profile.Thickness * 1.5 + profile.TopFlangeWidth, profile.Height / 2 - profile.TopLip),
                new Point2d(-profile.Thickness * 1.5 + profile.TopFlangeWidth, profile.Height / 2 - profile.Thickness),
                new Point2d(profile.Thickness / 2, profile.Height / 2 - profile.Thickness),
                new Point2d(profile.Thickness / 2, -profile.Height / 2),
                new Point2d(profile.Thickness / 2 - profile.BottomFlangeWidth, -profile.Height / 2),
                new Point2d(profile.Thickness / 2 - profile.BottomFlangeWidth, -profile.Height / 2 + profile.BottomLip),
                new Point2d(profile.Thickness * 1.5 - profile.BottomFlangeWidth, -profile.Height / 2 + profile.BottomLip),
                new Point2d(profile.Thickness * 1.5 - profile.BottomFlangeWidth, -profile.Height / 2 + profile.Thickness),
                new Point2d(-profile.Thickness / 2, -profile.Height / 2 + profile.Thickness),
                new Point2d(-profile.Thickness / 2, profile.Height / 2),
            });
        }
    }
}
