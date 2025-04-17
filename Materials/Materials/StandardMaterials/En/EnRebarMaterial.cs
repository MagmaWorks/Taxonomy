using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public class EnRebarMaterial : IEnRebarMaterial
    {
        public EnRebarGrade Grade { get; set; } = EnRebarGrade.B500B;
        public IEurocode Standard { get; set; } = new En1992(En1992Part.Part1_1, NationalAnnex.RecommendedValues);
        public MaterialType Type => MaterialType.Reinforcement;
        public Ratio PartialFactor { get; set; } = new Ratio(1.15, RatioUnit.DecimalFraction);
        public Ratio AccidentalPartialFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);

        public EnRebarMaterial(EnRebarGrade grade, NationalAnnex nationalAnnex)
        {
            Standard = new En1992(En1992Part.Part1_1, nationalAnnex);
            Grade = grade;
            SetPartialFactors(nationalAnnex);
        }

        private void SetPartialFactors(NationalAnnex nationalAnnex)
        {
            switch (nationalAnnex)
            {
                case NationalAnnex.RecommendedValues:
                case NationalAnnex.UnitedKingdom:
                case NationalAnnex.Germany:
                    break;

                default:
                    throw new MissingNationalAnnexException(nationalAnnex);
            }
        }
    }
}
