using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class QuasiPermanentCombination : LoadCombination, IQuasiPermanentCombination
    {
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();

        public QuasiPermanentCombination() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.GetLoads(PermanentCases));
            factoredLoads.AddRange(
                Utility.SelectAccompanyingVariableLoads(LeadingVariableCases, ld => ld.QuasiPermanentFactor));
            factoredLoads.AddRange(
                Utility.SelectAccompanyingVariableLoads(AccompanyingVariableCases, ld => ld.QuasiPermanentFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, new Ratio(1, RatioUnit.DecimalFraction));
            string lead = Utility.DescriptionHelper(
                LeadingVariableCases, new Ratio(1, RatioUnit.DecimalFraction), ld => ld.FrequentFactor);
            string other = Utility.DescriptionHelper(
                AccompanyingVariableCases, new Ratio(1, RatioUnit.DecimalFraction), ld => ld.QuasiPermanentFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
