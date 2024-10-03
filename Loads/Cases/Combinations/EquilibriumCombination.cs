using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class EquilibriumCombination : IEquilibriumCombination
    {
        public string Name { get; set; }
        public string Definition => GetDefinition();
        public Ratio PermanentPartialFactor { get; set; }
        public Ratio LeadingVariablePartialFactor { get; set; }
        public Ratio AccompanyingPartialFactor { get; set; }
        public IList<IPermanentCase> PermanentCases { get; set; }
        public IList<IVariableCase> LeadingVariableCases { get; set; }
        public IList<IVariableCase> AccompanyingVariableCases { get; set; }

        public EquilibriumCombination() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            if (PermanentCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorLoads(PermanentPartialFactor, PermanentCases));
            }

            if (LeadingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorLoads(LeadingVariablePartialFactor, LeadingVariableCases));
            }

            if (AccompanyingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorAccompanyingVariableLoads(
                        AccompanyingPartialFactor, AccompanyingVariableCases, ld => ld.Characteristic));
            }

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
