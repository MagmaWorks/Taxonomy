using System;
using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class AccidentialCombination : IAccidentialCombination
    {
        public string Name { get; set; }
        public string Definition => GetDefinition();
        public bool UseFrequentCombinationFactorForMainAccompanying { get; set; } = true;
        public Ratio LeadingAccidentialPartialFactor { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);
        public IList<IPermanentCase> PermanentCases { get; set; }
        public IList<IVariableCase> LeadingVariableCases { get; set; }
        public IList<IVariableCase> MainAccompanyingVariableCases { get; set; }
        public IList<IVariableCase> OtherAccompanyingVariableCases { get; set; }

        public AccidentialCombination() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            if (PermanentCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorLoads(new Ratio(1.0, RatioUnit.DecimalFraction), PermanentCases));
            }

            if (LeadingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorLoads(LeadingAccidentialPartialFactor, LeadingVariableCases));
            }

            if (MainAccompanyingVariableCases != null)
            {
                if (UseFrequentCombinationFactorForMainAccompanying)
                {
                    factoredLoads.AddRange(
                    Utility.SelectAccompanyingVariableLoads(
                        MainAccompanyingVariableCases, ld => ld.Frequent));
                }
                else
                {
                    factoredLoads.AddRange(
                    Utility.SelectAccompanyingVariableLoads(
                        MainAccompanyingVariableCases, ld => ld.QuasiPermanent));
                }
            }

            if (OtherAccompanyingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.SelectAccompanyingVariableLoads(
                        OtherAccompanyingVariableCases, ld => ld.QuasiPermanent));
            }

            return factoredLoads;
        }

        private string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, new Ratio(1, RatioUnit.DecimalFraction));
            string lead = Utility.DescriptionHelper(LeadingVariableCases, LeadingAccidentialPartialFactor);
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
