using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IRectangularHollow : IRectangle
    {
        Length Thickness { get; }
    }
}
