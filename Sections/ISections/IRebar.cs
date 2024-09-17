using MagmaWorks.Taxonomy.Materials;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IRebar
    {
        Length Diameter { get; }
        IMaterial Material { get; }
    }
}
