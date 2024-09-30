using System;
using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    internal static class Utility
    {
        public static IList<ILoad> FactorLoads<T>(Ratio partialFactor, IList<T> loadCases)
            where T : ILoadCase
        {
            var factoredLoads = new List<ILoad>();
            foreach (T loadCase in loadCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    factoredLoads.Add(load.Factor(partialFactor));
                }
            }

            return factoredLoads;
        }

        public static IList<ILoad> FactorAccompanyingVariableLoads<T>(Ratio partialFactor, IList<T> loadCases, Func<T, Ratio> selector)
            where T : IVariableCase
        {
            var factoredLoads = new List<ILoad>();
            foreach (T loadCase in loadCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    Ratio factor = partialFactor * selector(loadCase).DecimalFractions;
                    factoredLoads.Add(load.Factor(factor));
                }
            }

            return factoredLoads;
        }
    }
}
