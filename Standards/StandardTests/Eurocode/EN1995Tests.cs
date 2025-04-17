namespace StandardTests
{
    public class EN1995Tests
    {
        [Theory]
        [InlineData(En1995Part.Part1_1, NationalAnnex.RecommendedValues,
            "EN 1995-1-1: Eurocode 5: Design of Timber Structures - Part 1-1: General - Common rules and rules for buildings")]
        [InlineData(En1995Part.Part1_2, NationalAnnex.Denmark,
            "DS EN 1995-1-2: Eurocode 5: Design of Timber Structures - Part 1-2: General - Structural fire design")]
        [InlineData(En1995Part.Part2, NationalAnnex.Germany,
            "DIN EN 1995-2: Eurocode 5: Design of Timber Structures - Part 2: Bridges")]
        public void ConstructorTest(En1995Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new En1995(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
