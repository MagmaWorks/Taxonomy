using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MaterialTests
{
    public class LinearElasticMaterialFactoryTests
    {
        [Fact]
        public void CreateFromSelfTests()
        {
            // Assemble
            MaterialType type = MaterialType.Timber;
            Pressure elasticModulus = new Pressure(8100, PressureUnit.Megapascal);
            Pressure strength = new Pressure(32, PressureUnit.Megapascal);
            ILinearElasticMaterial original = new LinearElasticMaterial(type, elasticModulus, strength);

            // Act
            ILinearElasticMaterial material = AnalysisMaterialFactory.CreateLinearElastic(original);

            // Assert
            Assert.Equivalent(original, material);
        }

        [Fact]
        public void CreateFromENConcreteTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            ENConcreteGrade grade = ENConcreteGrade.C30_37;
            IStandardMaterial original = ENConcreteFactory.CreateStandardMaterial(grade, nationalAnnex);

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
            IStandardMaterial original = ENRebarFactory.CreateStandardMaterial(grade, nationalAnnex);

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
            IStandardMaterial original = ENSteelFactory.CreateStandardMaterial(grade, nationalAnnex);

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
