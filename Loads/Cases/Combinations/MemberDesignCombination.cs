using System;
using System.Collections.Generic;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads
{
    public class MemberDesignCombination : IMemberDesignCombination
    {
        public string Name { get; set; }
        public string Definition => GetDefinition();
        public Ratio PermanentPartialFactor { get; set; }
        public Ratio PermanentReductionFactor { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);
        public Ratio LeadingVariablePartialFactor { get; set; }
        public Ratio AccompanyingPartialFactor { get; set; }
        public IList<IPermanentCase> PermanentCases { get; set; }
        public IList<IVariableCase> LeadingVariableCases { get; set; }
        public IList<IVariableCase> MainAccompanyingVariableCases { get; set; }
        public IList<IVariableCase> OtherAccompanyingVariableCases { get; set; }

        public MemberDesignCombination() : base() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            if (PermanentCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorLoads(PermanentPartialFactor * PermanentReductionFactor.DecimalFractions, PermanentCases));
            }

            if (LeadingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorLoads(LeadingVariablePartialFactor, LeadingVariableCases));
            }

            if (MainAccompanyingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorAccompanyingVariableLoads(
                        LeadingVariablePartialFactor, OtherAccompanyingVariableCases, ld => ld.Characteristic));
            }

            if (OtherAccompanyingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorAccompanyingVariableLoads(
                        AccompanyingPartialFactor, OtherAccompanyingVariableCases, ld => ld.Characteristic));
            }

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
