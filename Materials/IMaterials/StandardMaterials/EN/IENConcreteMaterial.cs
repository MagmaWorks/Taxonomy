using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IENConcreteMaterial : IENMaterial<ENConcreteGrade>
    {
        ENConcreteExposureClass ExposureClass { get; }
        ENCementClass CementClass { get; }
        Length MaximumAggregateSize { get; }

        /// <summary>
        /// γc partial factor for concrete in Persistent and Transient design situations
        /// </summary>
        Ratio PartialFactor { get; }

        /// <summary>
        /// γc partial factor for concrete in Accidential design situations
        /// </summary>
        Ratio AccidentialPartialFactor { get; }

        /// <summary>
        /// αcc coefficient taking account of long term effects on the compressive strength
        /// </summary>
        Ratio LongTermCompressionFactor { get; }

        /// <summary>
        /// αct coefficient taking account of long term effects on the tension strength
        /// </summary>
        Ratio LongTermTensionFactor { get; }
    }
}
