using System;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.EN
{
    public class ENConcreteMaterial : IENConcreteMaterial
    {
        public ENConcreteGrade Grade { get; set; } = ENConcreteGrade.C30_37;
        public IEurocode Standard { get; set; } = new EN1992(EN1992Part.Part1_1, NationalAnnex.RecommendedValues);
        public MaterialType Type => MaterialType.Concrete;
        public Ratio PartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public Ratio AccidentialPartialFactor { get; set; } = new Ratio(1.2, RatioUnit.DecimalFraction);
        public Ratio LongTermCompressionFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio LongTermTensionFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);

        public ENConcreteMaterial(ENConcreteGrade grade, NationalAnnex nationalAnnex)
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
                    break;

                case NationalAnnex.UnitedKingdom:
                    LongTermCompressionFactor = new Ratio(0.85, RatioUnit.DecimalFraction);
                    break;

                case NationalAnnex.Germany:
                    AccidentialPartialFactor = new Ratio(1.3, RatioUnit.DecimalFraction);
                    LongTermCompressionFactor = new Ratio(0.85, RatioUnit.DecimalFraction);
                    LongTermTensionFactor = new Ratio(0.85, RatioUnit.DecimalFraction);
                    break;

                default:
                    throw new NotImplementedException($"National Annex of {nationalAnnex} not implemented");
            }
        }
    }
}
