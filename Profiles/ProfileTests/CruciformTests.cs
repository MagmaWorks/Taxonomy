using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

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
        public void SerializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            ICruciform prfl = new Cruciform(h, w, flangeThk, webThk);
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
            ICruciform prfl = json.FromJson<ICruciform>();
            
            // Assert
            TestUtility.TestLengthsAreEqual(new Length(2.3, LengthUnit.Centimeter), prfl.Height);
            TestUtility.TestLengthsAreEqual(new Length(5.4, LengthUnit.Centimeter), prfl.Width);
            TestUtility.TestLengthsAreEqual(new Length(10.9, LengthUnit.Millimeter), prfl.WebThickness);
            TestUtility.TestLengthsAreEqual(new Length(15, LengthUnit.Millimeter), prfl.FlangeThickness);
        }

        [Fact]
        public void SurvivesRoundtripDeserializationTest()
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

        private static string _prflJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"Width\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"FlangeThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 15.0\r\n  },\r\n  \"WebThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  }\r\n}";
    }
}
