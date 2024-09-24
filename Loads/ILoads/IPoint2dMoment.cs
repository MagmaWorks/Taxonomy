using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IPoint2dMoment : ILoad
    {
        Moment Yy { get; }
        Moment Zz { get; }
    }
}
