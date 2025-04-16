using MagmaWorks.Taxonomy.Loads;
using UnitsNet;
using UnitsNet.Units;

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

        [Fact]
        public void FactorTest()
        {
            // Assemble
            var f = new Force(15.4, ForceUnit.Kilonewton);
            ColumnLoad load = new ColumnLoad(f)
            {
                Label = "myLoad",
                TopMoment = new PointMoment2d(
                    new Moment(13.2, MomentUnit.KilonewtonMeter),
                    new Moment(-0.2, MomentUnit.KilonewtonMeter)),
                BottomMoment = new PointMoment2d(
                    new Moment(53.2, MomentUnit.KilonewtonMeter),
                    new Moment(33.2, MomentUnit.KilonewtonMeter)),
            };
            var factor = new Ratio(2, RatioUnit.DecimalFraction);

            // Act
            IColumnLoad factored = (IColumnLoad)load.Factor(factor);

            // Assert
            Assert.Equal(f * 2, factored.Force);
            Assert.Equal(13.2 * 2, factored.TopMoment.Yy.KilonewtonMeters);
            Assert.Equal(-0.2 * 2, factored.TopMoment.Zz.KilonewtonMeters);
            Assert.Equal(53.2 * 2, factored.BottomMoment.Yy.KilonewtonMeters);
            Assert.Equal(33.2 * 2, factored.BottomMoment.Zz.KilonewtonMeters);
            Assert.Equal("myLoad", factored.Label);
        }
    }
}
