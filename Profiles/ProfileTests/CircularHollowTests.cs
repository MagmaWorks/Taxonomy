using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class CircularHollowTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            ICircularHollow prfl = new CircularHollow(dia, thk);

            // Assert
            TestUtility.TestLengthsAreEqual(dia, prfl.Diameter);
            TestUtility.TestLengthsAreEqual(thk, prfl.Thickness);
        }

        [Fact]
        public void SerializationTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            ICircularHollow prfl = new CircularHollow(dia, thk);
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
            ICircularHollow prfl = json.FromJson<ICircularHollow>();
            
            // Assert
            TestUtility.TestLengthsAreEqual(new Length(2.3, LengthUnit.Centimeter), prfl.Diameter);
            TestUtility.TestLengthsAreEqual(new Length(10.9, LengthUnit.Millimeter), prfl.Thickness);
        }

        [Fact]
        public void SurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            ICircularHollow prfl = new CircularHollow(dia, thk);
            string json = prfl.ToJson();
            ICircularHollow prflDeserialized = json.FromJson<ICircularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Diameter, prflDeserialized.Diameter);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        private static string _prflJson = "{\r\n  \"Diameter\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"Thickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  }\r\n}";
    }
}
