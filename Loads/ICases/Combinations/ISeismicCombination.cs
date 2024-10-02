using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ISeismicCombination : IUltimateLimitState
    {
        Ratio LeadingSeismicPartialFactor { get; }
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
