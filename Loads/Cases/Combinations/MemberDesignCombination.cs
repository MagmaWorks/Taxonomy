using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads
{
    public class MemberDesignCombination : IMemberDesignCombination
    {
        public string Name { get; set; }
        public Ratio PermanentPartialFactor { get; set; }
        public Ratio LeadingVariablePartialFactor { get; set; }
        public Ratio OtherVariablePartialFactor { get; set; }
        public IList<IPermanentCase> PermanentCases { get; set; }
        public IList<IVariableCase> LeadingVariableCases { get; set; }
        public IList<IVariableCase> AccompanyingVariableCases { get; set; }

        public MemberDesignCombination() { }
        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            foreach (ILoadCase loadCase in PermanentCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    factoredLoads.Add(load.Factor(PermanentPartialFactor));
                }
            }

            foreach (ILoadCase loadCase in LeadingVariableCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    factoredLoads.Add(load.Factor(LeadingVariablePartialFactor));
                }
            }

            foreach (ILoadCase loadCase in AccompanyingVariableCases)
            {
                foreach (ILoad load in loadCase.Loads)
                {
                    factoredLoads.Add(load.Factor(OtherVariablePartialFactor));
                }
            }

            return factoredLoads;
        }
    }
}
