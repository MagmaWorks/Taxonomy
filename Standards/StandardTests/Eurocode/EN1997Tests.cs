using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace StandardTests
{
    public class EN1997Tests
    {
        [Theory]
        [InlineData(En1997Part.Part1, NationalAnnex.RecommendedValues,
            "EN 1997-1: Eurocode 7: Geotechnical Design - Part 1: General rules")]
        [InlineData(En1997Part.Part2, NationalAnnex.Denmark,
            "DS EN 1997-2: Eurocode 7: Geotechnical Design - Part 2: Ground investigation and testing")]
        public void ConstructorTest(En1997Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new En1997(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
