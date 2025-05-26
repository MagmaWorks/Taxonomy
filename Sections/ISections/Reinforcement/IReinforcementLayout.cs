using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IReinforcementLayout : ITaxonomySerializable
    {
        IRebar Rebar { get; }
    }
}
