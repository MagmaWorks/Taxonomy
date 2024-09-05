using MagmaWorks.Geometry;
using OasysUnits;
using System;
using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class EllipseHollowConversion
    {
        internal static IPerimeter GetPerimeters<T>(this T profile) where T : IEllipseHollow
        {
            return profile.GetPerimeters(new Length(10, OasysUnits.Units.LengthUnit.Millimeter));
        }

        internal static IPerimeter GetPerimeters<T>(this T profile, Length tolerance) where T : IEllipseHollow
        {
            Length max = profile.Height > profile.Width ? profile.Height : profile.Width;
            int divisions = (int)Math.Round(
                Math.PI * max / tolerance,
                MidpointRounding.AwayFromZero);
            return profile.GetPerimeter(divisions);
        }

        internal static IPerimeter GetPerimeters<T>(this T profile, int divisions) where T : IEllipseHollow
        {
            IList<IPoint2d> outerEdge = EllipseConversion.GetPoints(profile.Height, profile.Width, divisions);
            IList<IPoint2d> voidEdge = EllipseConversion.GetPoints(
                profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness, divisions);
            return new Perimeter(new Polygon2d(voidEdge), new List<IPolygon2d>() { new Polygon2d(voidEdge) });
        }
    }
}
