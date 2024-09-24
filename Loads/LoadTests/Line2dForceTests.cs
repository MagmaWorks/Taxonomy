using MagmaWorks.Taxonomy.Loads;
using OasysUnits;
using OasysUnits.Units;

namespace LoadTests
{
    public class Line2dForceTests
    {
        [Fact]
        public void ImplicitOperatorTest()
        {
            // Assemble
            var f = new ForcePerLength(15.4, ForcePerLengthUnit.KilonewtonPerMeter);

            // Act
            Line2dForce load = (Line2dForce)f;

            // Assert
            Assert.Equal(f, load.Z);
        }
    }
}
