namespace StandardTests
{
    public class EN1992Tests
    {
        [Theory]
        [InlineData(En1992Part.Part1_1, NationalAnnex.RecommendedValues,
            "EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings")]
        [InlineData(En1992Part.Part1_2, NationalAnnex.Denmark,
            "DS EN 1992-1-2: Eurocode 2: Design of Concrete Structures - Part 1-2: General rules - Structural fire design")]
        [InlineData(En1992Part.Part2, NationalAnnex.Germany,
            "DIN EN 1992-2: Eurocode 2: Design of Concrete Structures - Part 2: Concrete bridges - Design and detailing rules")]
        [InlineData(En1992Part.Part3, NationalAnnex.UnitedKingdom,
            "BS EN 1992-3: Eurocode 2: Design of Concrete Structures - Part 3: Liquid retaining and containment structures")]
        public void ConstructorTest(En1992Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new En1992(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
