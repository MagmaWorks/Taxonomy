using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

namespace LoadTests
{
    public class PointDisplacement2dTests
    {
        [Fact]
        public void FactorTest()
        {
            // Assemble
            var x = new Length(1, LengthUnit.Meter);
            var z = new Length(3, LengthUnit.Meter);
            PointDisplacement2d load = new PointDisplacement2d(x, z)
            {
                Label = "myLoad",
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IPointDisplacement2d factored = (IPointDisplacement2d)load.Factor(factor);

            // Assert
            Assert.Equal(x * 2, factored.X);
            Assert.Equal(z * 2, factored.Z);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
