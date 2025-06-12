using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class GeotechnicalMemberDesignCombination : LoadCombination, IGeotechnicalMemberDesignCombination
    {
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IDesignSituation DesignSituation { get; set; } = new DesignSituation()
        {
            Class = DesignSituationClass.PersistentAndTransient,
            LeadingActionPartialFactor = 1.5
        };

        public GeotechnicalMemberDesignCombination() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(DesignSituation, PermanentCases, PermanentCaseIsFavourable));
            factoredLoads.AddRange(Utility.FactorLoads(CreateFactor(DesignSituation.LeadingActionPartialFactor), LeadingVariableCases));
            factoredLoads.AddRange(Utility.FactorAccompanyingVariableLoads(new Ratio(
                      DesignSituation.OtherAccompanyingVariableActionsPartialFactor, RatioUnit.DecimalFraction),
                      AccompanyingVariableCases, ld => ld.CombinationFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, PermanentCaseIsFavourable, DesignSituation);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, CreateFactor(DesignSituation.LeadingActionPartialFactor));
            string other = Utility.DescriptionHelper(AccompanyingVariableCases,
                new Ratio(DesignSituation.OtherAccompanyingVariableActionsPartialFactor, RatioUnit.DecimalFraction), ld => ld.CombinationFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
