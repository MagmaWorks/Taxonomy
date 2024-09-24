using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILine2dForce : ILoad
    {
        ForcePerLength X { get; }
        ForcePerLength Z { get; }
        LoadApplication Application { get; }
    }
}
