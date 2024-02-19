using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
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
        public void InterfaceSurvivesRoundtripDeserializationTest()
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

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var dia = new Length(2.3, LengthUnit.Centimeter);
            var thk = new Length(10.9, LengthUnit.Millimeter);

            // Act
            ICircularHollow prfl = new CircularHollow(dia, thk);
            string json = prfl.ToJson();
            ICircularHollow prflDeserialized = json.FromJson<CircularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Diameter, prflDeserialized.Diameter);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }
    }
}
