using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IChannel : IProfile
    {
        Length Height { get; }
        Length Width { get; }
        Length WebThickness { get; }
        Length FlangeThickness { get; }
    }
}
