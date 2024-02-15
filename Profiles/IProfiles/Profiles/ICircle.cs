using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface ICircle : IProfile
    {
        Length Diameter { get; }
    }
}
