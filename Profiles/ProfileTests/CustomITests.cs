using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
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
        public void SerializationTest()
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

            // Assert
            string expected = _prflJson.Replace("\r\n", Environment.NewLine);
            Assert.Equal(expected, json);
        }

        [Fact]
        public void DeserializationTest()
        {
            // Assemble
            string json = _prflJson;

            // Act
            ICustomI prfl = json.FromJson<ICustomI>();

            // Assert
            TestUtility.TestLengthsAreEqual(new Length(2.3, LengthUnit.Centimeter), prfl.Height);
            TestUtility.TestLengthsAreEqual(new Length(5.4, LengthUnit.Centimeter), prfl.TopFlangeWidth);
            TestUtility.TestLengthsAreEqual(new Length(0.5, LengthUnit.Meter), prfl.BottomFlangeWidth);
            TestUtility.TestLengthsAreEqual(new Length(10.9, LengthUnit.Millimeter), prfl.WebThickness);
            TestUtility.TestLengthsAreEqual(new Length(15, LengthUnit.Millimeter), prfl.TopFlangeThickness);
            TestUtility.TestLengthsAreEqual(new Length(9.8, LengthUnit.Millimeter), prfl.BottomFlangeThickness);
        }

        [Fact]
        public void SurvivesRoundtripDeserializationTest()
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

        private static string _prflJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"TopFlangeWidth\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"BottomFlangeWidth\": {\r\n    \"Unit\": \"LengthUnit.Meter\",\r\n    \"Value\": 0.5\r\n  },\r\n  \"TopFlangeThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 15.0\r\n  },\r\n  \"BottomFlangeThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 9.8\r\n  },\r\n  \"WebThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  }\r\n}";
    }
}
