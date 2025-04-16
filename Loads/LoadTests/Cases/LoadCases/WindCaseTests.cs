using MagmaWorks.Taxonomy.Loads;
using MagmaWorks.Taxonomy.Loads.Cases;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using UnitsNet;
using UnitsNet.Units;

namespace LoadCaseTests
{
    public class WindCaseTests
    {
        public static IVariableCase Create()
        {
            var load = new PointForce2d(new Force(90, ForceUnit.Kilonewton));
            return ENLoadCaseFactory.CreateWind(
                new List<ILoad>() { load }, NationalAnnex.UnitedKingdom);
        }

        [Fact]
        public void CreateImposedTest()
        {
            // Assemble
            // Act
            IVariableCase variableCase = Create();

            // Assert
            Assert.Equal("Wind loads", variableCase.Name);
            Assert.Equal("W", variableCase.Nickname);
            Assert.Equal(0.6, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(0.2, variableCase.Frequent.DecimalFractions);
            Assert.Equal(0.0, variableCase.QuasiPermanent.DecimalFractions);
            Assert.True(variableCase.IsHorizontal);
        }


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
            Assert.True(variableCase.IsHorizontal);
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
            Assert.True(variableCase.IsHorizontal);
            Assert.Equal(expectedPhi_0, variableCase.Characteristic.DecimalFractions);
            Assert.Equal(expectedPhi_1, variableCase.Frequent.DecimalFractions);
            Assert.Equal(expectedPhi_2, variableCase.QuasiPermanent.DecimalFractions);
            Assert.Equal(90, ((IPointForce2d)variableCase.Loads.FirstOrDefault()).Z.Kilonewtons);
        }
    }
}
