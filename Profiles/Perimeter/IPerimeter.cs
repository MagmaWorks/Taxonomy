using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IPerimeter : IProfile
    {
        ILocalPolyline2d OuterEdge { get; }
        IList<ILocalPolyline2d> VoidEdges { get; }
    }
}
