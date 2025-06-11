using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface ISeismicCombination : IUltimateLimitState
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
