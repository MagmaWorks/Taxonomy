using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Sections;
using MagmaWorks.Taxonomy.Sections.Exceptions;
using MagmaWorks.Taxonomy.Sections.Reinforcement;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using UnitsNet;
using UnitsNet.Units;

namespace SectionTests
{
    public class RebarTests
    {
        public static IRebar CreateRebar(double dia = 20)
        {
            // Assemble
            IEnRebarMaterial material = new EnRebarMaterial(EnRebarGrade.B500B, NationalAnnex.Germany);
            Length diameter = new Length(dia, LengthUnit.Millimeter);

            // Act
            return new Rebar(material, diameter);
        }

        [Fact]
        public void CreateRebarTest()
        {
            // Assemble
            IEnRebarMaterial expectedMaterial = new EnRebarMaterial(EnRebarGrade.B500B, NationalAnnex.Germany);

            // Act
            IRebar rebar = CreateRebar();

            // Assert
            Assert.Equal(20, rebar.Diameter.Millimeters);
            Assert.Equivalent(expectedMaterial, rebar.Material);
        }

        [Theory]
        [InlineData(BarDiameter.D8)]
        [InlineData(BarDiameter.D10)]
        [InlineData(BarDiameter.D12)]
        [InlineData(BarDiameter.D13)]
        [InlineData(BarDiameter.D14)]
        [InlineData(BarDiameter.D16)]
        [InlineData(BarDiameter.D20)]
        [InlineData(BarDiameter.D25)]
        [InlineData(BarDiameter.D28)]
        [InlineData(BarDiameter.D32)]
        [InlineData(BarDiameter.D40)]
        [InlineData(BarDiameter.D50)]
        public void CreateRebarFromBarDiameterEnumTest(BarDiameter diameter)
        {
            // Assemble
            var material = new EnRebarMaterial(EnRebarGrade.B500B, NationalAnnex.UnitedKingdom);

            // Act
            var rebar = new Rebar(material, diameter);

            // Assert
            double expected = double.Parse(diameter.ToString().Remove(0, 1));
            Assert.Equal(expected, rebar.Diameter.Millimeters);
            Assert.Equivalent(material, rebar.Material);
        }

        [Fact]
        public void RebarWithInvalidMaterialTest()
        {
            // Assemble
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            Length diameter = new Length(8, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<InvalidMaterialTypeException>(() => new Rebar(material, diameter));
        }
    }

}
