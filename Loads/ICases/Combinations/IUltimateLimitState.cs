using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IUltimateLimitState : ILoadCombination
    {
        IList<IVariableCase> MainAccompanyingVariableCases { get; }
        IList<IVariableCase> OtherAccompanyingVariableCases { get; }
    }
}
