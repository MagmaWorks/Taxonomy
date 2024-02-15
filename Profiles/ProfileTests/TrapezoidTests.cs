using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class TrapezoidTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);

            // Act
            ITrapezoid prfl = new Trapezoid(h, wTop, wBottom);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(wTop, prfl.TopWidth);
            TestUtility.TestLengthsAreEqual(wBottom, prfl.BottomWidth);
        }

        [Fact]
        public void SerializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var wTop = new Length(5.4, LengthUnit.Centimeter);
            var wBottom = new Length(0.5, LengthUnit.Meter);

            // Act
            ITrapezoid prfl = new Trapezoid(h, wTop, wBottom);
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
            ITrapezoid prfl = json.FromJson<ITrapezoid>();
            
            // Assert
            TestUtility.TestLengthsAreEqual(new Length(2.3, LengthUnit.Centimeter), prfl.Height);
            TestUtility.TestLengthsAreEqual(new Length(5.4, LengthUnit.Centimeter), prfl.TopWidth);
            TestUtility.TestLengthsAreEqual(new Length(0.5, LengthUnit.Meter), prfl.BottomWidth);
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
            ITrapezoid prfl = new Trapezoid(h, wTop, wBottom);
            string json = prfl.ToJson();
            ITrapezoid prflDeserialized = json.FromJson<ITrapezoid>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.TopWidth, prflDeserialized.TopWidth);
            TestUtility.TestLengthsAreEqual(prfl.BottomWidth, prflDeserialized.BottomWidth);
        }

        private static string _prflJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"TopWidth\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"BottomWidth\": {\r\n    \"Unit\": \"LengthUnit.Meter\",\r\n    \"Value\": 0.5\r\n  }\r\n}";
    }
}
