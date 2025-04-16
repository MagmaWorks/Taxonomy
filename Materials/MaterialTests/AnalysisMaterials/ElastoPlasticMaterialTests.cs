using MagmaWorks.Taxonomy.Materials;

namespace MaterialTests.AnalysisMaterials
{
    public class ElastoPlasticMaterialTests
    {
        [Fact]
        public void CreateElastoPlasticMaterialTests()
        {
            // Assemble
            MaterialType type = MaterialType.Steel;
            Stress elasticModulus = new Stress(205, StressUnit.Gigapascal);
            Stress yieldStrength = new Stress(355, StressUnit.Megapascal);
            Stress ultimateStrength = new Stress(490, StressUnit.Megapascal);
            Strain failureStrain = new Strain(0.2, StrainUnit.Percent);

            // Act
            IBiLinearMaterial material = new BiLinearMaterial(type, elasticModulus, yieldStrength, ultimateStrength, failureStrain);

            // Assert
            Assert.Equal(MaterialType.Steel, material.Type);
            Assert.Equal(205, material.ElasticModulus.Gigapascals);
            Assert.Equal(355, material.YieldStrength.Megapascals);
            Assert.Equal(490, material.UltimateStrength.Megapascals);
            Assert.Equal(0.2, material.FailureStrain.Percent);
            Assert.Equal(0.0017, material.YieldStrain.DecimalFractions, 4);
        }

        [Fact]
        public void CreateElastoPlasticMaterialFromLinearElasticTests()
        {
            // Assemble
            MaterialType type = MaterialType.Steel;
            Stress elasticModulus = new Stress(205, StressUnit.Gigapascal);
            Stress yieldStrength = new Stress(355, StressUnit.Megapascal);
            Stress ultimateStrength = new Stress(490, StressUnit.Megapascal);
            Strain failureStrain = new Strain(0.2, StrainUnit.Percent);

            // Act
            ILinearElasticMaterial linearElastic = new LinearElasticMaterial(type, elasticModulus, yieldStrength);
            IBiLinearMaterial material = new BiLinearMaterial(linearElastic, ultimateStrength, failureStrain);

            // Assert
            Assert.Equal(MaterialType.Steel, material.Type);
            Assert.Equal(205, material.ElasticModulus.Gigapascals);
            Assert.Equal(355, material.YieldStrength.Megapascals);
            Assert.Equal(490, material.UltimateStrength.Megapascals);
            Assert.Equal(0.2, material.FailureStrain.Percent);
            Assert.Equal(0.0017, material.YieldStrain.DecimalFractions, 4);
        }
    }
}
