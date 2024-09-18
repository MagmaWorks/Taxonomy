using System;
using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static class PerimeterFactoryUtility
    {
        internal static int CalculateDivisions(Length radius, Length tolerance)
        {
            int divisions = (int)Math.Round(
                Math.PI * radius / tolerance,
                MidpointRounding.AwayFromZero);
            return Math.Max(8, divisions);
        }

        internal static List<ILocalPoint2d> CreateCirclePoints(Length diameter, int divisions, double factorU = 1, double factorV = 1)
        {
            Length radius = diameter / 2;
            double radian = 2 * Math.PI / divisions;
            var pts = new List<ILocalPoint2d>();
            for (int i = divisions + 1; i-- > 0;)
            {
                pts.Add(new LocalPoint2d(
                    factorU * radius * Math.Cos(radian * i),
                    factorV * radius * Math.Sin(radian * i))
                );
            }

            return pts;
        }

        internal static void MovePoints(this List<ILocalPoint2d> pts, Length y, Length z)
        {
            for (int i = 0; i < pts.Count; i++)
            {
                pts[i] = new LocalPoint2d(pts[i].Y + y, pts[i].Z + z);
            }
        }

        internal static List<ILocalPoint2d> CreateCustomIPoints(
            Length height, Length topWidth, Length bottomWidth,
            Length topFlangeThk, Length bottomFlangeThk, Length webThk)
        {
            return new List<ILocalPoint2d>()
            {
                new LocalPoint2d(-topWidth / 2, height / 2),
                new LocalPoint2d(topWidth / 2, height / 2),
                new LocalPoint2d(topWidth / 2, height / 2 - topFlangeThk),
                new LocalPoint2d(webThk / 2, height / 2 - topFlangeThk),
                new LocalPoint2d(webThk / 2, -height / 2 + bottomFlangeThk),
                new LocalPoint2d(bottomWidth / 2, -height / 2 + bottomFlangeThk),
                new LocalPoint2d(bottomWidth / 2, -height / 2),
                new LocalPoint2d(-bottomWidth / 2, -height / 2),
                new LocalPoint2d(-bottomWidth / 2, -height / 2 + bottomFlangeThk),
                new LocalPoint2d(-webThk / 2, -height / 2 + bottomFlangeThk),
                new LocalPoint2d(-webThk / 2, height / 2 - topFlangeThk),
                new LocalPoint2d(-topWidth / 2, height / 2 - topFlangeThk),
                new LocalPoint2d(-topWidth / 2, height / 2)
            };
        }

        internal static List<ILocalPoint2d> CreateEllipsePoints(Length height, Length width, int divisions)
        {
            bool isVertical = height > width;
            double factorU = isVertical ? width / height : 1;
            double factorV = isVertical ? 1 : height / width;
            Length diameter = isVertical ? height : width;
            return CreateCirclePoints(diameter, divisions, factorU, factorV);
        }

        internal static List<ILocalPoint2d> CreateRectanglePoints(Length height, Length width)
        {
            return new List<ILocalPoint2d>()
            {
                new LocalPoint2d(-width / 2, height / 2),
                new LocalPoint2d(width / 2, height / 2),
                new LocalPoint2d(width / 2, -height / 2),
                new LocalPoint2d(-width / 2, -height / 2),
                new LocalPoint2d(-width / 2, height / 2),
            };
        }

        internal static List<ILocalPoint2d> CreateRoundedRectanglePoints(Length height, Length width, Length flatHeight, Length flatWidth, int filletDivisions)
        {
            Length filletRadiusW = (width - flatWidth) / 2;
            Length filletRadiusH = (height - flatHeight) / 2;
            List<ILocalPoint2d> filletCircle = CreateEllipsePoints(filletRadiusH * 2, filletRadiusW * 2, filletDivisions * 4);
            List<ILocalPoint2d> fillet1 = filletCircle.GetRange(0, filletDivisions + 1);
            List<ILocalPoint2d> fillet2 = filletCircle.GetRange(filletDivisions, filletDivisions + 1);
            List<ILocalPoint2d> fillet3 = filletCircle.GetRange(2 * filletDivisions, filletDivisions + 1);
            List<ILocalPoint2d> fillet4 = filletCircle.GetRange(3 * filletDivisions, filletDivisions + 1);
            fillet1.MovePoints(width / 2 - filletRadiusW, -height / 2 + filletRadiusH);
            fillet2.MovePoints(-width / 2 + filletRadiusW, -height / 2 + filletRadiusH);
            fillet3.MovePoints(-width / 2 + filletRadiusW, height / 2 - filletRadiusH);
            fillet4.MovePoints(width / 2 - filletRadiusW, height / 2 - filletRadiusH);
            var pts = new List<ILocalPoint2d>();
            pts.AddRange(fillet1);
            pts.AddRange(fillet2);
            pts.AddRange(fillet3);
            pts.AddRange(fillet4);
            pts.Add(pts[0]);
            return pts;
        }

        internal static (IPerimeter, IPerimeter) CreateBackToBackMirror(IList<ILocalPoint2d> original, Length backToBackDistance)
        {
            var mirror = new List<ILocalPoint2d>();
            for (int i = 0; i < original.Count; i++)
            {
                original[i] = new LocalPoint2d(original[i].Y + backToBackDistance / 2, original[i].Z);
                mirror.Add(new LocalPoint2d(-original[i].Y, original[i].Z));
            }

            return (new Perimeter(original), new Perimeter(mirror));
        }
    }
}
