using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests
{
    public class CTests
    {
        [Fact]
        public void CreateProfileTest()
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
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var lip = new Length(0.01, LengthUnit.Inch);

            // Act
            IC prfl = new C(h, w, webThk, flangeThk, lip);
            string json = prfl.ToJson();
            IC prflDeserialized = json.FromJson<IC>();


            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.Lip, prflDeserialized.Lip);
        }

        [Fact]
        public void ConcreteImplementationSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            var h = new Length(2.3, LengthUnit.Centimeter);
            var w = new Length(5.4, LengthUnit.Centimeter);
            var webThk = new Length(10.9, LengthUnit.Millimeter);
            var flangeThk = new Length(15, LengthUnit.Millimeter);
            var lip = new Length(0.01, LengthUnit.Inch);

            // Act
            IC prfl = new C(h, w, webThk, flangeThk, lip);
            string json = prfl.ToJson();
            IC prflDeserialized = json.FromJson<C>();


            // Assert
            TestUtility.TestLengthsAreEqual(prfl.Height, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(prfl.Width, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(prfl.WebThickness, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(prfl.FlangeThickness, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(prfl.Lip, prflDeserialized.Lip);
        }
    }
}
