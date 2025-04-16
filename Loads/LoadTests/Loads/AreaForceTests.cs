using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

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

        [Fact]
        public void FactorTest()
        {
            // Assemble
            var f = new Pressure(15.4, PressureUnit.KilonewtonPerSquareMeter);
            AreaForce load = new AreaForce(f)
            {
                Application = LoadApplication.Global,
                Label = "myLoad",
                X = new Pressure(13.2, PressureUnit.KilonewtonPerSquareMeter),
                Y = new Pressure(22.1, PressureUnit.KilonewtonPerSquareMeter)
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IAreaForce factored = (IAreaForce)load.Factor(factor);

            // Assert
            Assert.Equal(f * 2, factored.Z);
            Assert.Equal(13.2 * 2, factored.X.KilonewtonsPerSquareMeter);
            Assert.Equal(22.1 * 2, factored.Y.KilonewtonsPerSquareMeter);
            Assert.Equal(LoadApplication.Global, factored.Application);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
