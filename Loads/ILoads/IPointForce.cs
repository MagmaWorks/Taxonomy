using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPointForce : IPoint2dForce
    {
        Force Y { get; }
    }
}
