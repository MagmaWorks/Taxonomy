﻿namespace MaterialTests.StandardMaterials
{
    public class EnRebarFactoryTests
    {
        [Fact]
        public void CreateStandardB500BConcreteMaterialTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            EnRebarGrade grade = EnRebarGrade.B500B;

            // Act
            IEnRebarMaterial material = new EnRebarMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Reinforcement, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(
                "EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(EnRebarGrade.B500B, material.Grade);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticTests(EnRebarGrade grade)
        {
            // Assemble
            // Act
            ILinearElasticMaterial material = EnRebarFactory.CreateLinearElastic(grade);

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
        public void CreateElastoPlasticTests(EnRebarGrade grade)
        {
            // Assemble
            // Act
            IBiLinearMaterial material = EnRebarFactory.CreateBiLinear(grade);

            // Assert
            double expectedStrength = double.Parse(string.Concat(grade.ToString().Where(Char.IsDigit)));
            Assert.True((int)expectedStrength >= 400 && (int)expectedStrength <= 550);
            Assert.Equal(expectedStrength, material.YieldStrength.Megapascals);

            char rebarClass = grade.ToString()[grade.ToString().Length - 1];
            Assert.True(rebarClass == 'A' || rebarClass == 'B' || rebarClass == 'C');
            Strain strain;
            switch (rebarClass)
            {
                case 'A':
                    Assert.Equal(1.05, material.UltimateStrength / material.YieldStrength);
                    Assert.Equal(2.5, material.FailureStrain.Percent);
                    break;

                case 'B':
                    Assert.Equal(1.08, material.UltimateStrength / material.YieldStrength);
                    Assert.Equal(5.0, material.FailureStrain.Percent);
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
            foreach (var enumValue in Enum.GetValues(typeof(EnRebarGrade)))
            {
                yield return new object[] { enumValue };
            }
        }
    }
}
