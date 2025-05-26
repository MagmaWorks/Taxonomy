using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public interface IReinforcementLayout : ITaxonomySerializable
    {
        IRebar Rebar { get; }
    }
}
