using System;
using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static class Utility
    {
        internal static List<IPoint2d> GetCirclePoints(Length diameter, int divisions, double factorU = 1, double factorV = 1)
        {
            Length radius = diameter / 2;
            double radian = 2 * Math.PI / divisions;
            var pts = new List<IPoint2d>();
            for (int i = divisions + 1; i-- > 0;)
            {
                pts.Add(new Point2d(
                    factorU * radius * Math.Cos(radian * i),
                    factorV * radius * Math.Sin(radian * i))
                );
            }

            return pts;
        }

        internal static void MovePoints(this List<IPoint2d> pts, Length u, Length v)
        {
            for (int i = 0; i < pts.Count; i++)
            {
                pts[i] = new Point2d(pts[i].U + u, pts[i].V + v);
            }
        }
    }
}
