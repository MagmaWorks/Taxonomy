using System;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.EN
{
    public class ENConcreteMaterial : IENConcreteMaterial
    {
        public ENCementClass CementClass { get; set; } = ENCementClass.N;
        public ENConcreteExposureClass ExposureClass { get; set; } = ENConcreteExposureClass.XC1;
        public ENConcreteGrade Grade { get; set; } = ENConcreteGrade.C30_37;
        public IEurocode Standard { get; set; } = new EN1992(EN1992Part.Part1_1, NationalAnnex.RecommendedValues);
        public MaterialType Type => MaterialType.Concrete;
        public Length MaximumAggregateSize { get; set; } = new Length(20, LengthUnit.Millimeter);
        public Ratio PartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public Ratio AccidentialPartialFactor { get; set; } = new Ratio(1.2, RatioUnit.DecimalFraction);
        public Ratio LongTermCompressionFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio LongTermTensionFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);

        private ENConcreteMaterial() { }

        public ENConcreteMaterial(ENConcreteGrade grade, NationalAnnex nationalAnnex)
        {
            Standard = new EN1992(EN1992Part.Part1_1, nationalAnnex);
            Grade = grade;
            SetPartialFactors(nationalAnnex);
        }

        public ENConcreteMaterial(ENConcreteGrade grade, NationalAnnex nationalAnnex,
            ENConcreteExposureClass exposureClass, Length maxAggregateSize, ENCementClass cementClass)
        {
            CementClass = cementClass;
            Standard = new EN1992(EN1992Part.Part1_1, nationalAnnex);
            Grade = grade;
            ExposureClass = exposureClass;
            MaximumAggregateSize = maxAggregateSize;
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
                    throw new MissingNationalAnnexException(nationalAnnex);
            }
        }
    }
}
