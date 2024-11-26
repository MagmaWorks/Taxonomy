using System;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.EN
{
    public class ENRebarMaterial : IENRebarMaterial
    {
        public ENRebarGrade Grade { get; set; } = ENRebarGrade.B500B;
        public IEurocode Standard { get; set; } = new EN1992(EN1992Part.Part1_1, NationalAnnex.RecommendedValues);
        public MaterialType Type => MaterialType.Reinforcement;
        public Ratio PartialFactor { get; set; } = new Ratio(1.15, RatioUnit.DecimalFraction);
        public Ratio AccidentalPartialFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);

        public ENRebarMaterial(ENRebarGrade grade, NationalAnnex nationalAnnex)
        {
            Standard = new EN1992(EN1992Part.Part1_1, nationalAnnex);
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
