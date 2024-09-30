using OasysUnits.Units;
using OasysUnits;
using MagmaWorks.Taxonomy.Loads;

namespace LoadTests
{
    public class GravityTests
    {
        [Fact]
        public void FactorTest()
        {
            // Assemble
            var f = new Ratio(0.9, RatioUnit.DecimalFraction);
            Gravity load = new Gravity(f)
            {
                Label = "myLoad",
                X = new Ratio(0.01, RatioUnit.DecimalFraction),
                Y = new Ratio(0.02, RatioUnit.DecimalFraction)
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IGravity factored = (IGravity)load.Factor(factor);

            // Assert
            Assert.Equal(f * 2, factored.Z);
            Assert.Equal(0.01 * 2, factored.X.DecimalFractions);
            Assert.Equal(0.02 * 2, factored.Y.DecimalFractions);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
