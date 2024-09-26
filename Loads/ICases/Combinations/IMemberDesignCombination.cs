using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IMemberDesignCombination : IUltimateLimitState {
        Ratio PermanentPartialFactor { get; }
        Ratio LeadingVariablePartialFactor { get; }
        Ratio OtherVariablePartialFactor { get; }
    }
}
