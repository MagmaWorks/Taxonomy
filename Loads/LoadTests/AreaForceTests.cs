using MagmaWorks.Taxonomy.Loads;
using OasysUnits;
using OasysUnits.Units;

namespace LoadTests
{
    public class AreaForceTests
    {
        [Fact]
        public void ImplicitOperatorTest()
        {
            // Assemble
            var f = new Pressure(15.4, PressureUnit.KilonewtonPerSquareMeter);

            // Act
            AreaForce load = (AreaForce)f;

            // Assert
            Assert.Equal(f, load.Z);
        }
    }
}
