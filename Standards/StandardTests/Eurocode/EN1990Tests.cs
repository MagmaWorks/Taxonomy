using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace StandardTests
{
    public class EN1990Tests
    {
        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, "EN 1990: Eurocode - Basis of Structural Design")]
        [InlineData(NationalAnnex.Denmark, "DS EN 1990: Eurocode - Basis of Structural Design")]
        [InlineData(NationalAnnex.Germany, "DIN EN 1990: Eurocode - Basis of Structural Design")]
        [InlineData(NationalAnnex.UnitedKingdom, "BS EN 1990: Eurocode - Basis of Structural Design")]
        public void ConstructorTest(NationalAnnex na, string expectedTitle)
        {
            var standard = new EN1990(na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
