using System.Collections.Generic;
using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Profiles;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IReinforcementLayer
    {
        IReinforcementLayout Layout { get; }
        IList<ILongitudinalReinforcement> GetRebars(ILocalPolyline2d path);
        ILocalPolyline2d GetPath(IProfile profile, Length offset);
    }
}
