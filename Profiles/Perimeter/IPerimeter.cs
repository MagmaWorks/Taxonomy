using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IPerimeter : IProfile
    {
        IPolygon2d OuterEdge { get; }
        IList<IPolygon2d> VoidEdges { get; }
    }
}
