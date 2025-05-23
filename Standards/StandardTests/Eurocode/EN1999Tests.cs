namespace StandardTests
{
    public class EN1999Tests
    {
        [Theory]
        [InlineData(En1999Part.Part1_1, NationalAnnex.RecommendedValues,
            "EN 1999-1-1: Eurocode 9: Design of Aluminium Structures - Part 1-1: General structural rules")]
        [InlineData(En1999Part.Part1_2, NationalAnnex.Denmark,
            "DS EN 1999-1-2: Eurocode 9: Design of Aluminium Structures - Part 1-2: Structural fire design")]
        [InlineData(En1999Part.Part1_3, NationalAnnex.Germany,
            "DIN EN 1999-1-3: Eurocode 9: Design of Aluminium Structures - Part 1-3: Structures susceptible to fatigue")]
        [InlineData(En1999Part.Part1_5, NationalAnnex.UnitedKingdom,
            "BS EN 1999-1-5: Eurocode 9: Design of Aluminium Structures - Part 1-5: Shell structures")]
        public void ConstructorTest(En1999Part part, NationalAnnex na, string expectedTitle)
        {
            var standard = new En1999(part, na);
            Assert.Equal(expectedTitle, standard.Title);
        }
    }
}
