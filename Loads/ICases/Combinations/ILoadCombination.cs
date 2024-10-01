using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoadCombination : ICase
    {
        string Definition { get; }
        IList<IPermanentCase> PermanentCases { get; }
        IList<IVariableCase> LeadingVariableCases { get; }
        IList<ILoad> GetFactoredLoads();
    }
}
