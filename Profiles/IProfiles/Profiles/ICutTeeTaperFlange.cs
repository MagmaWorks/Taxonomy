using OasysUnits;

namespace MagmaWorks.Taxonomy.Profiles
{
    public interface ICutTeeTaperFlange : ITee
    {
        Length FilletRadius { get; }
        Length ToeRadius { get; }
    }
}
