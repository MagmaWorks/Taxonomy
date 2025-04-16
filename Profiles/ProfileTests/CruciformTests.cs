namespace ProfileTests
{
    public class CruciformTests
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
            ICruciform prfl = new Cruciform(h, w, flangeThk, webThk);

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
            ICruciform prfl = new Cruciform(h, w, flangeThk, webThk);
            string json = prfl.ToJson();
            ICruciform prflDeserialized = json.FromJson<ICruciform>();

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
            ICruciform prfl = new Cruciform(h, w, flangeThk, webThk);
            string json = prfl.ToJson();
            ICruciform prflDeserialized = json.FromJson<Cruciform>();

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
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);

            // Act
            ICruciform prfl = new Cruciform(h, w, flangeThk, webThk);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(13, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                -5.45,
-5.45,
5.45,
5.45,
27,
27,
5.45,
5.45,
-5.45,
-5.45,
-27,
-27,
-5.45,
};

            var expectedV = new List<double>() {
                7.5,
11.5,
11.5,
7.5,
7.5,
-7.5,
-7.5,
-11.5,
-11.5,
-7.5,
-7.5,
7.5,
7.5,
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
