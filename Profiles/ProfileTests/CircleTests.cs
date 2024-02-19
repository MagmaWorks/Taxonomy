using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
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
        public void InterfaceSurvivesRoundtripDeserializationTest()
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

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);

            // Act
            ICircle prfl = new Circle(dia);
            string json = prfl.ToJson();
            ICircle prflDeserialized = json.FromJson<Circle>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Diameter, prflDeserialized.Diameter);
        }
    }
}
