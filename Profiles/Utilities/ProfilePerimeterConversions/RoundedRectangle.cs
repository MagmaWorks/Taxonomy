using System;
using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class RoundedRectangleConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : IRoundedRectangle
        {
            return profile.GetPerimeter(new Length(10, OasysUnits.Units.LengthUnit.Millimeter));
        }

        public static IPerimeter GetPerimeter<T>(this T profile, Length tolerance) where T : IRoundedRectangle
        {
            Length filletRadius = (profile.Height - profile.FlatHeight) / 2;
            int divisions = (int)Math.Round(
                Math.PI * filletRadius / tolerance / 4,
                MidpointRounding.AwayFromZero);
            return profile.GetPerimeter(divisions);
        }

        public static IPerimeter GetPerimeter<T>(this T profile, int filletDivisions) where T : IRoundedRectangle
        {
            Length filletRadius = (profile.Height - profile.FlatHeight) / 2;
            return new Perimeter(GetPoints(profile.Height, profile.Width, filletRadius, filletDivisions));
        }

        internal static List<IPoint2d> GetPoints(Length height, Length width, Length filletRadius, int filletDivisions)
        {
            List<IPoint2d> filletCircle = CircleConversion.GetPoints(filletRadius * 2, filletDivisions * 4);
            List<IPoint2d> fillet1 = filletCircle.GetRange(0, filletDivisions);
            List<IPoint2d> fillet2 = filletCircle.GetRange(1 * filletDivisions, 2 * filletDivisions);
            List<IPoint2d> fillet3 = filletCircle.GetRange(2 * filletDivisions, 3 * filletDivisions);
            List<IPoint2d> fillet4 = filletCircle.GetRange(3 * filletDivisions, 4 * filletDivisions);
            for (int i = 0; i < filletDivisions; i++)
            {
                fillet1[i] = new Point2d(fillet1[i].U - width + filletRadius, fillet1[i].V + height - filletRadius);
                fillet2[i] = new Point2d(fillet2[i].U + width - filletRadius, fillet2[i].V + height - filletRadius);
                fillet3[i] = new Point2d(fillet3[i].U + width - filletRadius, fillet3[i].V - height + filletRadius);
                fillet4[i] = new Point2d(fillet4[i].U - width + filletRadius, fillet4[i].V - height + filletRadius);
            }

            var pts = new List<IPoint2d>();
            pts.AddRange(fillet1);
            pts.AddRange(fillet2);
            pts.AddRange(fillet3);
            pts.AddRange(fillet4);
            return pts;
        }
    }
}
