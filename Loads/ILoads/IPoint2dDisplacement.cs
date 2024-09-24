using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPoint2dDisplacement : ILoad
    {
        Length X { get; }
        Length Z { get; }
    }
}
