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

        private static string _prflJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"TopFlangeWidth\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"BottomFlangeWidth\": {\r\n    \"Unit\": \"LengthUnit.Meter\",\r\n    \"Value\": 0.5\r\n  },\r\n  \"Thickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  },\r\n  \"TopLip\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 15.0\r\n  },\r\n  \"BottomLip\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 9.8\r\n  }\r\n}";
    }
}
