using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Serialization;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MaterialTests.StandardMaterials.EN
{
    public class ENSteelMaterialTests
    {
        [Fact]
        public void CreateStandardENS235UKSteelMaterialTests()
        {
            // Assemble
            ENSteelGrade grade = ENSteelGrade.S235;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            IENSteelMaterial material = new ENSteelMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(ENSteelGrade.S235, material.Grade);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1993, material.Standard.Code);
            Assert.Equal(
                "BS EN 1993-1-1: Eurocode 3: Design of Steel Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(MaterialType.Steel, material.Type);
            Assert.Equal(EnExecutionClass.EXC3, material.ExecutionClassforStaticOrLowSeismicLoading);
            Assert.Equal(EnExecutionClass.EXC3, material.ExecutionClassforFatigueOrHighSeismicLoading);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 1.0, 1.0, 1.25)]
        [InlineData(NationalAnnex.Germany, 1.0, 1.1, 1.25)]
        [InlineData(NationalAnnex.UnitedKingdom, 1.0, 1.0, 1.1)]
        public void PartialFactorsTest(NationalAnnex na, double expectedGammaM0, double expectedGammaM1, double expectedGammaM2)
        {
            // Assemble
            ENSteelGrade grade = ENSteelGrade.S235;

            // Act
            IENSteelMaterial material = new ENSteelMaterial(grade, na);

            // Assert
            Assert.Equal(expectedGammaM0, material.PartialFactor.DecimalFractions);
            Assert.Equal(expectedGammaM1, material.MemberInstabilityPartialFactor.DecimalFractions);
            Assert.Equal(expectedGammaM2, material.TensionFracturePartialFactor.DecimalFractions);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            IENSteelMaterial material = new ENSteelMaterial(ENSteelGrade.S450, NationalAnnex.Germany);

            // Act
            string json = material.ToJson();
            IENSteelMaterial matDeserialized = json.FromJson<IENSteelMaterial>();

            // Assert
            Assert.Equivalent(material, matDeserialized);
        }
    }
}
