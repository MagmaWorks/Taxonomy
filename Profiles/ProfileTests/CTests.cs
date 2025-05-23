namespace ProfileTests
{
    public class CTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var lip = new Length(0.01, LengthUnit.Inch);

            // Act
            IC c = new C(h, w, webThk, flangeThk, lip);

            // Assert
            TestUtility.TestLengthsAreEqual(h, c.Height);
            TestUtility.TestLengthsAreEqual(w, c.Width);
            TestUtility.TestLengthsAreEqual(webThk, c.WebThickness);
            TestUtility.TestLengthsAreEqual(flangeThk, c.FlangeThickness);
            TestUtility.TestLengthsAreEqual(lip, c.Lip);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var lip = new Length(0.01, LengthUnit.Inch);

            // Act
            IC prfl = new C(h, w, webThk, flangeThk, lip);
            string json = prfl.ToJson();
            IC prflDeserialized = json.FromJson<IC>();


            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.Lip, prflDeserialized.Lip);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var lip = new Length(0.01, LengthUnit.Inch);

            // Act
            IC prfl = new C(h, w, webThk, flangeThk, lip);
            string json = prfl.ToJson();
            IC prflDeserialized = json.FromJson<C>();


            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.Lip, prflDeserialized.Lip);
        }

        [Fact]
        public void GetPerimeterTest()
        {
            // Assemble
            var h = new Length(20.3, LengthUnit.Centimeter);
            var w = new Length(50.4, LengthUnit.Centimeter);
            var webThk = new Length(7.9, LengthUnit.Millimeter);
            var flangeThk = new Length(10, LengthUnit.Millimeter);
            var lip = new Length(50, LengthUnit.Millimeter);

            // Act
            IC prfl = new C(h, w, webThk, flangeThk, lip);
            IPerimeter perimeter = new Perimeter(prfl);

            // Assert
            Assert.Equal(13, perimeter.OuterEdge.Points.Count);
            List<double> u = perimeter.OuterEdge.Points.Select(x => x.Y.Millimeters).ToList();
            List<double> v = perimeter.OuterEdge.Points.Select(x => x.Z.Millimeters).ToList();

            var expectedU = new List<double>()
            {
                0,
504,
504,
494,
494,
7.9,
7.9,
494,
494,
504,
504,
0,
0
};

            var expectedV = new List<double>() {
                101.5,
101.5,
51.5,
51.5,
91.5,
91.5,
-91.5,
-91.5,
-51.5,
-51.5,
-101.5,
-101.5,
101.5
};

            TestUtility.TestListsOfDoublesAreEqual(expectedU, u);
            TestUtility.TestListsOfDoublesAreEqual(expectedV, v);
        }
    }
}
