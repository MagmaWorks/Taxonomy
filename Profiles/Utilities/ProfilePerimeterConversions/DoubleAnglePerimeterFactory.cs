using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static (IPerimeter, IPerimeter) CreateDoubleAngle(IDoubleAngle profile)
        {
            IList<IPoint2d> anglePoints = CreateAngle(profile).OuterEdge.Points;
            return PerimeterFactoryUtility.CreateBackToBackMirror(anglePoints, profile.BackToBackDistance);
        }
    }
}
