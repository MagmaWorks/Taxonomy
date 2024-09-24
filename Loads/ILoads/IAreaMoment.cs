using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IAreaMoment : ILoad
    {
        Pressure Xx { get; }
        Pressure Yy { get; }
        Pressure Zz { get; }
        LoadApplication Application { get; }
    }
}
