namespace MagmaWorks.Taxonomy.Loads
{
    public interface IAreaForce : ILoad
    {
        ForcePerArea X { get; }
        ForcePerArea Y { get; }
        ForcePerArea Z { get; }
        LoadApplication Application { get; }
    }
}
