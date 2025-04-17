using System;
using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class AccidentalCombination : IAccidentalCombination
    {
        public string Name { get; set; } = string.Empty;
        public string Definition => GetDefinition();
        public bool UseFrequentCombinationFactorForMainAccompanying { get; set; } = true;
        public Ratio LeadingAccidentalPartialFactor { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);
        public IList<IPermanentCase> PermanentCases { get; set; } = new List<IPermanentCase>();
        public IList<IVariableCase> LeadingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> MainAccompanyingVariableCases { get; set; } = new List<IVariableCase>();
        public IList<IVariableCase> OtherAccompanyingVariableCases { get; set; } = new List<IVariableCase>();

        public AccidentalCombination() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.GetLoads(PermanentCases));
            factoredLoads.AddRange(
                Utility.FactorLoads(LeadingAccidentalPartialFactor, LeadingVariableCases));
            if (UseFrequentCombinationFactorForMainAccompanying)
            {
                factoredLoads.AddRange(Utility.SelectAccompanyingVariableLoads(
                    MainAccompanyingVariableCases, ld => ld.Frequent));
            }
            else
            {
                factoredLoads.AddRange(Utility.SelectAccompanyingVariableLoads(
                    MainAccompanyingVariableCases, ld => ld.QuasiPermanent));
            }

            factoredLoads.AddRange(Utility.SelectAccompanyingVariableLoads(
                    OtherAccompanyingVariableCases, ld => ld.QuasiPermanent));
            return factoredLoads;
        }

        private string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, new Ratio(1, RatioUnit.DecimalFraction));
            string lead = Utility.DescriptionHelper(LeadingVariableCases, LeadingAccidentalPartialFactor);
            Func<IVariableCase, Ratio> selector = ld => ld.QuasiPermanent;
            if (UseFrequentCombinationFactorForMainAccompanying)
            {
                selector = ld => ld.Frequent;
            }

            string main = Utility.DescriptionHelper(
                MainAccompanyingVariableCases, new Ratio(1, RatioUnit.DecimalFraction), selector);
            string other = Utility.DescriptionHelper(
                OtherAccompanyingVariableCases, new Ratio(1, RatioUnit.DecimalFraction), ld => ld.QuasiPermanent);
            return Utility.JoinDescriptions(new string[] { perm, lead, main, other });
        }
    }
}
