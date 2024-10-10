using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace LoadCaseTests
{
    public class ImposedCaseTests
    {
        public static IVariableCase Create()
        {
            var load = new AreaForce(new Pressure(5.0, PressureUnit.KilonewtonPerSquareMeter));
            return ENLoadCaseFactory.CreateImposed(new List<ILoad> { load },
                ImposedLoadCategory.CategoryB, NationalAnnex.UnitedKingdom);
        }

        [Fact]
        public void CreateImposedTest()
        {
            // Assemble
            IVariableCase variableCase = Create();

            // Assert
            Assert.Equal("Live loads Category B", variableCase.Name);
            Assert.Equal("Q", variableCase.Nickname);
            Assert.Equal(0.7, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(0.5, variableCase.Frequent.DecimalFractions);
            Assert.Equal(0.3, variableCase.QuasiPermanent.DecimalFractions);
        }

        [Theory]
        [InlineData(ImposedLoadCategory.CategoryA, NationalAnnex.RecommendedValues, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryB, NationalAnnex.RecommendedValues, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryC, NationalAnnex.RecommendedValues, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryD, NationalAnnex.RecommendedValues, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryE, NationalAnnex.RecommendedValues, 1.0, 0.9, 0.8)]
        [InlineData(ImposedLoadCategory.CategoryF, NationalAnnex.RecommendedValues, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryG, NationalAnnex.RecommendedValues, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryH, NationalAnnex.RecommendedValues, 0.0, 0.0, 0.0)]
        [InlineData(ImposedLoadCategory.CategoryA, NationalAnnex.UnitedKingdom, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryB, NationalAnnex.UnitedKingdom, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryC, NationalAnnex.UnitedKingdom, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryD, NationalAnnex.UnitedKingdom, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryE, NationalAnnex.UnitedKingdom, 1.0, 0.9, 0.8)]
        [InlineData(ImposedLoadCategory.CategoryF, NationalAnnex.UnitedKingdom, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryG, NationalAnnex.UnitedKingdom, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryH, NationalAnnex.UnitedKingdom, 0.7, 0.0, 0.0)]
        [InlineData(ImposedLoadCategory.CategoryA, NationalAnnex.Germany, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryB, NationalAnnex.Germany, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryC, NationalAnnex.Germany, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryD, NationalAnnex.Germany, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryE, NationalAnnex.Germany, 1.0, 0.9, 0.8)]
        [InlineData(ImposedLoadCategory.CategoryF, NationalAnnex.Germany, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryG, NationalAnnex.Germany, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryH, NationalAnnex.Germany, 0.0, 0.0, 0.0)]
        public void CreateImposedCaseTest(ImposedLoadCategory category, NationalAnnex nationalAnnex,
            double expectedPhi_0, double expectedPhi_1, double expectedPhi_2)
        {
            // Assemble
            string expectedName = $"Live loads Category {category.ToString().Last()}";
            string expectedNickname = $"Q";

            // Act
            IVariableCase variableCase = ENLoadCaseFactory.CreateImposed(category, nationalAnnex);

            // Assert
            Assert.Equal(expectedName, variableCase.Name);
            Assert.Equal(expectedNickname, variableCase.Nickname);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
        }

        [Theory]
        [InlineData(ImposedLoadCategory.CategoryA, NationalAnnex.RecommendedValues, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryB, NationalAnnex.RecommendedValues, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryC, NationalAnnex.RecommendedValues, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryD, NationalAnnex.RecommendedValues, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryE, NationalAnnex.RecommendedValues, 1.0, 0.9, 0.8)]
        [InlineData(ImposedLoadCategory.CategoryF, NationalAnnex.RecommendedValues, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryG, NationalAnnex.RecommendedValues, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryH, NationalAnnex.RecommendedValues, 0.0, 0.0, 0.0)]
        [InlineData(ImposedLoadCategory.CategoryA, NationalAnnex.UnitedKingdom, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryB, NationalAnnex.UnitedKingdom, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryC, NationalAnnex.UnitedKingdom, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryD, NationalAnnex.UnitedKingdom, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryE, NationalAnnex.UnitedKingdom, 1.0, 0.9, 0.8)]
        [InlineData(ImposedLoadCategory.CategoryF, NationalAnnex.UnitedKingdom, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryG, NationalAnnex.UnitedKingdom, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryH, NationalAnnex.UnitedKingdom, 0.7, 0.0, 0.0)]
        [InlineData(ImposedLoadCategory.CategoryA, NationalAnnex.Germany, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryB, NationalAnnex.Germany, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryC, NationalAnnex.Germany, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryD, NationalAnnex.Germany, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryE, NationalAnnex.Germany, 1.0, 0.9, 0.8)]
        [InlineData(ImposedLoadCategory.CategoryF, NationalAnnex.Germany, 0.7, 0.7, 0.6)]
        [InlineData(ImposedLoadCategory.CategoryG, NationalAnnex.Germany, 0.7, 0.5, 0.3)]
        [InlineData(ImposedLoadCategory.CategoryH, NationalAnnex.Germany, 0.0, 0.0, 0.0)]
        public void CreateImposedCaseWithLoadTest(ImposedLoadCategory category, NationalAnnex nationalAnnex,
            double expectedPhi_0, double expectedPhi_1, double expectedPhi_2)
        {
            // Assemble
            string expectedName = $"Live loads Category {category.ToString().Last()}";
            string expectedNickname = $"Q";
            var load = new LineForce2d(new ForcePerLength(-15, ForcePerLengthUnit.KilonewtonPerMeter));

            // Act
            IVariableCase variableCase = ENLoadCaseFactory.CreateImposed(
                new List<ILoad>() { load }, category, nationalAnnex);

            // Assert
            Assert.Equal(expectedName, variableCase.Name);
            Assert.Equal(expectedNickname, variableCase.Nickname);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
            Assert.Equal(-15, ((ILineForce2d)variableCase.Loads.FirstOrDefault()).Z.KilonewtonsPerMeter);
        }
    }
}
