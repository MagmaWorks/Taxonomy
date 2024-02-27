using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class DoubleChannelTests
    {
        [Fact]
        public void CreateProfileTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);

            // Act
            IDoubleChannel prfl = new DoubleChannel(h, w, webThk, flangeThk, dist);

            // Assert
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(webThk, prfl.WebThickness);
            TestUtility.TestLengthsAreEqual(flangeThk, prfl.FlangeThickness);
            TestUtility.TestLengthsAreEqual(dist, prfl.BackToBackDistance);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);

            // Act
            IDoubleChannel prfl = new DoubleChannel(h, w, webThk, flangeThk, dist);
            string json = prfl.ToJson();
            IDoubleChannel prflDeserialized = json.FromJson<IDoubleChannel>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.BackToBackDistance, prflDeserialized.BackToBackDistance);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var dist = new Length(2.5, LengthUnit.Millimeter);

            // Act
            IDoubleChannel prfl = new DoubleChannel(h, w, webThk, flangeThk, dist);
            string json = prfl.ToJson();
            IDoubleChannel prflDeserialized = json.FromJson<DoubleChannel>();

            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.BackToBackDistance, prflDeserialized.BackToBackDistance);
        }
    }
}
