using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IAreaForce : ILoad
    {
        Pressure X { get; }
        Pressure Y { get; }
        Pressure Z { get; }
        LoadApplication Application { get; }
    }
}
