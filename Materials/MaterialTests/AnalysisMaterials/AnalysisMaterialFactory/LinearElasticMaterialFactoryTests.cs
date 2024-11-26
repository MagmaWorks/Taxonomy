using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
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
            EnConcreteGrade grade = EnConcreteGrade.C30_37;
            IEnConcreteMaterial original = new EnConcreteMaterial(grade, nationalAnnex);

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
            EnRebarGrade grade = EnRebarGrade.B500B;
            IEnRebarMaterial original = new EnRebarMaterial(grade, nationalAnnex);

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
            EnSteelGrade grade = EnSteelGrade.S355;
            IEnSteelMaterial original = new EnSteelMaterial(grade, nationalAnnex);

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
