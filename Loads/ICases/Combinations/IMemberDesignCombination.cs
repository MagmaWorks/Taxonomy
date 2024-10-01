using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IMemberDesignCombination : IUltimateLimitState
    {
        /// <summary>
        /// γ_G,j (sup or inf) permanent partial factor
        /// </summary>
        Ratio PermanentPartialFactor { get; }

        /// <summary>
        /// γ_Q,1 variable partial factor
        /// </summary>
        Ratio LeadingVariablePartialFactor { get; }

        /// <summary>
        /// γ_Q,i other variable partial factor
        /// </summary>
        Ratio AccompanyingPartialFactor { get; }

        /// <summary>
        /// ξ permanent load reduction factor
        /// </summary>
        Ratio PermanentReductionFactor { get; }

        IList<IVariableCase> MainAccompanyingVariableCases { get; }
        IList<IVariableCase> OtherAccompanyingVariableCases { get; }
    }
}
