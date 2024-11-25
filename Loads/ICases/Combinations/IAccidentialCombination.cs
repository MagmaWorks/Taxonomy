using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface IAccidentalCombination : IUltimateLimitState
    {
        bool UseFrequentCombinationFactorForMainAccompanying { get; }
        Ratio LeadingAccidentalPartialFactor { get; }
        IList<IVariableCase> MainAccompanyingVariableCases { get; }
        IList<IVariableCase> OtherAccompanyingVariableCases { get; }
    }
}
