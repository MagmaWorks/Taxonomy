using MagmaWorks.Taxonomy.Materials;

namespace MaterialTests.AnalysisMaterials
{
    public class LinearElasticMaterialTests
    {
        [Fact]
        public void CreateMaterialTests()
        {
            // Assemble
            MaterialType type = MaterialType.Timber;
            Stress elasticModulus = new Stress(8100, StressUnit.Megapascal);
            Stress strength = new Stress(32, StressUnit.Megapascal);

            // Act
            ILinearElasticMaterial material = new LinearElasticMaterial(type, elasticModulus, strength);

            // Assert
            Assert.Equal(MaterialType.Timber, material.Type);
            Assert.Equal(8.1, material.ElasticModulus.Gigapascals);
            Assert.Equal(32, material.Strength.Megapascals);
            Assert.Equal(0.00395, material.PeakStrain.DecimalFractions, 5);
        }
    }
}
