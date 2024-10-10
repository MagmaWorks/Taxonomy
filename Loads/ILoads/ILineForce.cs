using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILineForce : ILineForce2d
    {
        ForcePerLength Y { get; }
    }
}
