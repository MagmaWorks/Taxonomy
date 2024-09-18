using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Profiles;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface ISection
    {
        IMaterial Material { get; }
        IProfile Profile { get; }
    }
}
