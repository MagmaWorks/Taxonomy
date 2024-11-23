using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IENRebarMaterial : IENMaterial<ENRebarGrade>
    {
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
