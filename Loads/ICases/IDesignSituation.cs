namespace MagmaWorks.Taxonomy.Loads
{
    public interface IDesignSituation
    {
        DesignSituationClass Class { get; }
        double UnfavourablePermanentActionsPartialFactor { get; }
        double FavourablePermanentActionsPartialFactor { get; }
        double LeadingActionPartialFactor { get; }
        double MainAccompanyingVariableActionsPartialFactor { get; }
        double OtherAccompanyingVariableActionsPartialFactor { get; }
        double ReductionFactor { get; }
        double PrestressPartialFactor { get; }
    }
}
