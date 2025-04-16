using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

namespace LoadTests
{
    public class Gravity2dTests
    {
        [Fact]
        public void FactorTest()
        {
            // Assemble
            var f = new Ratio(0.9, RatioUnit.DecimalFraction);
            Gravity2d load = new Gravity2d(f)
            {
                Label = "myLoad",
                X = new Ratio(0.01, RatioUnit.DecimalFraction),
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IGravity2d factored = (IGravity2d)load.Factor(factor);

            // Assert
            Assert.Equal(f * 2, factored.Z);
            Assert.Equal(0.01 * 2, factored.X.DecimalFractions);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
