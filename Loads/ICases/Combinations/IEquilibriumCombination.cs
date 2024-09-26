using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IEquilibriumCombination : IUltimateLimitState {
        Ratio PermanentPartialFactor { get; }
        Ratio LeadingVariablePartialFactor { get; }
        Ratio OtherVariablePartialFactor { get; }
    }
}
