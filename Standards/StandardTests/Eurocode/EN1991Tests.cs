using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace StandardTests
{
    public class EN1991Tests
    {
        [Theory]
        [InlineData(En1991Part.Part1_1, NationalAnnex.RecommendedValues,
            "EN 1991-1-1: Eurocode 1: Actions on Structures - Part 1-1: General actions - Densities, self-weight, imposed loads for buildings")]
        [InlineData(En1991Part.Part1_3, NationalAnnex.Denmark,
            "DS EN 1991-1-3: Eurocode 1: Actions on Structures - Part 1-3: General actions - Snow loads")]
        [InlineData(En1991Part.Part1_4, NationalAnnex.Germany,
            "DIN EN 1991-1-4: Eurocode 1: Actions on Structures - Part 1-4: General actions - Wind actions")]
        [InlineData(En1991Part.Part1_5, NationalAnnex.UnitedKingdom,
            "BS EN 1991-1-5: Eurocode 1: Actions on Structures - Part 1-5: General actions - Thermal actions")]
        public void ConstructorTest(En1991Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new En1991(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
