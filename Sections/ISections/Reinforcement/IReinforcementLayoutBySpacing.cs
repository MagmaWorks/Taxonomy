using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections
{
    public interface IReinforcementLayoutBySpacing : IReinforcementLayout
    {
        Length MaximumSpacing { get; }
    }
}
