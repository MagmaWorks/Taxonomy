using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class EquilibriumCombination : LoadCombination, IEquilibriumCombination
    {
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IDesignSituation DesignSitation { get; set; } = new DesignSituation()
        {
            Class = DesignSituationClass.Accidental,

        };

        public EquilibriumCombination() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(DesignSitation, PermanentCases, PermanentCaseIsFavourable));
            factoredLoads.AddRange(Utility.FactorLoads(new Ratio(DesignSitation.LeadingActionPartialFactor,
                RatioUnit.DecimalFraction), LeadingVariableCases));
            factoredLoads.AddRange(Utility.FactorAccompanyingVariableLoads(new Ratio(
                DesignSitation.OtherAccompanyingVariableActionsPartialFactor, RatioUnit.DecimalFraction),
                AccompanyingVariableCases, ld => ld.CombinationFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, PermanentCaseIsFavourable, DesignSitation);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, new Ratio(DesignSitation.LeadingActionPartialFactor, RatioUnit.DecimalFraction));
            string other = Utility.DescriptionHelper(AccompanyingVariableCases,
                new Ratio(DesignSitation.OtherAccompanyingVariableActionsPartialFactor, RatioUnit.DecimalFraction), ld => ld.CombinationFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
