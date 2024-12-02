using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public interface IEnSteelMaterial : IEnMaterial
    {
        IEnSteelSpecification Specification { get; }
        EnSteelGrade Grade { get; }

        /// <summary>
        /// γM0 partial factor for resistance of cross-sections whatever the class is
        /// </summary>
        Ratio PartialFactor { get; }

        /// <summary>
        /// γM1 partial factor for resistance of members to instability assessed by member checks
        /// </summary>
        Ratio MemberInstabilityPartialFactor { get; }

        /// <summary>
        /// γM2 partial factor for resistance of cross-sections in tension to fracture
        /// </summary>
        Ratio TensionFracturePartialFactor { get; }
    }
}
