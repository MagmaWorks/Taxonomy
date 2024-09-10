using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class ChannelTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);

            // Act
            IChannel prfl = new Channel(h, w, webThk, flangeThk);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(webThk, prfl.WebThickness);
            TestUtility.TestLengthsAreEqual(flangeThk, prfl.FlangeThickness);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);

            // Act
            IChannel prfl = new Channel(h, w, webThk, flangeThk);
            string json = prfl.ToJson();
            IChannel prflDeserialized = json.FromJson<IChannel>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);

            // Act
            IChannel prfl = new Channel(h, w, webThk, flangeThk);
            string json = prfl.ToJson();
            IChannel prflDeserialized = json.FromJson<Channel>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(20.3, LengthUnit.Centimeter);
            var w = new Length(50.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);

            // Act
            IChannel prfl = new Channel(h, w, webThk, flangeThk);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(9, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.U.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.V.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                0,
504,
504,
10.9,
10.9,
504,
504,
0,
0,
            };

            var expectedV = new List<double>() {
                101.5,
101.5,
86.5,
86.5,
-86.5,
-86.5,
-101.5,
-101.5,
101.5
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
