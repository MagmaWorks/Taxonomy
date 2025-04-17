using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoad : ITaxonomySerializable
    {
        string Label { get; }
        ILoad Factor(Ratio factor);
    }
}
