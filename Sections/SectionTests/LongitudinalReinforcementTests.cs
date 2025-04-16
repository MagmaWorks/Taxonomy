using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Sections;
using UnitsNet;
using UnitsNet.Units;

namespace SectionTests
{
    public class LongitudinalReinforcementTests
    {
        public static ILongitudinalReinforcement CreateLongitudinalReinforcement()
        {
            IRebar rebar = RebarTests.CreateRebar();
            ILocalPoint2d position = new LocalPoint2d(
                new Length(22, LengthUnit.Centimeter), new Length(47, LengthUnit.Centimeter));
            return new LongitudinalReinforcement(rebar, position);
        }

        public static IList<ILongitudinalReinforcement> CreateLongitudinalReinforcements()
        {
            IRebar rebar = RebarTests.CreateRebar();
            LengthUnit unit = LengthUnit.Centimeter;
            return new List<ILongitudinalReinforcement>()
            {
                new LongitudinalReinforcement(rebar, new LocalPoint2d(22, 47, unit)),
                new LongitudinalReinforcement(rebar, new LocalPoint2d(-22, 47, unit)),
                new LongitudinalReinforcement(rebar, new LocalPoint2d(-22, -47, unit)),
                new LongitudinalReinforcement(rebar, new LocalPoint2d(22, -47, unit)),
            };
        }

        [Fact]
        public void CreateLongitudinalReinforcementTest()
        {
            // Assemble
            IRebar expectedRebar = RebarTests.CreateRebar();

            // Act
            ILongitudinalReinforcement longitudinalReinforcment = CreateLongitudinalReinforcement();

            // Assert
            Assert.Equivalent(expectedRebar, longitudinalReinforcment.Rebar);
            Assert.Equal(22, longitudinalReinforcment.Position.Y.Centimeters);
            Assert.Equal(47, longitudinalReinforcment.Position.Z.Centimeters);
            Assert.Equal(1, longitudinalReinforcment.CountPerBundle);
        }
    }
}
