using MagmaWorks.Geometry;
using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IPerimeter : IProfile
    {
        IPolygon2d OuterEdge { get; }
        IList<IPolygon2d> VoidEdges { get; }
    }
}
