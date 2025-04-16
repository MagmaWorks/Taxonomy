namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public interface IMinimumReinforcementSpacing
    {
        Ratio BarDiameterFactor { get; set; }
        Length AdditionalAggregateFactor { get; set; }
        Length AbsoluteMinimumSpacing { get; set; }
        Length GetMinimumReinforcementSpacing(Length barDiameter);
    }
}
