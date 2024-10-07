using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace LoadCaseTests
{
    public class ThermalCaseTests
    {
        public static IVariableCase Create()
        {
            var load = new PointDisplacement(Length.Zero, Length.Zero, new Length(0.01, LengthUnit.Centimeter));
            return ENLoadCaseFactory.CreateThermal(new List<ILoad> { load }, NationalAnnex.UnitedKingdom);
        }

        [Fact]
        public void CreateImposedTest()
        {
            // Assemble
            // Act
            IVariableCase variableCase = Create();

            // Assert
            Assert.Equal("Thermal loads", variableCase.Name);
            Assert.Equal("T", variableCase.Nickname);
            Assert.Equal(0.6, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(0.5, variableCase.Frequent.DecimalFractions);
            Assert.Equal(0.0, variableCase.QuasiPermanent.DecimalFractions);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 0.6, 0.5, 0.0)]
        [InlineData(NationalAnnex.UnitedKingdom, 0.6, 0.5, 0.0)]
        [InlineData(NationalAnnex.Germany, 0.6, 0.5, 0.0)]
        public void CreateThermaCaseTest(NationalAnnex nationalAnnex,
            double expectedPhi_0, double expectedPhi_1, double expectedPhi_2)
        {
            // Assemble
            string expectedName = $"Thermal loads";
            string expectedNickname = $"T";

            // Act
            IVariableCase variableCase = ENLoadCaseFactory.CreateThermal(nationalAnnex);

            // Assert
            Assert.Equal(expectedName, variableCase.Name);
            Assert.Equal(expectedNickname, variableCase.Nickname);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 0.6, 0.5, 0.0)]
        [InlineData(NationalAnnex.UnitedKingdom, 0.6, 0.5, 0.0)]
        [InlineData(NationalAnnex.Germany, 0.6, 0.5, 0.0)]
        public void CreateThermalCaseWithLoadTest(NationalAnnex nationalAnnex,
            double expectedPhi_0, double expectedPhi_1, double expectedPhi_2)
        {
            // Assemble
            string expectedName = $"Thermal loads";
            string expectedNickname = $"T";
            var load = new PointDisplacement(Length.Zero, Length.Zero,
                new Length(0.01, LengthUnit.Centimeter));

            // Act
            IVariableCase variableCase = ENLoadCaseFactory.CreateThermal(
                new List<ILoad>() { load }, nationalAnnex);

            // Assert
            Assert.Equal(expectedName, variableCase.Name);
            Assert.Equal(expectedNickname, variableCase.Nickname);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
            Assert.Equal(0.01, ((IPointDisplacement)variableCase.Loads.FirstOrDefault()).Z.Centimeters);
        }
    }
}
