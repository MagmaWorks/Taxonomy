using MagmaWorks.Taxonomy.Serialization;

namespace MaterialTests.StandardMaterials.En
{
    public class EnRebarMaterialTests
    {
        [Fact]
        public void CreateStandardENB500BUKRebarMaterialTests()
        {
            // Assemble
            EnRebarGrade grade = EnRebarGrade.B500B;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            IEnRebarMaterial material = new EnRebarMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Reinforcement, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(
                "BS EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(EnRebarGrade.B500B, material.Grade);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 1.15, 1.0)]
        [InlineData(NationalAnnex.Germany, 1.15, 1.0)]
        [InlineData(NationalAnnex.UnitedKingdom, 1.15, 1.0)]
        public void PartialFactorsTest(NationalAnnex na, double expectedGammaS, double expectedGammaCAccidental)
        {
            // Assemble
            EnRebarGrade grade = EnRebarGrade.B500B;

            // Act
            IEnRebarMaterial material = new EnRebarMaterial(grade, na);

            // Assert
            Assert.Equal(expectedGammaS, material.PartialFactor.DecimalFractions);
            Assert.Equal(expectedGammaCAccidental, material.AccidentalPartialFactor.DecimalFractions);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            IEnRebarMaterial material = new EnRebarMaterial(EnRebarGrade.B550B, NationalAnnex.Germany);

            // Act
            string json = material.ToJson();
            IEnRebarMaterial matDeserialized = json.FromJson<IEnRebarMaterial>();

            // Assert
            Assert.Equivalent(material, matDeserialized);
        }
    }
}
