using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace StandardTests
{
    public class EN1996Tests
    {
        [Theory]
        [InlineData(En1996Part.Part1_1, NationalAnnex.RecommendedValues,
            "EN 1996-1-1: Eurocode 6: Design of Masonry Structures - Part 1-1: General rules for reinforced and unreinforced masonry structures")]
        [InlineData(En1996Part.Part1_2, NationalAnnex.Denmark,
            "DS EN 1996-1-2: Eurocode 6: Design of Masonry Structures - Part 1-2: General rules - Structural fire design")]
        [InlineData(En1996Part.Part2, NationalAnnex.Germany,
            "DIN EN 1996-2: Eurocode 6: Design of Masonry Structures - Part 2: Design considerations, selection of materials and execution of masonry")]
        [InlineData(En1996Part.Part3, NationalAnnex.UnitedKingdom,
            "BS EN 1996-3: Eurocode 6: Design of Masonry Structures - Part 3: Simplified calculation methods for unreinforced masonry structures")]
        public void ConstructorTest(En1996Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new En1996(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
