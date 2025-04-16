using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

namespace LoadTests
{
    public class PointForce2dTests
    {
        [Fact]
        public void ImplicitOperatorTest()
        {
            // Assemble
            var f = new Force(15.4, ForceUnit.Kilonewton);

            // Act
            PointForce2d load = (PointForce2d)f;

            // Assert
            Assert.Equal(f, load.Z);
        }

        [Fact]
        public void FactorTest()
        {
            // Assemble
            var f = new Force(15.4, ForceUnit.Kilonewton);
            PointForce2d load = new PointForce2d(f)
            {
                Label = "myLoad",
                X = new Force(-25.4, ForceUnit.Kilonewton)
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IPointForce2d factored = (IPointForce2d)load.Factor(factor);

            // Assert
            Assert.Equal(f * 2, factored.Z);
            Assert.Equal(-25.4 * 2, factored.X.Kilonewtons);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
