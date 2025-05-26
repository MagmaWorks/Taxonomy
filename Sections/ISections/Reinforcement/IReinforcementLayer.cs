using System.Collections.Generic;
using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public interface IReinforcementLayer : ITaxonomySerializable
    {
        IReinforcementLayout Layout { get; }
        IList<ILongitudinalReinforcement> GetRebars(ILocalPolyline2d path);
        ILocalPolyline2d GetPath(IProfile profile, Length offset);
    }
}
