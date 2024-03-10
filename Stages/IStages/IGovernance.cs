
using MagmaWorks.Taxonomy.Countries;

namespace MagmaWorks.Taxonomy.Stages
{
    public interface IGovernance
    {
        string Name { get; }
        string FullBodyName { get; }
        ICountry Country { get; }
    }
}
