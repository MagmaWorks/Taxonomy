using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Stages
{
    public interface IStage : ITaxonomySerializable
    {
        string Name { get; }
        string Description { get; }
        string Id { get; }
        IGovernance Governance { get; }
    }
}
