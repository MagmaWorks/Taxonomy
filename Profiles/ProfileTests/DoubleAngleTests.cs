using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class DoubleAngleTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);

            // Act
            IDoubleAngle prfl = new DoubleAngle(h, w, webThk, flangeThk, dist);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(webThk, prfl.WebThickness);
            TestUtility.TestLengthsAreEqual(flangeThk, prfl.FlangeThickness);
            TestUtility.TestLengthsAreEqual(dist, prfl.BackToBackDistance);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);

            // Act
            IDoubleAngle prfl = new DoubleAngle(h, w, webThk, flangeThk, dist);
            string json = prfl.ToJson();
            IDoubleAngle prflDeserialized = json.FromJson<IDoubleAngle>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.BackToBackDistance, prflDeserialized.BackToBackDistance);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);

            // Act
            IDoubleAngle prfl = new DoubleAngle(h, w, webThk, flangeThk, dist);
            string json = prfl.ToJson();
            IDoubleAngle prflDeserialized = json.FromJson<DoubleAngle>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.BackToBackDistance, prflDeserialized.BackToBackDistance);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);

            // Act
            IDoubleAngle prfl = new DoubleAngle(h, w, webThk, flangeThk, dist);
            (IPerimeter perimeter1, IPerimeter perimeter2) = Perimeter.CreatePerimeters(prfl);

            // Assert
            Assert.Equal(7, perimeter1.OuterEdge.Points.Count);
            List<double> u1 = perimeter1.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v1 = perimeter1.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            Assert.Equal(7, perimeter2.OuterEdge.Points.Count);
            List<double> u2 = perimeter2.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v2 = perimeter2.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU1 = new List<double>()
            {
                1.25,
1.25,
12.15,
12.15,
55.25,
55.25,
1.25,
};

            var expectedV1 = new List<double>() {
                0,
23,
23,
15,
15,
0,
0
};

            var expectedU2 = new List<double>()
            {
                -1.25,
-1.25,
-12.15,
-12.15,
-55.25,
-55.25,
-1.25
};

            var expectedV2 = new List<double>() {
                0,
23,
23,
15,
15,
0,
0
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU1, u1);
            TestUtility.TestListsOfDoublesAreEqual(expectedV1, v1);
            TestUtility.TestListsOfDoublesAreEqual(expectedU2, u2);
            TestUtility.TestListsOfDoublesAreEqual(expectedV2, v2);
        }
    }
}
