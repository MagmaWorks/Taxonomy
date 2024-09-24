using MagmaWorks.Taxonomy.Loads;
using OasysUnits;
using OasysUnits.Units;

namespace LoadTests
{
    public class Point2dForceTests
    {
        [Fact]
        public void ImplicitOperatorTest()
        {
            // Assemble
            var f = new Force(15.4, ForceUnit.Kilonewton);

            // Act
            Point2dForce load = (Point2dForce)f;

            // Assert
            Assert.Equal(f, load.Z);
        }
    }
}
