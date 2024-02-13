using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IEllipseHollow : IEllipse
    {
        Length Thickness { get; }
    }
}
