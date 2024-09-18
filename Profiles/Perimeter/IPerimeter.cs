using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IPerimeter : IProfile
    {
        ILocalPolygon2d OuterEdge { get; }
        IList<ILocalPolygon2d> VoidEdges { get; }
    }
}
