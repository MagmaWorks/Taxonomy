using MagmaWorks.Geometry;
using UnitsNet;
using UnitsNet.Units;
using Utility = MagmaWorks.Taxonomy.Sections.Reinforcement.Utility;

namespace SectionTests.ReinforcementTests
{
    public class UtilityTests
    {
        [Fact]
        public void PositionsByCountTest()
        {
            // Assemble
            LengthUnit unit = LengthUnit.Millimeter;
            var start = new LocalPoint2d(new Length(7, unit), new Length(-4, unit));
            var end = new LocalPoint2d(new Length(2, unit), new Length(6, unit));
            int segments = 6;

            // Act
            List<ILocalPoint2d> pointsByCount = Utility.PositionsByCount(start, end, segments);

            // Assert
            Assert.Equal(segments, pointsByCount.Count);

            // pt1
            Assert.Equal(7, pointsByCount[0].Y.As(unit));
            Assert.Equal(-4, pointsByCount[0].Z.As(unit));

            // pt2
            Assert.Equal(6, pointsByCount[1].Y.As(unit));
            Assert.Equal(-2, pointsByCount[1].Z.As(unit));

            // pt3
            Assert.Equal(5, pointsByCount[2].Y.As(unit));
            Assert.Equal(0, pointsByCount[2].Z.As(unit));

            // pt4
            Assert.Equal(4, pointsByCount[3].Y.As(unit));
            Assert.Equal(2, pointsByCount[3].Z.As(unit));

            // pt5
            Assert.Equal(3, pointsByCount[4].Y.As(unit));
            Assert.Equal(4, pointsByCount[4].Z.As(unit));

            // pt6
            Assert.Equal(2, pointsByCount[5].Y.As(unit));
            Assert.Equal(6, pointsByCount[5].Z.As(unit));
        }

        [Fact]
        public void PositionsBySpacingTest()
        {
            // Assemble
            LengthUnit unit = LengthUnit.Millimeter;
            var start = new LocalPoint2d(new Length(500, unit), new Length(1000, unit));
            var end = new LocalPoint2d(new Length(500, unit), new Length(2000, unit));
            var pitch = new Length(300, unit);

            // Act
            List<ILocalPoint2d> pointsByCount = Utility.PositionsBySpacing(start, end, pitch, false);

            // Assert
            Assert.Equal(3, pointsByCount.Count);

            // pt1
            Assert.Equal(500, pointsByCount[0].Y.As(unit));
            Assert.Equal(1250, pointsByCount[0].Z.As(unit));

            // pt2
            Assert.Equal(500, pointsByCount[1].Y.As(unit));
            Assert.Equal(1500, pointsByCount[1].Z.As(unit));

            // pt3
            Assert.Equal(500, pointsByCount[2].Y.As(unit));
            Assert.Equal(1750, pointsByCount[2].Z.As(unit));
        }
    }
}
