using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface ISection : ITaxonomySerializable
    {
        IMaterial Material { get; }
        IProfile Profile { get; }
    }
}
