using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace LoadCaseTests
{
    public class SnowCaseTests
    {
        public static IVariableCase Create(bool above1000m = false)
        {
            var load = new LineForce(new ForcePerLength(-15, ForcePerLengthUnit.KilonewtonPerMeter));
            return ENLoadCaseFactory.CreateSnow(new List<ILoad> { load },
                NationalAnnex.UnitedKingdom, above1000m);
        }

        [Fact]
        public void CreateImposedTest()
        {
            // Assemble
            // Act
            IVariableCase variableCase = Create();

            // Assert
            Assert.Equal("Snow loads", variableCase.Name);
            Assert.Equal("S", variableCase.Nickname);
            Assert.Equal(0.5, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(0.2, variableCase.Frequent.DecimalFractions);
            Assert.Equal(0.0, variableCase.QuasiPermanent.DecimalFractions);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, true, 0.7, 0.5, 0.2)]
        [InlineData(NationalAnnex.RecommendedValues, false, 0.5, 0.2, 0.0)]
        [InlineData(NationalAnnex.UnitedKingdom, true, 0.7, 0.5, 0.2)]
        [InlineData(NationalAnnex.UnitedKingdom, false, 0.5, 0.2, 0.0)]
        [InlineData(NationalAnnex.Germany, true, 0.7, 0.5, 0.2)]
        [InlineData(NationalAnnex.Germany, false, 0.5, 0.2, 0.0)]
        public void CreateSnowCaseTest(NationalAnnex nationalAnnex, bool above1000m, 
            double expectedPhi_0, double expectedPhi_1, double expectedPhi_2)
        {
            // Assemble
            string expectedName = $"Snow loads";
            string expectedNickname = $"S";

            // Act
            IVariableCase variableCase = ENLoadCaseFactory.CreateSnow(nationalAnnex, above1000m);

            // Assert
            Assert.Equal(expectedName, variableCase.Name);
            Assert.Equal(expectedNickname, variableCase.Nickname);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, true, 0.7, 0.5, 0.2)]
        [InlineData(NationalAnnex.RecommendedValues, false, 0.5, 0.2, 0.0)]
        [InlineData(NationalAnnex.UnitedKingdom, true, 0.7, 0.5, 0.2)]
        [InlineData(NationalAnnex.UnitedKingdom, false, 0.5, 0.2, 0.0)]
        [InlineData(NationalAnnex.Germany, true, 0.7, 0.5, 0.2)]
        [InlineData(NationalAnnex.Germany, false, 0.5, 0.2, 0.0)]
        public void CreateSnowCaseWithLoadTest(NationalAnnex nationalAnnex, bool above1000m,
            double expectedPhi_0, double expectedPhi_1, double expectedPhi_2)
        {
            // Assemble
            string expectedName = $"Snow loads";
            string expectedNickname = $"S";
            var load = new LineForce(new ForcePerLength(-15, ForcePerLengthUnit.KilonewtonPerMeter));

            // Act
            IVariableCase variableCase = ENLoadCaseFactory.CreateSnow(
                new List<ILoad>() { load }, nationalAnnex, above1000m);

            // Assert
            Assert.Equal(expectedName, variableCase.Name);
            Assert.Equal(expectedNickname, variableCase.Nickname);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
            Assert.Equal(-15, ((ILineForce)variableCase.Loads.FirstOrDefault()).Z.KilonewtonsPerMeter);
        }
    }
}
