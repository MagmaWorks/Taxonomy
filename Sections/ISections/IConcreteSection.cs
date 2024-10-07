using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IConcreteSection : ISection
    {
        IList<ILongitudinalReinforcement> Rebars { get; }
        IRebar Link { get; }
    }
}
