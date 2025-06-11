using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public class CharacteristicCombination : LoadCombination, ICharacteristicCombination
    {
        public IList<IVariableCase> AccompanyingVariableCases { get; set; } = new List<IVariableCase>();

        public CharacteristicCombination() { }

        public override IList<ILoad> GetFactoredLoads()
        {
            var factoredLoads = new List<ILoad>();
            factoredLoads.AddRange(Utility.GetLoads(PermanentCases));
            factoredLoads.AddRange(Utility.GetLoads(LeadingVariableCases));
            factoredLoads.AddRange(
                Utility.SelectAccompanyingVariableLoads(AccompanyingVariableCases, ld => ld.CombinationFactor));
            return factoredLoads;
        }

        internal override string GetDefinition()
        {
            string perm = Utility.DescriptionHelper(PermanentCases, new Ratio(1, RatioUnit.DecimalFraction));
            string lead = Utility.DescriptionHelper(LeadingVariableCases, new Ratio(1, RatioUnit.DecimalFraction));
            string other = Utility.DescriptionHelper(
                AccompanyingVariableCases, new Ratio(1, RatioUnit.DecimalFraction), ld => ld.CombinationFactor);
            return Utility.JoinDescriptions(new string[] { perm, lead, other });
        }
    }
}
