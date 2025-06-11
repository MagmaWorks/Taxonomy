using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class SeismicCombination : LoadCombination, ISeismicCombination
    {
        public Ratio LeadingSeismicPartialFactor { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IDesignSituation DesignSitation { get; set; } = new DesignSituation()
        {
            Class = DesignSituationClass.Seismic,
            LeadingActionPartialFactor = 1.5
        };

        public SeismicCombination() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.GetLoads(PermanentCases));
            factoredLoads.AddRange(
                Utility.FactorLoads(LeadingSeismicPartialFactor, LeadingVariableCases));
            factoredLoads.AddRange(
                Utility.SelectAccompanyingVariableLoads(AccompanyingVariableCases, ld => ld.QuasiPermanentFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, new Ratio(1, RatioUnit.DecimalFraction));
            string lead = Utility.DescriptionHelper(LeadingVariableCases, LeadingSeismicPartialFactor);
            string other = Utility.DescriptionHelper(
                AccompanyingVariableCases, new Ratio(1, RatioUnit.DecimalFraction), ld => ld.QuasiPermanentFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
