namespace MagmaWorks.Taxonomy.Loads
{
    public interface IGravity2d : ILoad
    {
        Ratio X { get; }
        Ratio Z { get; }
    }
}
