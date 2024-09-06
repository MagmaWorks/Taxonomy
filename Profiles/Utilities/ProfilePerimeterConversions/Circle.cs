using MagmaWorks.Geometry;
using OasysUnits;
using System;
using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class CircleConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : ICircle
        {
            return profile.GetPerimeter(new Length(10, OasysUnits.Units.LengthUnit.Millimeter));
        }

        public static IPerimeter GetPerimeter<T>(this T profile, Length tolerance) where T : ICircle
        {
            int divisions = (int)Math.Round(
                Math.PI * profile.Diameter / tolerance,
                MidpointRounding.AwayFromZero);
            return profile.GetPerimeter(divisions);
        }

        public static IPerimeter GetPerimeter<T>(this T profile, int divisions) where T : ICircle
        {
            if (profile is ICircularHollow hollow)
            {
                return CircularHollowConversion.GetPerimeters(hollow);
            }

            return new Perimeter(GetPoints(profile.Diameter, divisions));
        }

        internal static List<IPoint2d> GetPoints(Length diameter, int divisions)
        {
            Length radius = diameter / 2;
            double radian = 2 * Math.PI / divisions;
            var pts = new List<IPoint2d>();
            for (int i = 0; i < divisions + 1; i++)
            {
                pts.Add(new Point2d(
                    radius * Math.Cos(radian * i),
                    radius * Math.Sin(radian * i))
                );
            }

            return pts;
        }
    }
}
