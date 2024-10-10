using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface ISeismicCombination : IUltimateLimitState
    {
        Ratio LeadingSeismicPartialFactor { get; }
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
