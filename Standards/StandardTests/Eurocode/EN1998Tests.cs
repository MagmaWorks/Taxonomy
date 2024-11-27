using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace StandardTests
{
    public class EN1998Tests
    {
        [Theory]
        [InlineData(En1998Part.Part1, NationalAnnex.RecommendedValues,
            "EN 1998-1: Eurocode 8: Design of Structures for Earthquake Resistance - Part 1: General rules, seismic actions and rules for buildings")]
        [InlineData(En1998Part.Part2, NationalAnnex.Denmark,
            "DS EN 1998-2: Eurocode 8: Design of Structures for Earthquake Resistance - Part 2: Bridges")]
        [InlineData(En1998Part.Part3, NationalAnnex.Germany,
            "DIN EN 1998-3: Eurocode 8: Design of Structures for Earthquake Resistance - Part 3: Assessment and retrofitting of buildings")]
        [InlineData(En1998Part.Part4, NationalAnnex.UnitedKingdom,
            "BS EN 1998-4: Eurocode 8: Design of Structures for Earthquake Resistance - Part 4: Silos, tanks and pipelines")]
        public void ConstructorTest(En1998Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new En1998(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
