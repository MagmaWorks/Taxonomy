using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public interface IEnRebarMaterial : IEnMaterial
    {
        EnRebarGrade Grade { get; }

        /// <summary>
        /// γs partial factor for reinforcement in Persistent and Transient design situations
        /// </summary>
        Ratio PartialFactor { get; }

        /// <summary>
        /// γs partial factor for reinforcement in Accidental design situations
        /// </summary>
        Ratio AccidentalPartialFactor { get; }
    }
}
