using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPointDisplacement : IPoint2dDisplacement
    {
        Length Y { get; }
    }
}
