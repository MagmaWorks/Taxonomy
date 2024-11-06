using System;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.EN
{
    public class ENSteelMaterial : IENSteelMaterial
    {
        public ENSteelGrade Grade { get; set; } = ENSteelGrade.S355;
        public IEurocode Standard { get; set; } = new EN1993(EN1993Part.Part1_1, NationalAnnex.RecommendedValues);
        public MaterialType Type => MaterialType.Steel;
        public Ratio PartialFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio MemberInstabilityPartialFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio TensionFracturePartialFactor { get; set; } = new Ratio(1.25, RatioUnit.DecimalFraction);

        public ENSteelMaterial(ENSteelGrade grade, NationalAnnex nationalAnnex)
        {
            Standard = new EN1993(EN1993Part.Part1_1, nationalAnnex);
            Grade = grade;
            SetPartialFactors(nationalAnnex);
        }

        private void SetPartialFactors(NationalAnnex nationalAnnex)
        {
            switch (nationalAnnex)
            {
                case NationalAnnex.RecommendedValues:
                    break;

                case NationalAnnex.UnitedKingdom:
                    TensionFracturePartialFactor = new Ratio(1.1, RatioUnit.DecimalFraction);
                    break;

                case NationalAnnex.Germany:
                    MemberInstabilityPartialFactor = new Ratio(1.1, RatioUnit.DecimalFraction);
                    break;

                default:
                    throw new NotImplementedException($"National Annex of {nationalAnnex} not implemented");
            }
        }
    }
}
