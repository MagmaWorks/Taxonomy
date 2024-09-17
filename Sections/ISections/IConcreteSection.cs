using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IConcreteSection : ISection
    {
        ICollection<ILongitudinalReinforcement> Rebars { get; }
        IRebar Link { get; }
    }
}
