using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class EquilibriumCombination : IEquilibriumCombination
    {
        public string Name { get; set; } = string.Empty;
        public string Definition => GetDefinition();
        public Ratio PermanentPartialFactor { get; set; } = new Ratio(1.1, RatioUnit.DecimalFraction);
        public Ratio LeadingVariablePartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public Ratio AccompanyingPartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public IList<IPermanentCase> PermanentCases { get; set; } = new List<IPermanentCase>();
        public IList<IVariableCase> LeadingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();

        public EquilibriumCombination() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(PermanentPartialFactor, PermanentCases));
            factoredLoads.AddRange(
                Utility.FactorLoads(LeadingVariablePartialFactor, LeadingVariableCases));
            factoredLoads.AddRange(Utility.FactorAccompanyingVariableLoads(
                AccompanyingPartialFactor, AccompanyingVariableCases, ld => ld.Characteristic));
            return factoredLoads;
        }

        private string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, PermanentPartialFactor);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, LeadingVariablePartialFactor);
            string other = Utility.DescriptionHelper(
                AccompanyingVariableCases, AccompanyingPartialFactor, ld => ld.Characteristic);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
