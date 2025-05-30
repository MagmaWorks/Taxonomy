using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public interface IEnSteelSpecification : ITaxonomySerializable
    {
        EnExecutionClass? ExecutionClassForStaticOrLowSeismicLoading { get; set; }
        EnExecutionClass? ExecutionClassForFatigueOrHighSeismicLoading { get; set; }
        EnSteelCorrosionResistance CorrosionResistance { get; set; }
        EnSteelDeliveryCondition? DeliveryCondition { get; set; }
        EnSteelFormingTemperature? FormingTemperature { get; set; }
        EnSteelImpactTemperatureProperty ImpactTemperatureProperty { get; set; }
        EnSteelQualityClass QualityClass { get; set; }
        bool? HollowSection { get; set; }
    }
}
