using System.Security.Cryptography;
using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Sections;
using MagmaWorks.Taxonomy.Sections.Exceptions;
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
            IENRebarMaterial material = new ENRebarMaterial(ENRebarGrade.B500B, NationalAnnex.Germany);
            Length diameter = new Length(dia, LengthUnit.Millimeter);

            // Act
            return new Rebar(material, diameter);
        }

        [Fact]
        public void CreateRebarTest()
        {
            // Assemble
            IENRebarMaterial expectedMaterial = new ENRebarMaterial(ENRebarGrade.B500B, NationalAnnex.Germany);

            // Act
            IRebar rebar = CreateRebar();

            // Assert
            Assert.Equal(20, rebar.Diameter.Millimeters);
            Assert.Equivalent(expectedMaterial, rebar.Material);
        }

        [Fact]
        public void RebarWithInvalidMaterialTest()
        {
            // Assemble
            IENConcreteMaterial material = new ENConcreteMaterial(ENConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            Length diameter = new Length(8, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<InvalidMaterialTypeException>(() => new Rebar(material, diameter));
        }
    }
}
