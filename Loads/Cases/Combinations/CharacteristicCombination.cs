using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class CharacteristicCombination : ICharacteristicCombination
    {
        public string Name { get; set; }
        public string Definition => GetDefinition();
        public IList<IPermanentCase> PermanentCases { get; set; }
        public IList<IVariableCase> LeadingVariableCases { get; set; }
        public IList<IVariableCase> AccompanyingVariableCases { get; set; }

        public CharacteristicCombination() { }

        public IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            if (PermanentCases != null)
            {
                factoredLoads.AddRange((IList<ILoad>)PermanentCases);
            }

            if (LeadingVariableCases != null)
            {
                factoredLoads.AddRange((IEnumerable<ILoad>)LeadingVariableCases);
            }

            if (AccompanyingVariableCases != null)
            {
                factoredLoads.AddRange(
                    Utility.SelectAccompanyingVariableLoads(
                        AccompanyingVariableCases, ld => ld.Characteristic));
            }

            return factoredLoads;
        }

        private string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, new Ratio(1, RatioUnit.DecimalFraction));
            string lead = Utility.DescriptionHelper(LeadingVariableCases, new Ratio(1, RatioUnit.DecimalFraction));
            string other = Utility.DescriptionHelper(
                    AccompanyingVariableCases, new Ratio(1, RatioUnit.DecimalFraction), ld => ld.Characteristic);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
