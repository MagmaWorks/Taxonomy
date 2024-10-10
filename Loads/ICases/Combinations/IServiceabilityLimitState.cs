using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface IServiceabilityLimitState : ILoadCombination
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
