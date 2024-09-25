using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoadCombination : ICase
    {
        IList<ILoadCase> LoadCases { get; }
        IList<ILoad> GetFactoredLoads();
    }
}
