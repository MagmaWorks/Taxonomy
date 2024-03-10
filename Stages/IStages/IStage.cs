namespace MagmaWorks.Taxonomy.Stages
{
    public interface IStage
    {
        string Name { get; }
        string Description { get; }
        string Id { get; }
        IGovernance Governance { get; }
    }
}
