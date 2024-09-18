using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static (IPerimeter, IPerimeter) CreateDoubleAngle(IDoubleAngle profile)
        {
            IList<ILocalPoint2d> anglePoints = CreateAngle(profile).OuterEdge.Points;
            return PerimeterFactoryUtility.CreateBackToBackMirror(anglePoints, profile.BackToBackDistance);
        }
    }
}
