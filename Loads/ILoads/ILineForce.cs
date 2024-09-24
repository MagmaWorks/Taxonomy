using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILineForce : ILine2dForce
    {
        ForcePerLength Y { get; }
    }
}
