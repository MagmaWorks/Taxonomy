using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MaterialTests
{
    public class ENRebarFactoryTests
    {
        [Fact]
        public void CreateStandardB500BConcreteMaterialTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            ENRebarGrade grade = ENRebarGrade.B500B;

            // Act
            IStandardMaterial material = ENRebarFactory.CreateStandardMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Reinforcement, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1992, material.Standard.Code);
            Assert.Equal(
                "EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(ENRebarGrade.B500B, material.Grade);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticTests(ENRebarGrade grade)
        {
            // Assemble
            // Act
            ILinearElasticMaterial material = ENRebarFactory.CreateLinearElastic(grade);

            // Assert
            double expectedStrength = double.Parse(string.Concat(grade.ToString().Where(Char.IsDigit)));
            Assert.True((int)expectedStrength >= 400 && (int)expectedStrength <= 550);
            Assert.Equal(expectedStrength, material.Strength.Megapascals);

            double expectedElasticModulus = 200;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Reinforcement, material.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateElastoPlasticTests(ENRebarGrade grade)
        {
            // Assemble
            // Act
            IBiLinearMaterial material = ENRebarFactory.CreateBiLinear(grade);

            // Assert
            double expectedStrength = double.Parse(string.Concat(grade.ToString().Where(Char.IsDigit)));
            Assert.True((int)expectedStrength >= 400 && (int)expectedStrength <= 550);
            Assert.Equal(expectedStrength, material.YieldStrength.Megapascals);

            char rebarClass = grade.ToString()[grade.ToString().Length - 1];
            Assert.True(rebarClass == 'A' || rebarClass == 'B' || rebarClass == 'C');
            Strain strain;
            double k;
            switch (rebarClass)
            {
                case 'A':
                    Assert.Equal(1.05, material.UltimateStrength / material.YieldStrength);
                    Assert.Equal(2.5, material.FailureStrain.Percent);
                    break;

                case 'B':
                    Assert.Equal(1.08, material.UltimateStrength / material.YieldStrength);
                    Assert.Equal(5.0, material.FailureStrain.Percent);
                    k = 1.08;
                    strain = new Strain(5.0, StrainUnit.Percent);
                    break;

                case 'C':
                    Assert.Equal(1.15, material.UltimateStrength / material.YieldStrength);
                    Assert.Equal(7.5, material.FailureStrain.Percent);
                    break;
            }

            Assert.Equal(MaterialType.Reinforcement, material.Type);
        }

        public static IEnumerable<object[]> EnumValues()
        {
            foreach (var enumValue in Enum.GetValues(typeof(ENRebarGrade)))
            {
                yield return new object[] { enumValue };
            }
        }
    }
}
