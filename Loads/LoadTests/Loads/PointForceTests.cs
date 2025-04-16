using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

namespace LoadTests
{
    public class PointForceTests
    {
        [Fact]
        public void ImplicitOperatorTest()
        {
            // Assemble
            var f = new Force(15.4, ForceUnit.Kilonewton);

            // Act
            PointForce load = (PointForce)f;

            // Assert
            Assert.Equal(f, load.Z);
        }

        [Fact]
        public void FactorTest()
        {
            // Assemble
            var f = new Force(15.4, ForceUnit.Kilonewton);
            PointForce load = new PointForce(f, new Force(-25.4, ForceUnit.Kilonewton), new Force(0.01, ForceUnit.Kilonewton))
            {
                Label = "myLoad",
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IPointForce factored = (IPointForce)load.Factor(factor);

            // Assert
            Assert.Equal(f * 2, factored.X);
            Assert.Equal(-25.4 * 2, factored.Y.Kilonewtons);
            Assert.Equal(0.01 * 2, factored.Z.Kilonewtons);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
