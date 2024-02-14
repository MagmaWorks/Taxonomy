using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface ICircularHollow : ICircle
    {
        Length Thickness { get; }
    }
}
