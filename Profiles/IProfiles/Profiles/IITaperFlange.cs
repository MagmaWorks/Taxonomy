using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface IITaperFlange : II
    {
        Length FilletRadius { get; }
        Length ToeRadius { get; }
        Length WebHeight { get; }
    }
}
