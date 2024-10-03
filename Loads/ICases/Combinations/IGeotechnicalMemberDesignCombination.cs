using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface IGeotechnicalMemberDesignCombination : IUltimateLimitState
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

        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
