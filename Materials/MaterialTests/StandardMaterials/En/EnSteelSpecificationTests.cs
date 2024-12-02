using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Serialization;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MaterialTests.StandardMaterials.En
{
    public class EnSteelSpecificationTests
    {
        [Fact]
        public void CreateSpcificationTests()
        {
            // Assemble
            // Act
            IEnSteelSpecification spec = new EnSteelSpecification();

            // Assert
            Assert.Equal(EnExecutionClass.EXC3, spec.ExecutionClassforStaticOrLowSeismicLoading);
            Assert.Equal(EnExecutionClass.EXC3, spec.ExecutionClassforFatigueOrHighSeismicLoading);
            Assert.Equal(EnSteelDeliveryCondition.AR, spec.DeliveryCondition);
            Assert.False(spec.HollowSection);
            Assert.Equal(EnSteelFormingTemperature.HotRolled, spec.FormingTemperature);
            Assert.Equal(EnSteelImpactTemperatureProperty.None, spec.ImpactTemperatureProperty);
            Assert.Equal(EnSteelCorrosionResistance.None, spec.CorrosionResistance);
            Assert.Equal(EnSteelQuality.None, spec.Quality);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            IEnSteelSpecification spec = new EnSteelSpecification();

            // Act
            string json = spec.ToJson();
            IEnSteelSpecification matDeserialized = json.FromJson<IEnSteelSpecification>();

            // Assert
            Assert.Equivalent(spec, matDeserialized);
        }
    }
}
