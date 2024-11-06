using System;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.EN
{
    public class ENConcreteMaterial : StandardMaterial, IENConcreteMaterial
    {
        public Ratio PartialFactor { get; private set; } = new Ratio(1.5, RatioUnit.DecimalFraction);
        public Ratio AccidentialPartialFactor { get; private set; } = new Ratio(1.2, RatioUnit.DecimalFraction);
        public Ratio LongTermCompressionFactor { get; private set; } = new Ratio(1.0, RatioUnit.DecimalFraction);
        public Ratio LongTermTensionFactor { get; private set; } = new Ratio(1.0, RatioUnit.DecimalFraction);

        public ENConcreteMaterial(ENConcreteGrade grade, NationalAnnex nationalAnnex)
            : base(MaterialType.Concrete, new EN1992(EN1992Part.Part1_1, nationalAnnex), grade)
        {
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
