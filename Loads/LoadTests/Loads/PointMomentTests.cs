using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

namespace LoadTests
{
    public class PointMomentTests
    {
        [Fact]
        public void FactorTest()
        {
            // Assemble
            var xx = new Moment(1, MomentUnit.KilonewtonMeter);
            var yy = new Moment(2, MomentUnit.KilonewtonMeter);
            var zz = new Moment(3, MomentUnit.KilonewtonMeter);
            PointMoment load = new PointMoment(xx, yy, zz)
            {
                Label = "myLoad",
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IPointMoment factored = (IPointMoment)load.Factor(factor);

            // Assert
            Assert.Equal(xx * 2, factored.Xx);
            Assert.Equal(yy * 2, factored.Yy);
            Assert.Equal(zz * 2, factored.Zz);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
