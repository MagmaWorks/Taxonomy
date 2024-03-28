using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Serialization.Profiles.Extensions;
using OasysUnits;
using OasysUnits.Units;
using ProfileTests.Utility;

namespace ProfileTests.Catalogue
{
    public class HEB100Tests
    {
        [Fact]
        public void CreateIProfileTest()
        {
            // Assemble
            // Act
            II prfl = new HEB100();

            // Assert
            var h = new Length(100, LengthUnit.Millimeter);
            var w = new Length(100, LengthUnit.Millimeter);
            var webThk = new Length(6, LengthUnit.Millimeter);
            var flangeThk = new Length(10, LengthUnit.Millimeter);
            var rootRadius = new Length(12, LengthUnit.Millimeter);
            TestUtility.TestLengthsAreEqual(h, prfl.Height);
            TestUtility.TestLengthsAreEqual(w, prfl.Width);
            TestUtility.TestLengthsAreEqual(webThk, prfl.WebThickness);
            TestUtility.TestLengthsAreEqual(flangeThk, prfl.FlangeThickness);
            TestUtility.TestLengthsAreEqual(rootRadius, prfl.FilletRadius);
        }

        [Fact]
        public void CreateEuropeanCatalogueTest()
        {
            // Act
            IEuropeanCatalogue prfl = new HEB100();

            // Assert
            Assert.NotNull(prfl);
            Assert.Equal(EuropeanShapeType.HEB, prfl.ShapeType);
            Assert.Equal(EuropeanShapeType.HEB, prfl.Type);
        }

        [Fact]
        public void CreateCatalogueTest()
        {
            // Act
            ICatalogue prfl = new HEB100();

            // Assert
            Assert.NotNull(prfl);
            Assert.Equal("HEB100", prfl.Designation);
            Assert.Equal(MagmaWorks.Taxonomy.Profiles.Catalogue.EuropeanEN10365, prfl.Catalogue);
        }

        [Fact]
        public void IProfileSurvivesRoundtripDeserializationTest()
        {
            // Act
            var prfl = new HEB100();
            string json = prfl.ToJson();
            II prflDeserialized = json.FromJson<II>();

            // Assert
            var h = new Length(100, LengthUnit.Millimeter);
            var w = new Length(100, LengthUnit.Millimeter);
            var webThk = new Length(6, LengthUnit.Millimeter);
            var flangeThk = new Length(10, LengthUnit.Millimeter);
            var rootRadius = new Length(12, LengthUnit.Millimeter);
            TestUtility.TestLengthsAreEqual(h, prflDeserialized.Height);
            TestUtility.TestLengthsAreEqual(w, prflDeserialized.Width);
            TestUtility.TestLengthsAreEqual(webThk, prflDeserialized.WebThickness);
            TestUtility.TestLengthsAreEqual(flangeThk, prflDeserialized.FlangeThickness);
            TestUtility.TestLengthsAreEqual(rootRadius, prflDeserialized.FilletRadius);
        }

        [Fact]
        public void EuropeanCatalogueSurvivesRoundtripDeserializationTest()
        {
            // Act
            var prfl = new HEB100();
            string json = prfl.ToJson();
            IEuropeanCatalogue prflDeserialized = json.FromJson<IEuropeanCatalogue>();

            // Assert
            Assert.NotNull(prfl);
            Assert.Equal(EuropeanShapeType.HEB, prflDeserialized.ShapeType);
            Assert.Equal(EuropeanShapeType.HEB, prflDeserialized.Type);
        }

        [Fact]
        public void CatalogueSurvivesRoundtripDeserializationTest()
        {
            // Act
            var prfl = new HEB100();
            string json = prfl.ToJson();
            ICatalogue prflDeserialized = json.FromJson<ICatalogue>();

            // Assert
            Assert.NotNull(prflDeserialized);
            Assert.Equal("HEB100", prflDeserialized.Designation);
            Assert.Equal(MagmaWorks.Taxonomy.Profiles.Catalogue.EuropeanEN10365, prflDeserialized.Catalogue);
        }
    }
}
