using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class CircleTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);

            // Act
            ICircle prfl = new Circle(dia);

            // Assert
            TestUtility.TestLengthsAreEqual(dia, prfl.Diameter);
        }

        [Fact]
        public void SerializationTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);

            // Act
            ICircle prfl = new Circle(dia);
            string json = prfl.ToJson();

            // Assert
            string expected = _prflJson.Replace("\r\n", Environment.NewLine);
            Assert.Equal(expected, json);
        }

        [Fact]
        public void DeserializationTest()
        {
            // Assemble
            string json = _prflJson.Replace("\r\n", Environment.NewLine); ;

            // Act
            ICircle c = json.FromJson<ICircle>();
            
            // Assert
            TestUtility.TestLengthsAreEqual(new Length(2.3, LengthUnit.Centimeter), c.Diameter);
        }

        [Fact]
        public void SurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);

            // Act
            ICircle prfl = new Circle(dia);
            string json = prfl.ToJson();
            ICircle prflDeserialized = json.FromJson<ICircle>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Diameter, prflDeserialized.Diameter);
        }

        private static string _prflJson = "{\r\n  \"Diameter\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  }\r\n}";
    }
}
