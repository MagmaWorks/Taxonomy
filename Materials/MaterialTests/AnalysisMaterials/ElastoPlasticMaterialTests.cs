using MagmaWorks.Taxonomy.Materials;
using OasysUnits;

namespace MaterialTests
{
    public class ElastoPlasticMaterialTests
    {
        [Fact]
        public void CreateElastoPlasticMaterialTests()
        {
            // Assemble
            MaterialType type = MaterialType.Steel;
            Pressure elasticModulus = new Pressure(205, OasysUnits.Units.PressureUnit.Gigapascal);
            Pressure yieldStrength = new Pressure(355, OasysUnits.Units.PressureUnit.Megapascal);
            Pressure ultimateStrength = new Pressure(490, OasysUnits.Units.PressureUnit.Megapascal);
            Strain failureStrain = new Strain(0.2, OasysUnits.Units.StrainUnit.Percent);

            // Act
            IBiLinearMaterial material = new BiLinearMaterial(type, elasticModulus, yieldStrength, ultimateStrength, failureStrain);

            // Assert
            Assert.Equal(MaterialType.Steel, material.Type);
            Assert.Equal(205, material.ElasticModulus.Gigapascals);
            Assert.Equal(355, material.YieldStrength.Megapascals);
            Assert.Equal(490, material.UltimateStrength.Megapascals);
            Assert.Equal(0.2, material.FailureStrain.Percent);
            Assert.Equal(0.0017, material.YieldStrain.Ratio, 4);
        }

        [Fact]
        public void CreateElastoPlasticMaterialFromLinearElasticTests()
        {
            // Assemble
            MaterialType type = MaterialType.Steel;
            Pressure elasticModulus = new Pressure(205, OasysUnits.Units.PressureUnit.Gigapascal);
            Pressure yieldStrength = new Pressure(355, OasysUnits.Units.PressureUnit.Megapascal);
            Pressure ultimateStrength = new Pressure(490, OasysUnits.Units.PressureUnit.Megapascal);
            Strain failureStrain = new Strain(0.2, OasysUnits.Units.StrainUnit.Percent);

            // Act
            ILinearElasticMaterial linearElastic = new LinearElasticMaterial(type, elasticModulus, yieldStrength);
            IBiLinearMaterial material = new BiLinearMaterial(linearElastic, ultimateStrength, failureStrain);

            // Assert
            Assert.Equal(MaterialType.Steel, material.Type);
            Assert.Equal(205, material.ElasticModulus.Gigapascals);
            Assert.Equal(355, material.YieldStrength.Megapascals);
            Assert.Equal(490, material.UltimateStrength.Megapascals);
            Assert.Equal(0.2, material.FailureStrain.Percent);
            Assert.Equal(0.0017, material.YieldStrain.Ratio, 4);
        }
    }
}
