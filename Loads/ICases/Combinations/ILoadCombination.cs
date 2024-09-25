using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface ILoadCombination : ICase
    {
        /// <summary>
        /// γ_G,j,inf - Favourable (inferior) partial factor
        /// </summary>
        Ratio Favourable { get; }

        /// <summary>
        /// γ_G,j,sup - Unfavourable (superior) partial factor
        /// </summary>
        Ratio Unfavourable { get; }
        IList<ILoadCase> LoadCases { get; }
        IList<ILoad> GetFactoredLoads();
    }
}
