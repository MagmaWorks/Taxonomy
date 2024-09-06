using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class RoundedRectangleTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(4, LengthUnit.Centimeter);
            var w = new Length(5, LengthUnit.Centimeter);
            var h1 = new Length(3, LengthUnit.Centimeter);
            var w1 = new Length(4, LengthUnit.Centimeter);

            // Act
            IRoundedRectangle prfl = new RoundedRectangle(h, w, h1, w1);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(h1, prfl.FlatHeight);
            TestUtility.TestLengthsAreEqual(w1, prfl.FlatWidth);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(4, LengthUnit.Centimeter);
            var w = new Length(5, LengthUnit.Centimeter);
            var h1 = new Length(3, LengthUnit.Centimeter);
            var w1 = new Length(4, LengthUnit.Centimeter);

            // Act
            IRoundedRectangle prfl = new RoundedRectangle(h, w, h1, w1);
            string json = prfl.ToJson();
            IRoundedRectangle prflDeserialized = json.FromJson<IRoundedRectangle>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.FlatHeight, prflDeserialized.FlatHeight);
            TestUtility.TestLengthsAreEqual(prfl.FlatWidth, prflDeserialized.FlatWidth);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(4, LengthUnit.Centimeter);
            var w = new Length(5, LengthUnit.Centimeter);
            var h1 = new Length(3, LengthUnit.Centimeter);
            var w1 = new Length(4, LengthUnit.Centimeter);

            // Act
            IRoundedRectangle prfl = new RoundedRectangle(h, w, h1, w1);
            string json = prfl.ToJson();
            IRoundedRectangle prflDeserialized = json.FromJson<RoundedRectangle>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.FlatHeight, prflDeserialized.FlatHeight);
            TestUtility.TestLengthsAreEqual(prfl.FlatWidth, prflDeserialized.FlatWidth);
        }
    }
}
