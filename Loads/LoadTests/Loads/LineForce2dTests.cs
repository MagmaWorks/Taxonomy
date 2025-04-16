namespace LoadTests
{
    public class LineForce2dTests
    {
        [Fact]
        public void ImplicitOperatorTest()
        {
            // Assemble
            var f = new ForcePerLength(15.4, ForcePerLengthUnit.KilonewtonPerMeter);

            // Act
            LineForce2d load = (LineForce2d)f;

            // Assert
            Assert.Equal(f, load.Z);
        }

        [Fact]
        public void FactorTest()
        {
            // Assemble
            var f = new ForcePerLength(15.4, ForcePerLengthUnit.KilonewtonPerMeter);
            LineForce2d load = new LineForce2d(f)
            {
                Label = "myLoad",
                Application = LoadApplication.Projected,
                X = new ForcePerLength(-25.4, ForcePerLengthUnit.KilonewtonPerMeter)
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            ILineForce2d factored = (ILineForce2d)load.Factor(factor);

            // Assert
            Assert.Equal(f * 2, factored.Z);
            Assert.Equal(-25.4 * 2, factored.X.KilonewtonsPerMeter);
            Assert.Equal(LoadApplication.Projected, factored.Application);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
