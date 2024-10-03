using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface IAccidentialCombination : IUltimateLimitState
    {
        bool UseFrequentCombinationFactorForMainAccompanying { get; }
        Ratio LeadingAccidentialPartialFactor { get; }
        IList<IVariableCase> MainAccompanyingVariableCases { get; }
        IList<IVariableCase> OtherAccompanyingVariableCases { get; }
    }
}
