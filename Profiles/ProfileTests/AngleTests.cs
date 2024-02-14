using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;
using Angle = MagmaWorks.Taxonomy.Profiles.Angle;

namespace ProfileTests
{
    public class AngleTests
    {
        [Fact]
        public void CreateAngleProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);

            // Act
            IAngle angle = new Angle(h, w, webThk, flangeThk);

            // Assert
            TestUtility.TestLengthsAreEqual(h, angle.Height);
            TestUtility.TestLengthsAreEqual(w, angle.Width);
            TestUtility.TestLengthsAreEqual(webThk, angle.WebThickness);
            TestUtility.TestLengthsAreEqual(flangeThk, angle.FlangeThickness);
        }

        [Fact]
        public void AngleSerializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);

            // Act
            IAngle angle = new Angle(h, w, webThk, flangeThk);
            string json = angle.ToJson();
            
            // Assert
            string expected = _angleJson.Replace("\r\n", Environment.NewLine);
            Assert.Equal(expected, json);
        }

        [Fact]
        public void AngleDeserializationTest()
        {
            // Assemble
            string json = _angleJson.Replace("\r\n", Environment.NewLine);

            // Act
            IAngle angle = json.FromJson<IAngle>();
            
            // Assert
            TestUtility.TestLengthsAreEqual(new Length(2.3, LengthUnit.Centimeter), angle.Height);
            TestUtility.TestLengthsAreEqual(new Length(5.4, LengthUnit.Centimeter), angle.Width);
            TestUtility.TestLengthsAreEqual(new Length(10.9, LengthUnit.Millimeter), angle.WebThickness);
            TestUtility.TestLengthsAreEqual(new Length(15, LengthUnit.Millimeter), angle.FlangeThickness);
        }

        [Fact]
        public void AngleSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);

            // Act
            IAngle angle = new Angle(h, w, webThk, flangeThk);
            string json = angle.ToJson();
            IAngle angleDeserialized = json.FromJson<IAngle>();


            // Assert
            TestUtility.TestLengthsAreEqual(angle.Height, angleDeserialized.Height);
            TestUtility.TestLengthsAreEqual(angle.Width, angleDeserialized.Width);
            TestUtility.TestLengthsAreEqual(angle.WebThickness, angleDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(angle.FlangeThickness, angleDeserialized.FlangeThickness);
        }

        private static string _angleJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"Width\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"WebThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  },\r\n  \"FlangeThickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 15.0\r\n  }\r\n}";
    }
}
