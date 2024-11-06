using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IENRebarMaterial : IStandardMaterial
    {
        /// <summary>
        /// γs partial factor for reinforcement in Persistent and Transient design situations
        /// </summary>
        Ratio PartialFactor { get; }

        /// <summary>
        /// γs partial factor for reinforcement in Accidential design situations
        /// </summary>
        Ratio AccidentialPartialFactor { get; }
    }
}
