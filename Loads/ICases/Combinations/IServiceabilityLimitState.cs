using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IServiceabilityLimitState : ILoadCombination
    {
        IList<IVariableCase> AccompanyingVariableCases { get; }
    }
}
