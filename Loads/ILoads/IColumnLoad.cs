using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IColumnLoad : ILoad {
        Force Force { get; }
        IPoint2dMoment TopMoment { get; }
        IPoint2dMoment BottomMoment { get; }
    }
}
