using MagmaWorks.Taxonomy.Loads;
using OasysUnits;
using OasysUnits.Units;

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
    }
}
