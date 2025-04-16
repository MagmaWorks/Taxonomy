using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MaterialTests.StandardMaterials
{
    public class EnConcreteFactoryTests
    {
        [Fact]
        public void CreateStandardENC30_37ConcreteMaterialTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            EnConcreteGrade grade = EnConcreteGrade.C30_37;

            // Act
            IEnConcreteMaterial material = new EnConcreteMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Concrete, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1992, material.Standard.Code);
            Assert.Equal(
                "EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(EnConcreteGrade.C30_37, material.Grade);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticTests(EnConcreteGrade grade)
        {
            // Assemble
            // Act
            ILinearElasticMaterial material = EnConcreteFactory.CreateLinearElastic(grade);

            // Assert
            double expectedStrength = double.Parse(grade.ToString().Split('C', '_')[1]);
            Assert.True((int)expectedStrength >= 12 && (int)expectedStrength <= 90);
            Assert.Equal(expectedStrength, material.Strength.Megapascals);

            double expectedStrain = expectedStrength <= 50 ? 1.75 : 1.75 + 0.55 * ((expectedStrength - 50) / 40);
            Assert.True((decimal)expectedStrain >= (decimal)1.75 && (decimal)expectedStrain <= (decimal)2.4);
            Assert.Equal(expectedStrain, material.PeakStrain.PartsPerThousand, 12);

            double expectedElasticModulus = expectedStrength / expectedStrain;
            Assert.True(expectedElasticModulus > 6 && expectedElasticModulus < 40);
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Concrete, material.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateParabolaRectangleTests(EnConcreteGrade grade)
        {
            // Assemble
            // Act
            IParabolaRectangleMaterial material = EnConcreteFactory.CreateParabolaRectangleAnalysisMaterial(grade);

            // Assert
            double expectedStrength = double.Parse(grade.ToString().Split('C', '_')[1]);
            Assert.True((int)expectedStrength >= 12 && (int)expectedStrength <= 90);
            Assert.Equal(expectedStrength, material.YieldStrength.Megapascals);

            double expectedEpsilon_c2 = expectedStrength <= 50 ? 2 : 2 + 0.085 * Math.Pow(expectedStrength - 50, 0.53);
            Assert.True((decimal)expectedEpsilon_c2 >= (decimal)2.0 && (decimal)expectedEpsilon_c2 <= (decimal)2.6005);
            Assert.Equal(expectedEpsilon_c2, material.YieldStrain.PartsPerThousand, 12);

            double expectedEpsilon_cu2 = expectedStrength <= 50 ? 3.5 : 2.6 + 35 * Math.Pow((90 - expectedStrength) / 100, 4);
            Assert.True((decimal)expectedEpsilon_cu2 <= (decimal)3.5 && (decimal)expectedEpsilon_cu2 >= (decimal)2.6);
            Assert.Equal(expectedEpsilon_cu2, material.FailureStrain.PartsPerThousand, 12);

            double expectedExponent = expectedStrength <= 50 ? 2.0 : 1.4 + 23.4 * Math.Pow((90 - expectedStrength) / 100, 4);
            Assert.True((decimal)expectedExponent <= (decimal)2.0 && (decimal)expectedExponent >= (decimal)1.4);
            Assert.Equal(expectedExponent, material.Exponent, 12);

            Assert.Equal(MaterialType.Concrete, material.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void GetStressFromParabolaRectangleTests(EnConcreteGrade grade)
        {
            IParabolaRectangleMaterial material = EnConcreteFactory.CreateParabolaRectangleAnalysisMaterial(grade);
            List<Strain> strains = new List<Strain>()
            {
                new Strain(0, StrainUnit.PartPerThousand),
                new Strain(1, StrainUnit.PartPerThousand),
                new Strain(1.5, StrainUnit.PartPerThousand),
                new Strain(2, StrainUnit.PartPerThousand),
                new Strain(2.5, StrainUnit.PartPerThousand),
                new Strain(3, StrainUnit.PartPerThousand),
                new Strain(3.5, StrainUnit.PartPerThousand),
            };

            foreach (Strain strain in strains)
            {
                if (strain > material.FailureStrain)
                {
                    Assert.Throws<ArgumentException>(() => material.StressAt(strain));
                    continue;
                }

                if (strain > material.YieldStrain)
                {
                    Assert.True(Equals(material.YieldStrength, material.StressAt(strain)));
                    continue;
                }

                Stress expectedStress = material.YieldStrength * (1 - Math.Pow(1 - strain / material.YieldStrain, material.Exponent));
                Stress stress = material.StressAt(strain);
                Assert.True(Equals(expectedStress, stress));
            }
        }

        public static IEnumerable<object[]> EnumValues()
        {
            foreach (var enumValue in Enum.GetValues(typeof(EnConcreteGrade)))
            {
                yield return new object[] { enumValue };
            }
        }
    }
}
