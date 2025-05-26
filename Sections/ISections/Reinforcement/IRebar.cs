using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public interface IRebar : ITaxonomySerializable
    {
        Length Diameter { get; }
        IMaterial Material { get; }
    }
}
