using MagmaWorks.Taxonomy.Loads;
using OasysUnits;
using OasysUnits.Units;

namespace LoadTests
{
    public class LineForceTests
    {
        [Fact]
        public void ImplicitOperatorTest()
        {
            // Assemble
            var f = new ForcePerLength(15.4, ForcePerLengthUnit.KilonewtonPerMeter);

            // Act
            LineForce load = (LineForce)f;

            // Assert
            Assert.Equal(f, load.Z);
        }
    }
}
