namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILineForce2d : ILoad
    {
        ForcePerLength X { get; }
        ForcePerLength Z { get; }
        LoadApplication Application { get; }
    }
}
