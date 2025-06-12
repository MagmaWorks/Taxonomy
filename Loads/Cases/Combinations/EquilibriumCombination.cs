using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class EquilibriumCombination : LoadCombination, IEquilibriumCombination
    {
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IDesignSituation DesignSituation { get; set; } = new DesignSituation()
        {
            Class = DesignSituationClass.Accidental,

        };

        public EquilibriumCombination() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(DesignSituation, PermanentCases, PermanentCaseIsFavourable));
            factoredLoads.AddRange(Utility.FactorLoads(CreateFactor(DesignSituation.LeadingActionPartialFactor), LeadingVariableCases));
            factoredLoads.AddRange(Utility.FactorAccompanyingVariableLoads(
                CreateFactor(DesignSituation.OtherAccompanyingVariableActionsPartialFactor),
                AccompanyingVariableCases, ld => ld.CombinationFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, PermanentCaseIsFavourable, DesignSituation);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, CreateFactor(DesignSituation.LeadingActionPartialFactor));
            string other = Utility.DescriptionHelper(AccompanyingVariableCases,
                CreateFactor(DesignSituation.OtherAccompanyingVariableActionsPartialFactor), ld => ld.CombinationFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
