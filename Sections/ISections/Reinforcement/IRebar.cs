using MagmaWorks.Taxonomy.Materials;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public interface IRebar
    {
        Length Diameter { get; }
        IMaterial Material { get; }
    }
}
