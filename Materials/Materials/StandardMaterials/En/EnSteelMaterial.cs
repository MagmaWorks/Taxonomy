using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public class EnSteelMaterial : IEnSteelMaterial
    {
        public EnSteelGrade Grade { get; set; } = EnSteelGrade.S355;
        public IEurocode Standard { get; set; } = new En1993(En1993Part.Part1_1, NationalAnnex.RecommendedValues);
        public MaterialType Type => MaterialType.Steel;
        public EnExecutionClass ExecutionClassforStaticOrLowSeismicLoading { get; set; } = EnExecutionClass.EXC3;
        public EnExecutionClass ExecutionClassforFatigueOrHighSeismicLoading { get; set; } = EnExecutionClass.EXC3;
        public Ratio PartialFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio MemberInstabilityPartialFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio TensionFracturePartialFactor { get; set; } = new Ratio(1.25, RatioUnit.DecimalFraction);

        public EnSteelMaterial(EnSteelGrade grade, NationalAnnex nationalAnnex)
        {
            Grade = grade;
            Standard = new En1993(En1993Part.Part1_1, nationalAnnex);
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
                    throw new MissingNationalAnnexException(nationalAnnex);
            }
        }
    }
}
