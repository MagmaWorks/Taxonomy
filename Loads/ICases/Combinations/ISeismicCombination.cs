using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;
using UnitsNet;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface ISeismicCombination : IUltimateLimitState
    {
        Ratio LeadingSeismicPartialFactor { get; }
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
