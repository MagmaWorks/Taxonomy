using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IRectangle : IProfile
    {
        Length Height { get; }
        Length Width { get; }
    }
}
