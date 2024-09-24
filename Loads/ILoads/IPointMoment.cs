using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPointMoment : IPoint2dMoment
    {
        Moment Xx { get; }
    }
}
