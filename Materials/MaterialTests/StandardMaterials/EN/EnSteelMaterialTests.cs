using MagmaWorks.Taxonomy.Serialization;

namespace MaterialTests.StandardMaterials.En
{
    public class EnSteelMaterialTests
    {
        [Fact]
        public void CreateStandardEnS235UKSteelMaterialTests()
        {
            // Assemble
            EnSteelGrade grade = EnSteelGrade.S235;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            IEnSteelMaterial material = new EnSteelMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(EnSteelGrade.S235, material.Grade);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1993, material.Standard.Code);
            Assert.Equal(
                "BS EN 1993-1-1: Eurocode 3: Design of Steel Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(MaterialType.Steel, material.Type);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 1.0, 1.0, 1.25)]
        [InlineData(NationalAnnex.Germany, 1.0, 1.1, 1.25)]
        [InlineData(NationalAnnex.UnitedKingdom, 1.0, 1.0, 1.1)]
        public void PartialFactorsTest(NationalAnnex na, double expectedGammaM0, double expectedGammaM1, double expectedGammaM2)
        {
            // Assemble
            EnSteelGrade grade = EnSteelGrade.S235;

            // Act
            IEnSteelMaterial material = new EnSteelMaterial(grade, na);

            // Assert
            Assert.Equal(expectedGammaM0, material.PartialFactor.DecimalFractions);
            Assert.Equal(expectedGammaM1, material.MemberInstabilityPartialFactor.DecimalFractions);
            Assert.Equal(expectedGammaM2, material.TensionFracturePartialFactor.DecimalFractions);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            IEnSteelMaterial material = new EnSteelMaterial(EnSteelGrade.S450, NationalAnnex.Germany);

            // Act
            string json = material.ToJson();
            IEnSteelMaterial matDeserialized = json.FromJson<IEnSteelMaterial>();

            // Assert
            Assert.Equivalent(material, matDeserialized);
        }
    }
}
