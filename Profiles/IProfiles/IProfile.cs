using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IProfile : ITaxonomySerializable
    {
        string Description { get; }
    }
}
