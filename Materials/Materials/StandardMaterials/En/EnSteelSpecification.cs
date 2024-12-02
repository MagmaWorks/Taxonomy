namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public class EnSteelSpecification : IEnSteelSpecification
    {
        public EnExecutionClass ExecutionClassforStaticOrLowSeismicLoading { get; set; } = EnExecutionClass.EXC3;
        public EnExecutionClass ExecutionClassforFatigueOrHighSeismicLoading { get; set; } = EnExecutionClass.EXC3;
        public EnSteelCorrosionResistance CorrosionResistance { get; set; } = EnSteelCorrosionResistance.None;
        public EnSteelDeliveryCondition DeliveryCondition { get; set; } = EnSteelDeliveryCondition.AR;
        public EnSteelFormingTemperature FormingTemperature { get; set; } = EnSteelFormingTemperature.HotRolled;
        public EnSteelImpactTemperatureProperty ImpactTemperatureProperty { get; set; } = EnSteelImpactTemperatureProperty.None;
        public EnSteelQuality Quality { get; set; } = EnSteelQuality.None;
        public bool HollowSection { get; set; } = false;

        public EnSteelSpecification() { }
    }
}
