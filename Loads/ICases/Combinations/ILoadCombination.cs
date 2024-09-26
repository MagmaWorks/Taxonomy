using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoadCombination : ICase
    {
        IList<IPermanentCase> PermanentCases { get; }
        IList<IVariableCase> LeadingVariableCases { get; }
        IList<IVariableCase> AccompanyingVariableCases { get; }

        IList<ILoad> GetFactoredLoads();
    }
}
