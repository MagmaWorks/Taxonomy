using System.Collections.Generic;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IENConcreteMaterial : IENMaterial<ENConcreteGrade>
    {
        IList<ENConcreteExposureClass> ExposureClasses { get; }
        ENCementClass CementClass { get; }
        Length MaximumAggregateSize { get; }
        Length MaximumCrackWidth { get; }
        Length MinimumCover { get; }

        /// <summary>
        /// γc partial factor for concrete in Persistent and Transient design situations
        /// </summary>
        Ratio PartialFactor { get; }

        /// <summary>
        /// γc partial factor for concrete in Accidental design situations
        /// </summary>
        Ratio AccidentalPartialFactor { get; }

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
