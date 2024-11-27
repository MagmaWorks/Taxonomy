using System.Collections.Generic;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public class EnConcreteMaterial : IEnConcreteMaterial
    {
        public IList<EnConcreteExposureClass> ExposureClasses { get; set; } = new List<EnConcreteExposureClass> { EnConcreteExposureClass.XC1 };
        public EnCementClass CementClass { get; set; } = EnCementClass.N;
        public EnConcreteGrade Grade { get; set; } = EnConcreteGrade.C30_37;
        public IEurocode Standard { get; set; } = new En1992(En1992Part.Part1_1, NationalAnnex.RecommendedValues);
        public MaterialType Type => MaterialType.Concrete;
        public Length MaximumAggregateSize { get; set; } = new Length(20, LengthUnit.Millimeter);
        public Length CrackWidthLimit { get; set; } = new Length(0.3, LengthUnit.Millimeter);
        public Length MinimumCover { get; set; } = new Length(30, LengthUnit.Millimeter);
        public Ratio PartialFactor { get; set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public Ratio AccidentalPartialFactor { get; set; } = new Ratio(1.2, RatioUnit.DecimalFraction);
        public Ratio LongTermCompressionFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio LongTermTensionFactor { get; set; } = new Ratio(1.0, RatioUnit.DecimalFraction);

        private EnConcreteMaterial() { }

        public EnConcreteMaterial(EnConcreteGrade grade, NationalAnnex nationalAnnex)
        {
            Standard = new En1992(En1992Part.Part1_1, nationalAnnex);
            Grade = grade;
            SetPartialFactors(nationalAnnex);
        }

        public EnConcreteMaterial(EnConcreteGrade grade, NationalAnnex nationalAnnex,
            EnConcreteExposureClass exposureClass, Length maxAggregateSize, EnCementClass cementClass)
        {
            Standard = new En1992(En1992Part.Part1_1, nationalAnnex);
            Grade = grade;
            CementClass = cementClass;
            ExposureClasses = new List<EnConcreteExposureClass>() { exposureClass };
            MaximumAggregateSize = maxAggregateSize;
            SetPartialFactors(nationalAnnex);
        }

        public EnConcreteMaterial(EnConcreteGrade grade, NationalAnnex nationalAnnex,
            EnConcreteExposureClass exposureClass, Length maxAggregateSize,
            EnCementClass cementClass, Length crackWidthLimit, Length minimumCover)
        {
            Standard = new En1992(En1992Part.Part1_1, nationalAnnex);
            Grade = grade;
            CementClass = cementClass;
            ExposureClasses = new List<EnConcreteExposureClass>() { exposureClass };
            MaximumAggregateSize = maxAggregateSize;
            CrackWidthLimit = crackWidthLimit;
            MinimumCover = minimumCover;
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
                    AccidentalPartialFactor = new Ratio(1.3, RatioUnit.DecimalFraction);
                    LongTermCompressionFactor = new Ratio(0.85, RatioUnit.DecimalFraction);
                    LongTermTensionFactor = new Ratio(0.85, RatioUnit.DecimalFraction);
                    break;

                default:
                    throw new MissingNationalAnnexException(nationalAnnex);
            }
        }
    }
}
