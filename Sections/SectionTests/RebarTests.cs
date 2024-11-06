using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Sections;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace SectionTests
{
    public class RebarTests
    {
        public static IRebar CreateRebar(double dia = 20)
        {
            // Assemble
            IStandardMaterial material = new ENRebarMaterial(ENRebarGrade.B500B, NationalAnnex.Germany);
            Length diameter = new Length(dia, LengthUnit.Millimeter);

            // Act
            return new Rebar(material, diameter);
        }

        [Fact]
        public void CreateRebarTest()
        {
            // Assemble
            IStandardMaterial expectedMaterial = new ENRebarMaterial(ENRebarGrade.B500B, NationalAnnex.Germany);

            // Act
            IRebar rebar = CreateRebar();

            // Assert
            Assert.Equal(20, rebar.Diameter.Millimeters);
            Assert.Equivalent(expectedMaterial, rebar.Material);
        }
    }
}
