using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MaterialTests.AnalysisMaterials
{
    public class LinearElasticMaterialFactoryTests
    {
        [Fact]
        public void CreateFromENConcreteTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            ENConcreteGrade grade = ENConcreteGrade.C30_37;
            IENConcreteMaterial original = new ENConcreteMaterial(grade, nationalAnnex);

            // Act
            ILinearElasticMaterial material = AnalysisMaterialFactory.CreateLinearElastic(original);

            // Assert
            double expectedStrength = 30;
            Assert.Equal(expectedStrength, material.Strength.Megapascals);

            double expectedStrain = 1.75;
            Assert.Equal(expectedStrain, material.PeakStrain.MilliStrain, 12);

            double expectedElasticModulus = expectedStrength / expectedStrain;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Concrete, material.Type);
        }

        [Fact]
        public void CreateFromENRebarTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            ENRebarGrade grade = ENRebarGrade.B500B;
            IENRebarMaterial original = new ENRebarMaterial(grade, nationalAnnex);

            // Act
            ILinearElasticMaterial material = AnalysisMaterialFactory.CreateLinearElastic(original);

            // Assert
            double expectedStrength = 500;
            Assert.Equal(expectedStrength, material.Strength.Megapascals);

            double expectedElasticModulus = 200;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Reinforcement, material.Type);
        }

        [Fact]
        public void CreateFromENSteelTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            ENSteelGrade grade = ENSteelGrade.S355;
            IENSteelMaterial original = new ENSteelMaterial(grade, nationalAnnex);

            // Act
            ILinearElasticMaterial material = AnalysisMaterialFactory.CreateLinearElastic(original);

            // Assert
            double expectedStrength = 355;
            Assert.Equal(expectedStrength, material.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, material.Type);
        }
    }
}
