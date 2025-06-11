using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface IGeotechnicalMemberDesignCombination : IUltimateLimitState
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
