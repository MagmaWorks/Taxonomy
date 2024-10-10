using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public interface ILoadCombination : ICase
    {
        string Definition { get; }
        IList<IPermanentCase> PermanentCases { get; }
        IList<IVariableCase> LeadingVariableCases { get; }
        IList<ILoad> GetFactoredLoads();
    }
}
