using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;

namespace ProfileTests
{
    public class NullTests
    {
        [Fact]
        public void DeserializationTest()
        {
            // Assemble
            string json = _prflJson;

            // Act
            IProfile prfl = json.FromJson<IProfile>();
            
            // Assert
            Assert.Null(prfl);
        }

        private static string _prflJson = "{\r\n  \"Height\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 2.3\r\n  },\r\n  \"TopFlangeWidth\": {\r\n    \"Unit\": \"LengthUnit.Centimeter\",\r\n    \"Value\": 5.4\r\n  },\r\n  \"BottomFlangeWidth\": {\r\n    \"Unit\": \"LengthUnit.Meter\",\r\n    \"Value\": 0.5\r\n  },\r\n  \"Thickness\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 10.9\r\n  },\r\n  \"TopLip\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 15.0\r\n  },\r\n  \"BottomLip\": {\r\n    \"Unit\": \"LengthUnit.Millimeter\",\r\n    \"Value\": 9.8\r\n  }\r\n}";
    }
}
