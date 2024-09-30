using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoadCombination : ICase
    {
        IList<IPermanentCase> PermanentCases { get; }
        IList<IVariableCase> LeadingVariableCases { get; }
        IList<ILoad> GetFactoredLoads();
    }
}
