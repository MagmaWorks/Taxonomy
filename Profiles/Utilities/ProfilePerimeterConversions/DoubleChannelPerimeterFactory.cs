using MagmaWorks.Geometry;
using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    internal static partial class PerimeterFactory
    {
        private static (IPerimeter, IPerimeter) CreateDoubleChannel(IDoubleChannel profile)
        {
            IList<IPoint2d> channelPoints = CreateChannel(profile).OuterEdge.Points;
            return PerimeterFactoryUtility.CreateBackToBackMirror(channelPoints, profile.BackToBackDistance);
        }
    }
}
