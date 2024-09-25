using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPointMoment : IPointMoment2d
    {
        Moment Xx { get; }
    }
}
