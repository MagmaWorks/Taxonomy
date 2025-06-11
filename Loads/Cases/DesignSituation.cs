namespace MagmaWorks.Taxonomy.Loads
{
    public class DesignSituation : IDesignSituation
    {
        public DesignSituationClass Class { get; set; }

        public double UnfavourablePermanentActionsPartialFactor { get; set; } = 1.0;

        public double FavourablePermanentActionsPartialFactor { get; set; } = 1.0;

        public double PrestressPartialFactor { get; set; } = 1.0;
        public double LeadingActionPartialFactor { get; set; } = 1.0;
        public double MainAccompanyingVariableActionsPartialFactor { get; set; } = 1.0;

        public double OtherAccompanyingVariableActionsPartialFactor { get; set; } = 1.0;

        public double ReductionFactor { get; set; } = 1.0;

    }
}
