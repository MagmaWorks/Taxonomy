using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Serialization;

namespace SectionTests
{
    public class SectionTests
    {
        [Fact]
        public void CreateSteelSectionTest()
        {
            // Assemble
            IEnSteelMaterial material = new EnSteelMaterial(EnSteelGrade.S355, NationalAnnex.UnitedKingdom);
            ICatalogue profile = new HE500B();

            // Act
            ISection section = new Section(profile, material);

            // Assert
            Assert.Equivalent(profile, section.Profile);
            Assert.Equivalent(material, section.Material);
        }

        [Fact]
        public void CreateTimberSectionTest()
        {
            // Assemble
            Pressure elasticModulus = new Pressure(8100, PressureUnit.Megapascal);
            Pressure strength = new Pressure(32, PressureUnit.Megapascal);
            ILinearElasticMaterial material = new LinearElasticMaterial(MaterialType.Timber, elasticModulus, strength);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));

            // Act
            ISection section = new Section(profile, material);

            // Assert
            Assert.Equivalent(profile, section.Profile);
            Assert.Equivalent(material, section.Material);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            Pressure elasticModulus = new Pressure(8100, PressureUnit.Megapascal);
            Pressure strength = new Pressure(32, PressureUnit.Megapascal);
            ILinearElasticMaterial material = new LinearElasticMaterial(MaterialType.Timber, elasticModulus, strength);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            ISection section = new Section(profile, material);

            // Act
            string json = section.ToJson();
            ISection sectDeserialized = json.FromJson<ISection>();

            // Assert
            Assert.Equivalent(section, sectDeserialized);
        }
    }
}
