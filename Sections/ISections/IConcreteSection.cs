using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IConcreteSection : ISection
    {
        Length Cover { get; }
        IList<ILongitudinalReinforcement> Rebars { get; }
        IRebar Link { get; }
    }
}
