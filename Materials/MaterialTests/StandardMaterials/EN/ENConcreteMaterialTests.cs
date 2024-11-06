using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Serialization.Materials.Extensions;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MaterialTests.StandardMaterials.EN
{
    public class ENConcreteMaterialTests
    {
        [Fact]
        public void CreateStandardENC40_50UKNAConcreteMaterialTests()
        {
            // Assemble
            ENConcreteGrade grade = ENConcreteGrade.C40_50;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            IENConcreteMaterial material = new ENConcreteMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Concrete, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1992, material.Standard.Code);
            Assert.Equal(
                "BS EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(ENConcreteGrade.C40_50, material.Grade);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 1.5, 1.2, 1.0, 1.0)]
        [InlineData(NationalAnnex.Germany, 1.5, 1.3, 0.85, 0.85)]
        [InlineData(NationalAnnex.UnitedKingdom, 1.5, 1.2, 0.85, 1.0)]
        public void PartialFactorsTest(NationalAnnex na, double expectedGammaC, double expectedGammaCAccidential, double expectedAlphaCC, double expectedAlphaCT)
        {
            // Assemble
            ENConcreteGrade grade = ENConcreteGrade.C40_50;

            // Act
            IENConcreteMaterial material = new ENConcreteMaterial(grade, na);

            // Assert
            Assert.Equal(expectedGammaC, material.PartialFactor.DecimalFractions);
            Assert.Equal(expectedGammaCAccidential, material.AccidentialPartialFactor.DecimalFractions);
            Assert.Equal(expectedAlphaCC, material.LongTermCompressionFactor.DecimalFractions);
            Assert.Equal(expectedAlphaCT, material.LongTermTensionFactor.DecimalFractions);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            IENConcreteMaterial material = new ENConcreteMaterial(ENConcreteGrade.C40_50, NationalAnnex.UnitedKingdom);

            // Act
            string json = material.ToJson();
            IENConcreteMaterial matDeserialized = json.FromJson<IENConcreteMaterial>();

            // Assert
            Assert.Equivalent(material, matDeserialized);
        }
    }
}
