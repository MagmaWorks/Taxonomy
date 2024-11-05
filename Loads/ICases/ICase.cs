using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ICase : ITaxonomySerializable
    {
        string Name { get; }
    }
}
