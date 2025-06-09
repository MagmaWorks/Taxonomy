using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class QuasiPermanentCombination : IQuasiPermanentCombination
    {
        public string Name { get; set; } = string.Empty;
        public string Definition => GetDefinition();
        public IList<IPermanentCase> PermanentCases { get; set; } = new List<IPermanentCase>();
        public IList<IVariableCase> LeadingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();

        public QuasiPermanentCombination() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.GetLoads(PermanentCases));
            factoredLoads.AddRange(
                Utility.SelectAccompanyingVariableLoads(LeadingVariableCases, ld => ld.QuasiPermanentFactor));
            factoredLoads.AddRange(
                Utility.SelectAccompanyingVariableLoads(AccompanyingVariableCases, ld => ld.QuasiPermanentFactor));
            return factoredLoads;
        }

        private string GetDefinition()
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
