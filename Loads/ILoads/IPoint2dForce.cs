using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPoint2dForce : ILoad  {
        Force X { get; }
        Force Z { get; }
    }
}
