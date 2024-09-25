using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IUltimateLimitState : ILoadCombination {
        /// <summary>
        /// γ_Q,1 - Leading variable action partial factor
        /// </summary>
        Ratio LeadingVariable { get; }

        /// <summary>
        /// γ_Q,i - Accompanying variable action partial factor
        /// </summary>
        Ratio OtherVariable { get; }
    }
}
