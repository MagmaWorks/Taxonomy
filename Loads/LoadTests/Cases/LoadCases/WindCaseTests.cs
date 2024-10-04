using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace LoadCaseTests
{
    public class WindCaseTests
    {
        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 0.6, 0.2, 0.0)]
        [InlineData(NationalAnnex.UnitedKingdom, 0.6, 0.2, 0.0)]
        [InlineData(NationalAnnex.Germany, 0.6, 0.2, 0.0)]
        public void CreateWindCaseTest(NationalAnnex nationalAnnex,
            double expectedPhi_0, double expectedPhi_1, double expectedPhi_2)
        {
            // Assemble
            string expectedName = $"Wind loads";
            string expectedNickname = $"W";

            // Act
            IVariableCase variableCase = ENLoadCaseFactory.CreateWind(nationalAnnex);

            // Assert
            Assert.Equal(expectedName, variableCase.Name);
            Assert.Equal(expectedNickname, variableCase.Nickname);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 0.6, 0.2, 0.0)]
        [InlineData(NationalAnnex.UnitedKingdom, 0.6, 0.2, 0.0)]
        [InlineData(NationalAnnex.Germany, 0.6, 0.2, 0.0)]
        public void CreateWindCaseWithLoadTest(NationalAnnex nationalAnnex,
            double expectedPhi_0, double expectedPhi_1, double expectedPhi_2)
        {
            // Assemble
            string expectedName = $"Wind loads";
            string expectedNickname = $"W";
            var load = new PointForce2d(new Force(90, ForceUnit.Kilonewton));

            // Act
            IVariableCase variableCase = ENLoadCaseFactory.CreateWind(
                new List<ILoad>() { load }, nationalAnnex);

            // Assert
            Assert.Equal(expectedName, variableCase.Name);
            Assert.Equal(expectedNickname, variableCase.Nickname);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
            Assert.Equal(90, ((IPointForce2d)variableCase.Loads.FirstOrDefault()).Z.Kilonewtons);
        }
    }
}
