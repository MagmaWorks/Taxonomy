namespace LoadTests
{
    public class PointMoment2dTests
    {
        [Fact]
        public void FactorTest()
        {
            // Assemble
            var yy = new Moment(2, MomentUnit.KilonewtonMeter);
            var zz = new Moment(3, MomentUnit.KilonewtonMeter);
            PointMoment2d load = new PointMoment2d(yy, zz)
            {
                Label = "myLoad",
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IPointMoment2d factored = (IPointMoment2d)load.Factor(factor);

            // Assert
            Assert.Equal(yy * 2, factored.Yy);
            Assert.Equal(zz * 2, factored.Zz);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
