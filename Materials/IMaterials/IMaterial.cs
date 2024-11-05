using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IMaterial : ITaxonomySerializable
    {
        MaterialType Type { get; }
    }
}
