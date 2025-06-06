namespace StandardTests
{
    public class EN1993Tests
    {
        [Theory]
        [InlineData(En1993Part.Part1_1, NationalAnnex.RecommendedValues,
            "EN 1993-1-1: Eurocode 3: Design of Steel Structures - Part 1-1: General rules and rules for buildings")]
        [InlineData(En1993Part.Part1_2, NationalAnnex.Denmark,
            "DS EN 1993-1-2: Eurocode 3: Design of Steel Structures - Part 1-2: General rules - Structural fire design")]
        [InlineData(En1993Part.Part2, NationalAnnex.Germany,
            "DIN EN 1993-2: Eurocode 3: Design of Steel Structures - Part 2: Steel bridges")]
        [InlineData(En1993Part.Part4_2, NationalAnnex.UnitedKingdom,
            "BS EN 1993-4-2: Eurocode 3: Design of Steel Structures - Part 4-2: Tanks")]
        public void ConstructorTest(En1993Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new En1993(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
