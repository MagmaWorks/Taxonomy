using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface IMemberDesignCombination : IUltimateLimitState
    {
        IList<IVariableCase> MainAccompanyingVariableCases { get; }
        IList<IVariableCase> OtherAccompanyingVariableCases { get; }
    }
}
