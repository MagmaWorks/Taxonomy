using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class MemberDesignCombination : IMemberDesignCombination
    {
        public string Name { get; set; } = string.Empty;
        public string Definition => GetDefinition();
        public Ratio PermanentPartialFactor { get; set; } = new Ratio(1.35, RatioUnit.DecimalFraction);
        public Ratio PermanentReductionFactor { get; set; } = new Ratio(0.85, RatioUnit.DecimalFraction);
        public Ratio LeadingVariablePartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public Ratio AccompanyingPartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public IList<IPermanentCase> PermanentCases { get; set; } = new List<IPermanentCase>();
        public IList<IVariableCase> LeadingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> MainAccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> OtherAccompanyingVariableCases { get; set; } = new List<IVariableCase>();

        public MemberDesignCombination() : base() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(
                PermanentPartialFactor * PermanentReductionFactor.DecimalFractions, PermanentCases));
            factoredLoads.AddRange(
                Utility.FactorLoads(LeadingVariablePartialFactor, LeadingVariableCases));
            factoredLoads.AddRange(
                Utility.FactorAccompanyingVariableLoads(
                    LeadingVariablePartialFactor, OtherAccompanyingVariableCases, ld => ld.Characteristic));
            factoredLoads.AddRange(
                Utility.FactorAccompanyingVariableLoads(
                    AccompanyingPartialFactor, OtherAccompanyingVariableCases, ld => ld.Characteristic));
            return factoredLoads;
        }

        private string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, PermanentPartialFactor, PermanentReductionFactor);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, LeadingVariablePartialFactor);
            string main = Utility.DescriptionHelper(
                MainAccompanyingVariableCases, LeadingVariablePartialFactor, ld => ld.Characteristic);
            string other = Utility.DescriptionHelper(
                OtherAccompanyingVariableCases, AccompanyingPartialFactor, ld => ld.Characteristic);
            return Utility.JoinDescriptions(new string[] { perm, lead, main, other });
        }
    }
}
