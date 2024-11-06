using System;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.EN
{
    public class ENRebarMaterial : StandardMaterial, IENRebarMaterial
    {
        public Ratio PartialFactor { get; private set; } = new Ratio(1.15, RatioUnit.DecimalFraction);
        public Ratio AccidentialPartialFactor { get; private set; } = new Ratio(1.0, RatioUnit.DecimalFraction);

        public ENRebarMaterial(ENRebarGrade grade, NationalAnnex nationalAnnex)
            : base(MaterialType.Reinforcement, new EN1992(EN1992Part.Part1_1, nationalAnnex), grade)
        {
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
                    throw new NotImplementedException($"National Annex of {nationalAnnex} not implemented");
            }
        }
    }
}
