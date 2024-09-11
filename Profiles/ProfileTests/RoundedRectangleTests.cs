using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class RoundedRectangleTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(4, LengthUnit.Centimeter);
            var w = new Length(5, LengthUnit.Centimeter);
            var h1 = new Length(3, LengthUnit.Centimeter);
            var w1 = new Length(4, LengthUnit.Centimeter);

            // Act
            IRoundedRectangle prfl = new RoundedRectangle(h, w, h1, w1);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(h1, prfl.FlatHeight);
            TestUtility.TestLengthsAreEqual(w1, prfl.FlatWidth);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(4, LengthUnit.Centimeter);
            var w = new Length(5, LengthUnit.Centimeter);
            var h1 = new Length(3, LengthUnit.Centimeter);
            var w1 = new Length(4, LengthUnit.Centimeter);

            // Act
            IRoundedRectangle prfl = new RoundedRectangle(h, w, h1, w1);
            string json = prfl.ToJson();
            IRoundedRectangle prflDeserialized = json.FromJson<IRoundedRectangle>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.FlatHeight, prflDeserialized.FlatHeight);
            TestUtility.TestLengthsAreEqual(prfl.FlatWidth, prflDeserialized.FlatWidth);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(4, LengthUnit.Centimeter);
            var w = new Length(5, LengthUnit.Centimeter);
            var h1 = new Length(3, LengthUnit.Centimeter);
            var w1 = new Length(4, LengthUnit.Centimeter);

            // Act
            IRoundedRectangle prfl = new RoundedRectangle(h, w, h1, w1);
            string json = prfl.ToJson();
            IRoundedRectangle prflDeserialized = json.FromJson<RoundedRectangle>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.FlatHeight, prflDeserialized.FlatHeight);
            TestUtility.TestLengthsAreEqual(prfl.FlatWidth, prflDeserialized.FlatWidth);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(25, LengthUnit.Centimeter);
            var w = new Length(20, LengthUnit.Centimeter);
            var h1 = new Length(20, LengthUnit.Centimeter);
            var w1 = new Length(10, LengthUnit.Centimeter);

            // Act
            IRoundedRectangle prfl = new RoundedRectangle(h, w, h1, w1);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(37, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.U.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.V.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                100,
99.0392640201615,
96.19397662556432,
91.57348061512727,
85.35533905932738,
77.7785116509801,
69.1341716182545,
59.75451610080642,
49.99999999999998,
-50.000000000000014,
-59.754516100806434,
-69.13417161825451,
-77.7785116509801,
-85.35533905932738,
-91.57348061512728,
-96.19397662556433,
-99.03926402016153,
-100,
-100,
-99.03926402016153,
-96.19397662556433,
-91.57348061512727,
-85.35533905932738,
-77.7785116509801,
-69.13417161825448,
-59.75451610080642,
-50,
50,
59.75451610080642,
69.1341716182545,
77.77851165098012,
85.35533905932738,
91.57348061512727,
96.19397662556433,
99.03926402016153,
100,
100,
};

            var expectedV = new List<double>() {
               -100,
-104.87725805040323,
-109.56708580912728,
-113.88925582549004,
-117.67766952966369,
-120.78674030756365,
-123.09698831278216,
-124.51963201008077,
-125,
-125,
-124.51963201008076,
-123.09698831278214,
-120.78674030756365,
-117.67766952966369,
-113.88925582549004,
-109.56708580912725,
-104.87725805040323,
-100,
100,
104.87725805040323,
109.56708580912725,
113.88925582549004,
117.67766952966369,
120.78674030756365,
123.09698831278216,
124.51963201008077,
125,
125,
124.51963201008077,
123.09698831278216,
120.78674030756365,
117.67766952966369,
113.88925582549004,
109.56708580912725,
104.8772580504032,
100,
-100,
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
