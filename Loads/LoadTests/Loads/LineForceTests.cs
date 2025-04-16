using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

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

        [Fact]
        public void FactorTest()
        {
            // Assemble
            var f = new ForcePerLength(15.4, ForcePerLengthUnit.KilonewtonPerMeter);
            LineForce load = new LineForce(f)
            {
                Label = "myLoad",
                Application = LoadApplication.Local,
                X = new ForcePerLength(-25.4, ForcePerLengthUnit.KilonewtonPerMeter),
                Y = new ForcePerLength(-25.3, ForcePerLengthUnit.KilonewtonPerMeter),
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            ILineForce factored = (ILineForce)load.Factor(factor);

            // Assert
            Assert.Equal(f * 2, factored.Z);
            Assert.Equal(-25.4 * 2, factored.X.KilonewtonsPerMeter);
            Assert.Equal(-25.3 * 2, factored.Y.KilonewtonsPerMeter);
            Assert.Equal(LoadApplication.Local, factored.Application);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
