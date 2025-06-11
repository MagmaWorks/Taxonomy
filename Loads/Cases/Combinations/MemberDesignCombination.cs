using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class MemberDesignCombination : LoadCombination, IMemberDesignCombination
    {
        public Ratio PermanentPartialFactor { get; set; } = new Ratio(1.35, RatioUnit.DecimalFraction);
        public Ratio PermanentReductionFactor { get; set; } = new Ratio(0.85, RatioUnit.DecimalFraction);
        public Ratio LeadingVariablePartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public Ratio AccompanyingPartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public IList<IVariableCase> MainAccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> OtherAccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IDesignSituation DesignSitation { get; set; } = new DesignSituation()
        {
            Class = DesignSituationClass.PersistentAndTransient,
            LeadingActionPartialFactor = 1.5
        };

        public MemberDesignCombination() : base() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(
                PermanentPartialFactor * PermanentReductionFactor.DecimalFractions, PermanentCases));
            factoredLoads.AddRange(
                Utility.FactorLoads(LeadingVariablePartialFactor, LeadingVariableCases));
            factoredLoads.AddRange(
                Utility.FactorAccompanyingVariableLoads(
                    LeadingVariablePartialFactor, OtherAccompanyingVariableCases, ld => ld.CombinationFactor));
            factoredLoads.AddRange(
                Utility.FactorAccompanyingVariableLoads(
                    AccompanyingPartialFactor, OtherAccompanyingVariableCases, ld => ld.CombinationFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, PermanentPartialFactor, PermanentReductionFactor);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, LeadingVariablePartialFactor);
            string main = Utility.DescriptionHelper(
                MainAccompanyingVariableCases, LeadingVariablePartialFactor, ld => ld.CombinationFactor);
            string other = Utility.DescriptionHelper(
                OtherAccompanyingVariableCases, AccompanyingPartialFactor, ld => ld.CombinationFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, main, other });
        }
    }
}
