using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class SeismicCombination : ISeismicCombination
    {
        public string Name { get; set; }
        public string Definition => GetDefinition();
        public Ratio LeadingSeismicPartialFactor { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);
        public IList<IPermanentCase> PermanentCases { get; set; }
        public IList<IVariableCase> LeadingVariableCases { get; set; }
        public IList<IVariableCase> AccompanyingVariableCases { get; set; }

        public SeismicCombination() { }

        public virtual IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            if (PermanentCases != null)
            {
                factoredLoads.AddRange((IList<ILoad>)PermanentCases);
            }

            if (LeadingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.FactorLoads(LeadingSeismicPartialFactor, LeadingVariableCases));
            }

            if (AccompanyingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.SelectAccompanyingVariableLoads(
                        AccompanyingVariableCases, ld => ld.QuasiPermanent));
            }

            return factoredLoads;
        }

        private string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, new Ratio(1, RatioUnit.DecimalFraction));
            string lead = Utility.DescriptionHelper(LeadingVariableCases, LeadingSeismicPartialFactor);
            string other = Utility.DescriptionHelper(
                    AccompanyingVariableCases, new Ratio(1, RatioUnit.DecimalFraction), ld => ld.QuasiPermanent);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
