using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Profiles.Utilities;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class RectangularHollowTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            IRectangularHollow prfl = new RectangularHollow(h, w, thk);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(thk, prfl.Thickness);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            IRectangularHollow prfl = new RectangularHollow(h, w, thk);
            string json = prfl.ToJson();
            IRectangularHollow prflDeserialized = json.FromJson<IRectangularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            IRectangularHollow prfl = new RectangularHollow(h, w, thk);
            string json = prfl.ToJson();
            IRectangularHollow prflDeserialized = json.FromJson<RectangularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(20.3, LengthUnit.Centimeter);
            var w = new Length(50.4, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            IRectangularHollow prfl = new RectangularHollow(h, w, thk);
            IPerimeter perimeter = prfl.GetPerimeter();

            // Assert
            Assert.Equal(5, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.U.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.V.Millimeters).ToList();

            Assert.Single(perimeter.VoidEdges);
            Assert.Equal(5, perimeter.VoidEdges[0].Points.Count);
            List<double> ui = perimeter.VoidEdges[0].Points.Select(x => x.U.Millimeters).ToList();
            List<double> vi = perimeter.VoidEdges[0].Points.Select(x => x.V.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                -252,
252,
252,
-252,
-252,
};

            var expectedV = new List<double>() {
               101.5,
101.5,
-101.5,
-101.5,
101.5
};

            var expectedUi = new List<double>()
            {
                -241.1,
241.1,
241.1,
-241.1,
-241.1
};

            var expectedVi = new List<double>() {
               90.6,
90.6,
-90.6,
-90.6,
90.6
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
