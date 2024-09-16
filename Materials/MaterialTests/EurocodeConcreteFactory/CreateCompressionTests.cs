using MagmaWorks.Taxonomy.Materials;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MaterialTests
{
    public class CreateCompressionTests
    {
        [Theory]
        [MemberData(nameof(enumValues))]
        public void CreateCompressionFromGradeTests(EurocodeConcreteGrade grade)
        {
            // Assemble
            // Act
            ILinearElasticMaterial material = EurocodeConcreteFactory.CreateCompression(grade);

            // Assert
            double expectedStrength = double.Parse(grade.ToString().Split('C', '_')[1]);
            Assert.True((int)expectedStrength >= 12 && (int)expectedStrength <= 90);
            Assert.Equal(expectedStrength, material.Strength.Megapascals);

            double expectedStrain = expectedStrength < 50 ? 1.75 : 1.75 + 0.55 * ((expectedStrength - 50) / 40);
            Assert.True((decimal)expectedStrain >= (decimal)1.75 && (decimal)expectedStrain <= (decimal)2.4);
            Assert.Equal(expectedStrain, material.PeakStrain.MilliStrain, 12);

            double expectedElasticModulus = expectedStrength / expectedStrain;
            Assert.True(expectedElasticModulus > 6 && expectedElasticModulus < 40);
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);
        }

        public static IEnumerable<object[]> enumValues()
        {
            foreach (var enumValue in Enum.GetValues(typeof(EurocodeConcreteGrade)))
            {
                yield return new object[] { enumValue };
            }
        }
    }
}
