using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class CTests
    {
        [Fact]
        public void CreateCProfileTest()
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
        public void CSerializationTest()
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
            Assert.Equal(_cJson, json);
        }

        [Fact]
        public void CDeserializationTest()
        {
            // Assemble
            string json = _cJson;

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
        public void CSurvivesRoundtripDeserializationTest()
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
            IC cDeserialized = json.FromJson<IC>();


            // Assert
            TestUtility.TestLengthsAreEqual(c.Height, cDeserialized.Height);
            TestUtility.TestLengthsAreEqual(c.Width, cDeserialized.Width);
            TestUtility.TestLengthsAreEqual(c.WebThickness, cDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(c.FlangeThickness, cDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(c.Lip, cDeserialized.Lip);
        }

        private static string _cJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"Width\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"WebThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  },\r\n  \"FlangeThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 15.0\r\n  },\r\n  \"Lip\": {\r\n    \"Unit\": \"LengthUnit.Inch\",\r\n    \"Value\": 0.01\r\n  }\r\n}";
    }
}
