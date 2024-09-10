using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class ZTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);
            var thk = new Length(10.9, LengthUnit.Millimeter);
            var topLip = new Length(15, LengthUnit.Millimeter);
            var bottomLip = new Length(9.8, LengthUnit.Millimeter);

            // Act
            IZ prfl = new Z(h, wTop, wBottom, thk, topLip, bottomLip);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(wTop, prfl.TopFlangeWidth);
            TestUtility.TestLengthsAreEqual(wBottom, prfl.BottomFlangeWidth);
            TestUtility.TestLengthsAreEqual(thk, prfl.Thickness);
            TestUtility.TestLengthsAreEqual(topLip, prfl.TopLip);
            TestUtility.TestLengthsAreEqual(bottomLip, prfl.BottomLip);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);
            var thk = new Length(10.9, LengthUnit.Millimeter);
            var topLip = new Length(15, LengthUnit.Millimeter);
            var bottomLip = new Length(9.8, LengthUnit.Millimeter);

            // Act
            IZ prfl = new Z(h, wTop, wBottom, thk, topLip, bottomLip);
            string json = prfl.ToJson();
            IZ prflDeserialized = json.FromJson<IZ>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.TopFlangeWidth, prflDeserialized.TopFlangeWidth);
            TestUtility.TestLengthsAreEqual(prfl.BottomFlangeWidth, prflDeserialized.BottomFlangeWidth);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
            TestUtility.TestLengthsAreEqual(prfl.TopLip, prflDeserialized.TopLip);
            TestUtility.TestLengthsAreEqual(prfl.BottomLip, prflDeserialized.BottomLip);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);
            var thk = new Length(10.9, LengthUnit.Millimeter);
            var topLip = new Length(15, LengthUnit.Millimeter);
            var bottomLip = new Length(9.8, LengthUnit.Millimeter);

            // Act
            IZ prfl = new Z(h, wTop, wBottom, thk, topLip, bottomLip);
            string json = prfl.ToJson();
            IZ prflDeserialized = json.FromJson<Z>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.TopFlangeWidth, prflDeserialized.TopFlangeWidth);
            TestUtility.TestLengthsAreEqual(prfl.BottomFlangeWidth, prflDeserialized.BottomFlangeWidth);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
            TestUtility.TestLengthsAreEqual(prfl.TopLip, prflDeserialized.TopLip);
            TestUtility.TestLengthsAreEqual(prfl.BottomLip, prflDeserialized.BottomLip);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(40, LengthUnit.Centimeter);
            var wTop = new Length(20, LengthUnit.Centimeter);
            var wBottom = new Length(30, LengthUnit.Centimeter);
            var thk = new Length(20, LengthUnit.Millimeter);
            var topLip = new Length(60, LengthUnit.Millimeter);
            var bottomLip = new Length(40, LengthUnit.Millimeter);

            // Act
            IZ prfl = new Z(h, wTop, wBottom, thk, topLip, bottomLip);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(13, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.U.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.V.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                -10,
190,
190,
170,
170,
10,
10,
-290,
-290,
-270,
-270,
-10,
-10
};

            var expectedV = new List<double>() {
                200,
200,
140,
140,
180,
180,
-200,
-200,
-160,
-160,
-180,
-180,
200
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
