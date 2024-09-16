using MagmaWorks.Taxonomy.Materials;
using OasysUnits;

namespace MaterialTests
{
    public class LinearElasticMaterialTests
    {
        [Fact]
        public void CreateMaterialTests()
        {
            // Assemble
            MaterialType type = MaterialType.Timber;
            Pressure elasticModulus = new Pressure(8100, OasysUnits.Units.PressureUnit.Megapascal);
            Pressure strength = new Pressure(32, OasysUnits.Units.PressureUnit.Megapascal);

            // Act
            ILinearElasticMaterial material = new LinearElasticMaterial(type, elasticModulus, strength);

            // Assert
            Assert.Equal(MaterialType.Timber, material.Type);
            Assert.Equal(8.1, material.ElasticModulus.Gigapascals);
            Assert.Equal(32, material.Strength.Megapascals);
            Assert.Equal(0.00395, material.PeakStrain.Ratio, 5);
        }
    }
}
