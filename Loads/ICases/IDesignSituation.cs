using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Loads
{
    public interface IDesignSituation : ITaxonomySerializable
    {
        DesignSituationClass Class { get; }
        /// <summary>
        /// γ_G,j,sup permanent actions unfavourable partial factor
        /// </summary>
        double UnfavourablePermanentActionsPartialFactor { get; }
        /// <summary>
        /// γ_G,j,inf permanent actions favourable partial factor
        /// </summary>
        double FavourablePermanentActionsPartialFactor { get; }
        /// <summary>
        /// γ_Q,1 leading variable/accidental/seismic action partial factor
        /// </summary>
        double? LeadingActionPartialFactor { get; }
        /// <summary>
        /// γ_Q,1 main accompanying variable actions partial factor
        /// </summary>
        double? MainAccompanyingVariableActionsPartialFactor { get; }
        /// <summary>
        /// γ_Q,i other accompanying variable actions partial factor
        /// </summary>
        double OtherAccompanyingVariableActionsPartialFactor { get; }
        /// <summary>
        /// ξ permanent load reduction factor
        /// </summary>
        double ReductionFactor { get; }
    }
}
