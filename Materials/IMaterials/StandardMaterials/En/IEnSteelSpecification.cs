using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public interface IEnSteelSpecification : ITaxonomySerializable
    {
        EnExecutionClass? ExecutionClassforStaticOrLowSeismicLoading { get; set; }
        EnExecutionClass? ExecutionClassforFatigueOrHighSeismicLoading { get; set; }
        EnSteelCorrosionResistance? CorrosionResistance { get; set; }
        EnSteelDeliveryCondition? DeliveryCondition { get; set; }
        EnSteelFormingTemperature? FormingTemperature { get; set; }
        EnSteelImpactTemperatureProperty? ImpactTemperatureProperty { get; set; }
        EnSteelQuality? Quality { get; set; }
        bool? HollowSection { get; set; }
    }
}
