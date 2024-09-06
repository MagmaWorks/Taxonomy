using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class DoubleAngleConversion
    {
        public static (IPerimeter, IPerimeter) GetPerimeters<T>(this T profile) where T : IDoubleAngle
        {
            return GetBackToBackPerimeter(((IAngle)profile).GetPerimeter().OuterEdge.Points, profile.BackToBackDistance);
            
        }

        internal static (IPerimeter, IPerimeter) GetBackToBackPerimeter(IList<IPoint2d> original, Length backToBackDistance)
        {
            var mirror = new List<IPoint2d>();
            for (int i = 0; i < original.Count; i++)
            {
                original[i] = new Point2d(original[i].U + backToBackDistance / 2, original[i].V);
                mirror.Add(new Point2d(-original[i].U, original[i].V));
            }

            return (new Perimeter(original), new Perimeter(mirror));
        }
    }
}
