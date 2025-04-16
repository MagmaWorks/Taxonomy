using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

namespace LoadTests
{
    public class PointDisplacementTests
    {
        [Fact]
        public void FactorTest()
        {
            // Assemble
            var x = new Length(1, LengthUnit.Meter);
            var y = new Length(2, LengthUnit.Meter);
            var z = new Length(3, LengthUnit.Meter);
            PointDisplacement load = new PointDisplacement(x, y, z)
            {
                Label = "myLoad",
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IPointDisplacement factored = (IPointDisplacement)load.Factor(factor);

            // Assert
            Assert.Equal(x * 2, factored.X);
            Assert.Equal(y * 2, factored.Y);
            Assert.Equal(z * 2, factored.Z);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
