using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization;
using UnitsNet;
using UnitsNet.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class ITests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            II prfl = new I(h, w, flangeThk, webThk);

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
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            II prfl = new I(h, w, flangeThk, webThk);
            string json = prfl.ToJson();
            II prflDeserialized = json.FromJson<II>();

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
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            II prfl = new I(h, w, flangeThk, webThk);
            string json = prfl.ToJson();
            II prflDeserialized = json.FromJson<I>();

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
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            II prfl = new I(h, w, flangeThk, webThk);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(13, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                -252,
252,
252,
5.45,
5.45,
252,
252,
-252,
-252,
-5.45,
-5.45,
-252,
-252,
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
-86.5,
-86.5,
86.5,
86.5,
101.5
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
