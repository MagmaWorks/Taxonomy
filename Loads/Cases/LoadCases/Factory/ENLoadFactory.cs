using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads
{
    public static partial class ENLoadFactory
    {
        public static IList<IEquilibriumCombination> CreateEquSetA(IList<ILoadCase> cases)
        {
            //return CreateEquSetA(cases, NationalAnnex.RecommendedValues);
        }

    }
}
