using MagmaWorks.Taxonomy.Materials;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IRebar
    {
        Length Diameter { get; }
        IMaterial Material { get; }
    }
}
