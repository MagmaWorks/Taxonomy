namespace SectionTests
{
    public class LinkTests
    {
        public static ILink CreateLink(double dia = 10)
        {
            // Assemble
            IEnRebarMaterial material = new EnRebarMaterial(EnRebarGrade.B500B, NationalAnnex.Germany);
            Length diameter = new Length(dia, LengthUnit.Millimeter);

            // Act
            return new Link(material, diameter);
        }

        [Fact]
        public void CreateLinkTest()
        {
            // Assemble
            IEnRebarMaterial expectedMaterial = new EnRebarMaterial(EnRebarGrade.B500B, NationalAnnex.Germany);

            // Act
            ILink link = CreateLink();

            // Assert
            Assert.Equal(10, link.Diameter.Millimeters);
            Assert.Equivalent(expectedMaterial, link.Material);
            Assert.Equal(40, link.MinimumMandrelDiameter.Millimeters);
        }

        [Theory]
        [InlineData(BarDiameter.D8, 4)]
        [InlineData(BarDiameter.D10, 4)]
        [InlineData(BarDiameter.D12, 4)]
        [InlineData(BarDiameter.D13, 4)]
        [InlineData(BarDiameter.D14, 4)]
        [InlineData(BarDiameter.D16, 4)]
        [InlineData(BarDiameter.D20, 7)]
        [InlineData(BarDiameter.D25, 7)]
        [InlineData(BarDiameter.D28, 7)]
        [InlineData(BarDiameter.D32, 7)]
        [InlineData(BarDiameter.D40, 7)]
        [InlineData(BarDiameter.D50, 7)]
        public void CreateLinkFromBarDiameterEnumTest(BarDiameter diameter, double expectedMandrelMultiplier)
        {
            // Assemble
            var material = new EnRebarMaterial(EnRebarGrade.B500B, NationalAnnex.UnitedKingdom);

            // Act
            var link = new Link(material, diameter);

            // Assert
            double expected = double.Parse(diameter.ToString().Remove(0, 1));
            Assert.Equal(expected, link.Diameter.Millimeters);
            Assert.Equivalent(material, link.Material);
            Assert.Equal(expected * expectedMandrelMultiplier, link.MinimumMandrelDiameter.Millimeters);
        }
    }
}
