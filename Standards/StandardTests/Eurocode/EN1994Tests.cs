using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace StandardTests
{
    public class EN1994Tests
    {
        [Theory]
        [InlineData(EN1994Part.Part1_1, NationalAnnex.RecommendedValues,
            "EN 1994-1-1: Eurocode 4: Design of Composite Steel & Concrete Structures - Part 1-1: General rules and rules for buildings")]
        [InlineData(EN1994Part.Part1_2, NationalAnnex.Denmark,
            "DS EN 1994-1-2: Eurocode 4: Design of Composite Steel & Concrete Structures - Part 1-2: General rules - Structural fire design")]
        [InlineData(EN1994Part.Part2, NationalAnnex.Germany,
            "DIN EN 1994-2: Eurocode 4: Design of Composite Steel & Concrete Structures - Part 2: General rules and rules for bridges")]
        public void ConstructorTest(EN1994Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new EN1994(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}