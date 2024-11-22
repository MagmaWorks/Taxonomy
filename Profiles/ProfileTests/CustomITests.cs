using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class CustomITests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var topFlangeThk = new Length(15, LengthUnit.Millimeter);
            var bottomFlangeThk = new Length(9.8, LengthUnit.Millimeter);

            // Act
            ICustomI prfl = new CustomI(h, wTop, wBottom, topFlangeThk, bottomFlangeThk, webThk);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(wTop, prfl.TopFlangeWidth);
            TestUtility.TestLengthsAreEqual(wBottom, prfl.BottomFlangeWidth);
            TestUtility.TestLengthsAreEqual(webThk, prfl.WebThickness);
            TestUtility.TestLengthsAreEqual(topFlangeThk, prfl.TopFlangeThickness);
            TestUtility.TestLengthsAreEqual(bottomFlangeThk, prfl.BottomFlangeThickness);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var topFlangeThk = new Length(15, LengthUnit.Millimeter);
            var bottomFlangeThk = new Length(9.8, LengthUnit.Millimeter);

            // Act
            ICustomI prfl = new CustomI(h, wTop, wBottom, topFlangeThk, bottomFlangeThk, webThk);
            string json = prfl.ToJson();
            ICustomI prflDeserialized = json.FromJson<ICustomI>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.TopFlangeWidth, prflDeserialized.TopFlangeWidth);
            TestUtility.TestLengthsAreEqual(prfl.BottomFlangeWidth, prflDeserialized.BottomFlangeWidth);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.TopFlangeThickness, prflDeserialized.TopFlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.BottomFlangeThickness, prflDeserialized.BottomFlangeThickness);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var topFlangeThk = new Length(15, LengthUnit.Millimeter);
            var bottomFlangeThk = new Length(9.8, LengthUnit.Millimeter);

            // Act
            ICustomI prfl = new CustomI(h, wTop, wBottom, topFlangeThk, bottomFlangeThk, webThk);
            string json = prfl.ToJson();
            ICustomI prflDeserialized = json.FromJson<CustomI>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.TopFlangeWidth, prflDeserialized.TopFlangeWidth);
            TestUtility.TestLengthsAreEqual(prfl.BottomFlangeWidth, prflDeserialized.BottomFlangeWidth);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.TopFlangeThickness, prflDeserialized.TopFlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.BottomFlangeThickness, prflDeserialized.BottomFlangeThickness);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(20, LengthUnit.Centimeter);
            var wTop = new Length(20, LengthUnit.Centimeter);
            var wBottom = new Length(25, LengthUnit.Centimeter);
            var webThk = new Length(5, LengthUnit.Centimeter);
            var topFlangeThk = new Length(7, LengthUnit.Centimeter);
            var bottomFlangeThk = new Length(3, LengthUnit.Centimeter);

            // Act
            ICustomI prfl = new CustomI(h, wTop, wBottom, topFlangeThk, bottomFlangeThk, webThk);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(13, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                -100,
100,
100,
25,
25,
125,
125,
-125,
-125,
-25,
-25,
-100,
-100,
};

            var expectedV = new List<double>() {
                100,
100,
30,
30,
-70,
-70,
-100,
-100,
-70,
-70,
30,
30,
100,
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
