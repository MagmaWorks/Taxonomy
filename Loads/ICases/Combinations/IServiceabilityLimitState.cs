using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface IServiceabilityLimitState : ILoadCombination
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
