using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Serialization.Materials.Extensions;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MaterialTests.StandardMaterials.EN
{
    public class ENRebarMaterialTests
    {
        [Fact]
        public void CreateStandardENB500BUKRebarMaterialTests()
        {
            // Assemble
            ENRebarGrade grade = ENRebarGrade.B500B;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            IENRebarMaterial material = new ENRebarMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Reinforcement, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1992, material.Standard.Code);
            Assert.Equal(
                "BS EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(NationalAnnex.UnitedKingdom, material.Standard.NationalAnnex);
            Assert.Equal(ENRebarGrade.B500B, material.Grade);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 1.15, 1.0)]
        [InlineData(NationalAnnex.Germany, 1.15, 1.0)]
        [InlineData(NationalAnnex.UnitedKingdom, 1.15, 1.0)]
        public void PartialFactorsTest(NationalAnnex na, double expectedGammaS, double expectedGammaCAccidential)
        {
            // Assemble
            ENRebarGrade grade = ENRebarGrade.B500B;

            // Act
            IENRebarMaterial material = new ENRebarMaterial(grade, na);

            // Assert
            Assert.Equal(expectedGammaS, material.PartialFactor.DecimalFractions);
            Assert.Equal(expectedGammaCAccidential, material.AccidentialPartialFactor.DecimalFractions);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            IENRebarMaterial material = new ENRebarMaterial(ENRebarGrade.B550B, NationalAnnex.Germany);

            // Act
            string json = material.ToJson();
            IENRebarMaterial matDeserialized = json.FromJson<IENRebarMaterial>();

            // Assert
            Assert.Equivalent(material, matDeserialized);
        }
    }
}
