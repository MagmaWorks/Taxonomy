using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static (IPerimeter, IPerimeter) CreateDoubleChannel(IDoubleChannel profile)
        {
            IList<ILocalPoint2d> channelPoints = CreateChannel(profile).OuterEdge.Points;
            return PerimeterFactoryUtility.CreateBackToBackMirror(channelPoints, profile.BackToBackDistance);
        }
    }
}
