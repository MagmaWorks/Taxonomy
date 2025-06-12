using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class MemberDesignCombination : LoadCombination, IMemberDesignCombination
    {
        public IList<IVariableCase> MainAccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> OtherAccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IDesignSituation DesignSituation { get; set; } = new DesignSituation()
        {
            Class = DesignSituationClass.PersistentAndTransient,
            LeadingActionPartialFactor = 1.5
        };

        public MemberDesignCombination() : base() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(DesignSituation, PermanentCases, PermanentCaseIsFavourable));
            factoredLoads.AddRange(Utility.FactorLoads(CreateFactor(DesignSituation.LeadingActionPartialFactor), LeadingVariableCases));
            factoredLoads.AddRange(Utility.FactorAccompanyingVariableLoads(CreateFactor(DesignSituation.LeadingActionPartialFactor), OtherAccompanyingVariableCases, ld => ld.CombinationFactor));
            factoredLoads.AddRange(
                Utility.FactorAccompanyingVariableLoads(
                    new Ratio(
                DesignSituation.OtherAccompanyingVariableActionsPartialFactor, RatioUnit.DecimalFraction), OtherAccompanyingVariableCases, ld => ld.CombinationFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, PermanentCaseIsFavourable, DesignSituation);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, CreateFactor(DesignSituation.LeadingActionPartialFactor));
            string main = Utility.DescriptionHelper(
                MainAccompanyingVariableCases, CreateFactor(DesignSituation.LeadingActionPartialFactor), ld => ld.CombinationFactor);
            string other = Utility.DescriptionHelper(
                OtherAccompanyingVariableCases, new Ratio(DesignSituation.OtherAccompanyingVariableActionsPartialFactor, RatioUnit.DecimalFraction), ld => ld.CombinationFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, main, other });
        }
    }
}
