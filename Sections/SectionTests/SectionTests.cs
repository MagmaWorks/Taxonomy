using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Sections;
using MagmaWorks.Taxonomy.Serialization;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace SectionTests
{
    public class SectionTests
    {
        [Fact]
        public void CreateSteelSectionTest()
        {
            // Assemble
            IENSteelMaterial material = new ENSteelMaterial(ENSteelGrade.S355, NationalAnnex.UnitedKingdom);
            ICatalogue profile = new HE500B();

            // Act
            ISection section = new Section(material, profile);

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
            ISection section = new Section(material, profile);

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
            ISection section = new Section(material, profile);

            // Act
            string json = section.ToJson();
            ISection sectDeserialized = json.FromJson<ISection>();

            // Assert
            Assert.Equivalent(section, sectDeserialized);
        }
    }
}
