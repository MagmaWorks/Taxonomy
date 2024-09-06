using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class RoundedRectangularHollowTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(6, LengthUnit.Centimeter);
            var w = new Length(7, LengthUnit.Centimeter);
            var h1 = new Length(4, LengthUnit.Centimeter);
            var w1 = new Length(5, LengthUnit.Centimeter);
            var thk = new Length(3.8, LengthUnit.Millimeter);

            // Act
            IRoundedRectangularHollow prfl = new RoundedRectangularHollow(h, w, h1, w1, thk);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(h1, prfl.FlatHeight);
            TestUtility.TestLengthsAreEqual(w1, prfl.FlatWidth);
            TestUtility.TestLengthsAreEqual(thk, prfl.Thickness);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(6, LengthUnit.Centimeter);
            var w = new Length(7, LengthUnit.Centimeter);
            var h1 = new Length(4, LengthUnit.Centimeter);
            var w1 = new Length(5, LengthUnit.Centimeter);
            var thk = new Length(3.8, LengthUnit.Millimeter);

            // Act
            IRoundedRectangularHollow prfl = new RoundedRectangularHollow(h, w, h1, w1, thk);
            string json = prfl.ToJson();
            IRoundedRectangularHollow prflDeserialized = json.FromJson<IRoundedRectangularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.FlatHeight, prflDeserialized.FlatHeight);
            TestUtility.TestLengthsAreEqual(prfl.FlatWidth, prflDeserialized.FlatWidth);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(6, LengthUnit.Centimeter);
            var w = new Length(7, LengthUnit.Centimeter);
            var h1 = new Length(4, LengthUnit.Centimeter);
            var w1 = new Length(5, LengthUnit.Centimeter);
            var thk = new Length(3.8, LengthUnit.Millimeter);

            // Act
            IRoundedRectangularHollow prfl = new RoundedRectangularHollow(h, w, h1, w1, thk);
            string json = prfl.ToJson();
            IRoundedRectangularHollow prflDeserialized = json.FromJson<RoundedRectangularHollow>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.FlatHeight, prflDeserialized.FlatHeight);
            TestUtility.TestLengthsAreEqual(prfl.FlatWidth, prflDeserialized.FlatWidth);
            TestUtility.TestLengthsAreEqual(prfl.Thickness, prflDeserialized.Thickness);
        }
    }
}
