using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class EquilibriumCombination : IEquilibriumCombination
    {
        public string Name { get; set; } = string.Empty;
        public string Definition => GetDefinition();
        public IList<IPermanentCase> PermanentCases { get; set; } = new List<IPermanentCase>();
        public IList<IVariableCase> LeadingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IDesignSituation DesignSitation { get; set; } = new DesignSituation()
        {
            Class = DesignSituationClass.Accidental,

        };

        public EquilibriumCombination() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(DesignSitation, PermanentCases));
            factoredLoads.AddRange(Utility.FactorLoads(DesignSitation, LeadingVariableCases));
            factoredLoads.AddRange(Utility.FactorAccompanyingVariableLoads(new Ratio(
                DesignSitation.MainAccompanyingVariableActionsPartialFactor, RatioUnit.DecimalFraction),
                AccompanyingVariableCases, ld => ld.CombinationFactor));
            return factoredLoads;
        }

        private string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, DesignSitation);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, new Ratio(DesignSitation.LeadingActionPartialFactor, RatioUnit.DecimalFraction));
            string other = Utility.DescriptionHelper(AccompanyingVariableCases,
                new Ratio(DesignSitation.OtherAccompanyingVariableActionsPartialFactor, RatioUnit.DecimalFraction), ld => ld.CombinationFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
