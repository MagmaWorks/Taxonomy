using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class GeotechnicalMemberDesignCombination : LoadCombination, IGeotechnicalMemberDesignCombination
    {
        public Ratio PermanentPartialFactor { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);
        public Ratio LeadingVariablePartialFactor { get; set; } = new Ratio(1.3, RatioUnit.DecimalFraction);
        public Ratio AccompanyingPartialFactor { get; set; } = new Ratio(1.3, RatioUnit.DecimalFraction);
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IDesignSituation DesignSitation { get; set; } = new DesignSituation()
        {
            Class = DesignSituationClass.PersistentAndTransient,
            LeadingActionPartialFactor = 1.5
        };

        public GeotechnicalMemberDesignCombination() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.FactorLoads(PermanentPartialFactor, PermanentCases));
            factoredLoads.AddRange(
                Utility.FactorLoads(LeadingVariablePartialFactor, LeadingVariableCases));
            factoredLoads.AddRange(Utility.FactorAccompanyingVariableLoads(
                AccompanyingPartialFactor, AccompanyingVariableCases, ld => ld.CombinationFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, PermanentPartialFactor);
            string lead = Utility.DescriptionHelper(LeadingVariableCases, LeadingVariablePartialFactor);
            string other = Utility.DescriptionHelper(
                AccompanyingVariableCases, AccompanyingPartialFactor, ld => ld.CombinationFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
