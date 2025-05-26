using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IComposite : ITaxonomySerializable
    {
        ILocalPoint2d Position { get; }
    }
}
