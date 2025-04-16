using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization;
using UnitsNet;
using UnitsNet.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class TrapezoidTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);

            // Act
            ITrapezoid prfl = new Trapezoid(wTop, wBottom, h);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(wTop, prfl.TopWidth);
            TestUtility.TestLengthsAreEqual(wBottom, prfl.BottomWidth);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);

            // Act
            ITrapezoid prfl = new Trapezoid(wTop, wBottom, h);
            string json = prfl.ToJson();
            ITrapezoid prflDeserialized = json.FromJson<ITrapezoid>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.TopWidth, prflDeserialized.TopWidth);
            TestUtility.TestLengthsAreEqual(prfl.BottomWidth, prflDeserialized.BottomWidth);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);

            // Act
            ITrapezoid prfl = new Trapezoid(wTop, wBottom, h);
            string json = prfl.ToJson();
            ITrapezoid prflDeserialized = json.FromJson<Trapezoid>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.TopWidth, prflDeserialized.TopWidth);
            TestUtility.TestLengthsAreEqual(prfl.BottomWidth, prflDeserialized.BottomWidth);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);

            // Act
            ITrapezoid prfl = new Trapezoid(wTop, wBottom, h);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(5, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                -27,
27,
250,
-250,
-27
};

            var expectedV = new List<double>() {
                11.5,
11.5,
-11.5,
-11.5,
11.5
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
