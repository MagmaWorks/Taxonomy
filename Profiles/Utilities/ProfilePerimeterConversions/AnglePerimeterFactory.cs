using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static IPerimeter CreateAngle(IAngle profile)
        {
            return new Perimeter(new List<IPoint2d>()
            {
                new Point2d(Length.Zero, Length.Zero),
                new Point2d(Length.Zero, profile.Height),
                new Point2d(profile.WebThickness, profile.Height),
                new Point2d(profile.WebThickness, profile.FlangeThickness),
                new Point2d(profile.Width, profile.FlangeThickness),
                new Point2d(profile.Width, Length.Zero),
                new Point2d(Length.Zero, Length.Zero),
            });
        }
    }
}
