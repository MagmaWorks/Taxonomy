using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface ICruciform : IProfile
    {
        Length Height { get; }
        Length Width { get; }
        Length FlangeThickness { get; }
        Length WebThickness { get; }
    }
}
