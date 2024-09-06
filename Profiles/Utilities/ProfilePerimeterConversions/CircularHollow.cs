using System;
using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class CircularHollowConversion
    {
        internal static IPerimeter GetPerimeters<T>(this T profile) where T : ICircularHollow
        {
            return profile.GetPerimeters(new Length(10, OasysUnits.Units.LengthUnit.Millimeter));
        }

        internal static IPerimeter GetPerimeters<T>(this T profile, Length tolerance) where T : ICircularHollow
        {
            int divisions = (int)Math.Round(
                Math.PI * profile.Diameter / tolerance,
                MidpointRounding.AwayFromZero);
            return profile.GetPerimeters(divisions);
        }

        internal static IPerimeter GetPerimeters<T>(this T profile, int divisions) where T : ICircularHollow
        {
            List<IPoint2d> outerEdge = CircleConversion.GetPoints(profile.Diameter, divisions);
            List<IPoint2d> voidEdge = CircleConversion.GetPoints(profile.Diameter - 2 * profile.Thickness, divisions);
            return new Perimeter(new Polygon2d(outerEdge), new List<IPolygon2d>() { new Polygon2d(voidEdge)});
        }
    }
}
