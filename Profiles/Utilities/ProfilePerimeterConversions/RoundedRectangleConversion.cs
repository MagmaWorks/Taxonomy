using System;
using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class RoundedRectangleConversion
    {
        internal static IPerimeter GetPerimeter<T>(this T profile) where T : IRoundedRectangle
        {
            return profile.GetPerimeter(new Length(10, OasysUnits.Units.LengthUnit.Millimeter));
        }

        public static IPerimeter GetPerimeter<T>(this T profile, Length tolerance) where T : IRoundedRectangle
        {
            Length filletRadius = (profile.Height - profile.FlatHeight) / 2;
            int divisions = (int)Math.Round(
                Math.PI * filletRadius / tolerance,
                MidpointRounding.AwayFromZero);
            return profile.GetPerimeter(divisions);
        }

        public static IPerimeter GetPerimeter<T>(this T profile, int filletDivisions) where T : IRoundedRectangle
        {
            if (profile is IRoundedRectangularHollow hollow)
            {
                return RoundedRectangularHollowConversion.GetPerimeter(hollow, filletDivisions);
            }

            Length filletRadius = (profile.Height - profile.FlatHeight) / 2;
            return new Perimeter(GetPoints(profile.Height, profile.Width, profile.FlatHeight, profile.FlatWidth, filletDivisions));
        }

        internal static List<IPoint2d> GetPoints(Length height, Length width, Length flatHeight, Length flatWidth, int filletDivisions)
        {
            Length filletRadiusW = (width - flatWidth) / 2;
            Length filletRadiusH = (height - flatHeight) / 2;
            List<IPoint2d> filletCircle = EllipseConversion.GetPoints(filletRadiusH * 2, filletRadiusW * 2, filletDivisions * 4);
            List<IPoint2d> fillet1 = filletCircle.GetRange(0, filletDivisions + 1);
            List<IPoint2d> fillet2 = filletCircle.GetRange(filletDivisions, filletDivisions + 1);
            List<IPoint2d> fillet3 = filletCircle.GetRange(2 * filletDivisions, filletDivisions + 1);
            List<IPoint2d> fillet4 = filletCircle.GetRange(3 * filletDivisions, filletDivisions + 1);
            for (int i = 0; i < filletDivisions + 1; i++)
            {
                fillet1[i] = new Point2d(fillet1[i].U + width / 2 - filletRadiusW, fillet1[i].V - height / 2 + filletRadiusH);
                fillet2[i] = new Point2d(fillet2[i].U - width / 2 + filletRadiusW, fillet2[i].V - height / 2 + filletRadiusH);
                fillet3[i] = new Point2d(fillet3[i].U - width / 2 + filletRadiusW, fillet3[i].V + height / 2 - filletRadiusH);
                fillet4[i] = new Point2d(fillet4[i].U + width / 2 - filletRadiusW, fillet4[i].V + height / 2 - filletRadiusH);
            }

            var pts = new List<IPoint2d>();
            pts.AddRange(fillet1);
            pts.AddRange(fillet2);
            pts.AddRange(fillet3);
            pts.AddRange(fillet4);
            pts.Add(pts[0]);
            return pts;
        }
    }
}
