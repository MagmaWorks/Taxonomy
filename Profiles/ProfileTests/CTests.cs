using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

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
        public void SerializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var lip = new Length(0.01, LengthUnit.Inch);

            // Act
            IC c = new C(h, w, webThk, flangeThk, lip);
            string json = c.ToJson();

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
            IC c = json.FromJson<IC>();
            
            // Assert
            TestUtility.TestLengthsAreEqual(new Length(2.3, LengthUnit.Centimeter), c.Height);
            TestUtility.TestLengthsAreEqual(new Length(5.4, LengthUnit.Centimeter), c.Width);
            TestUtility.TestLengthsAreEqual(new Length(10.9, LengthUnit.Millimeter), c.WebThickness);
            TestUtility.TestLengthsAreEqual(new Length(15, LengthUnit.Millimeter), c.FlangeThickness);
            TestUtility.TestLengthsAreEqual(new Length(0.01, LengthUnit.Inch), c.Lip);
        }

        [Fact]
        public void SurvivesRoundtripDeserializationTest()
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

        private static string _prflJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"Width\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"WebThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  },\r\n  \"FlangeThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 15.0\r\n  },\r\n  \"Lip\": {\r\n    \"Unit\": \"LengthUnit.Inch\",\r\n    \"Value\": 0.01\r\n  }\r\n}";
    }
}
