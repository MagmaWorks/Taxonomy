using MagmaWorks.Taxonomy.Profiles;
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
        public void SerializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var Thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            IRectangularHollow prfl = new RectangularHollow(h, w, Thk);
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
            IRectangularHollow prfl = json.FromJson<IRectangularHollow>();
            
            // Assert
            TestUtility.TestLengthsAreEqual(new Length(2.3, LengthUnit.Centimeter), prfl.Height);
            TestUtility.TestLengthsAreEqual(new Length(5.4, LengthUnit.Centimeter), prfl.Width);
            TestUtility.TestLengthsAreEqual(new Length(10.9, LengthUnit.Millimeter), prfl.Thickness);
        }

        [Fact]
        public void SurvivesRoundtripDeserializationTest()
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

        private static string _prflJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"Width\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"Thickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  }\r\n}";
    }
}
