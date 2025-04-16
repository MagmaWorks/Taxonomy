using MagmaWorks.Taxonomy.Sections.Reinforcement;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Sections
{
    public class MinimumReinforcementSpacing : IMinimumReinforcementSpacing
    {
        public Ratio BarDiameterFactor { get; set; } = new Ratio(1, RatioUnit.DecimalFraction);
        public Length AdditionalAggregateFactor { get; set; } = new Length(5, LengthUnit.Millimeter);
        public Length AbsoluteMinimumSpacing { get; set; } = new Length(20, LengthUnit.Millimeter);
        public Length MaximumAggregateSize { get; set; }

        public MinimumReinforcementSpacing() { }

        public MinimumReinforcementSpacing(NationalAnnex nationalAnnex)
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

        public Length GetMinimumReinforcementSpacing(Length barDiameter)
        {
            LengthUnit unit = barDiameter.Unit;
            double absMin = AbsoluteMinimumSpacing.As(unit);
            double aggMin = MaximumAggregateSize.As(unit) + AdditionalAggregateFactor.As(unit);
            double barMin = barDiameter.As(unit) * BarDiameterFactor.DecimalFractions;
            return new Length(Math.Max(absMin, Math.Max(aggMin, barMin)), unit);
        }
    }
}
