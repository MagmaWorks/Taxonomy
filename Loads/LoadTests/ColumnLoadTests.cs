using MagmaWorks.Taxonomy.Loads;
using OasysUnits;
using OasysUnits.Units;

namespace LoadTests
{
    public class ColumnLoadTests
    {
        [Fact]
        public void ImplicitOperatorTest()
        {
            // Assemble
            var f = new Force(15.4, ForceUnit.Kilonewton);

            // Act
            ColumnLoad load = (ColumnLoad)f;

            // Assert
            Assert.Equal(f, load.Force);
        }
    }
}
