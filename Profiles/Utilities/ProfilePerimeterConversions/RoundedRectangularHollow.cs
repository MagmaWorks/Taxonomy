using System;
using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class RoundedRectangularHollowConversion
    {
        internal static IPerimeter GetPerimeters<T>(this T profile) where T : IRoundedRectangularHollow
        {
            return profile.GetPerimeters(new Length(10, OasysUnits.Units.LengthUnit.Millimeter));
        }

        internal static IPerimeter GetPerimeters<T>(this T profile, Length tolerance) where T : IRoundedRectangularHollow
        {
            Length filletRadius = (profile.Height - profile.FlatHeight) / 2;
            int divisions = (int)Math.Round(
                Math.PI * filletRadius / tolerance / 4,
                MidpointRounding.AwayFromZero);
            return profile.GetPerimeter(divisions);
        }

        internal static IPerimeter GetPerimeters<T>(this T profile, int divisions) where T : IRoundedRectangularHollow
        {
            Length filletRadius = (profile.Height - profile.FlatHeight) / 2;
            List<IPoint2d> outerEdge = RoundedRectangleConversion.GetPoints(profile.Height, profile.Width, filletRadius, divisions);
            List<IPoint2d> voidEdge = RoundedRectangleConversion.GetPoints(
                profile.Height - 2 * profile.Thickness, profile.Width - 2 * profile.Thickness, filletRadius - profile.Thickness, divisions);
            return new Perimeter(new Polygon2d(voidEdge), new List<IPolygon2d>() { new Polygon2d(voidEdge) });
        }
    }
}
