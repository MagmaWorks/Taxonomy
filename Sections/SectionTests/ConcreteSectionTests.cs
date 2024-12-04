using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Sections;
using MagmaWorks.Taxonomy.Sections.Exceptions;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace SectionTests
{
    public class ConcreteSectionTests
    {
        [Fact]
        public void CreateConcreteSectionFromProfileAndMaterialTest()
        {
            // Assemble
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));

            // Act
            IConcreteSection section = new ConcreteSection(profile, material);

            // Assert
            Assert.Equivalent(profile, section.Profile);
            Assert.Equivalent(material, section.Material);
        }

        [Fact]
        public void CreateConcreteSectionFromProfileEnMaterialAndLinkTest()
        {
            // Assemble
            var material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            material.MinimumCover = new Length(50, LengthUnit.Centimeter);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IRebar link = RebarTests.CreateRebar(8);

            // Act
            IConcreteSection section = new ConcreteSection(profile, material, link);

            // Assert
            Assert.Equivalent(profile, section.Profile);
            Assert.Equivalent(material, section.Material);
            Assert.Equivalent(link, section.Link);
            Assert.Equivalent(material.MinimumCover, section.Cover);
        }

        [Fact]
        public void CreateConcreteSectionFromProfileMaterialLinkAndCoverTest()
        {
            // Assemble
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(20, LengthUnit.Millimeter);

            // Act
            IConcreteSection section = new ConcreteSection(profile, material, link, cover);

            // Assert
            Assert.Equivalent(profile, section.Profile);
            Assert.Equivalent(material, section.Material);
            Assert.Equivalent(link, section.Link);
            Assert.Equivalent(cover, section.Cover);
        }

        [Fact]
        public void CreateConcreteSectionFromProfileMaterialLinkCoverAndRebarsTest()
        {
            // Assemble
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IList<ILongitudinalReinforcement> rebars = LongitudinalReinforcementTests.CreateLongitudinalReinforcements();
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(20, LengthUnit.Millimeter);

            // Act
            IConcreteSection section = new ConcreteSection(profile, material, link, cover, rebars);

            // Assert
            Assert.Equivalent(profile, section.Profile);
            Assert.Equivalent(material, section.Material);
            Assert.Equivalent(rebars, section.Rebars);
            Assert.Equivalent(link, section.Link);
            Assert.Equivalent(cover, section.Cover);
        }

        [Fact]
        public void MinimumReinforcementSpacingTest()
        {
            // Assemble
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IList<ILongitudinalReinforcement> rebars = LongitudinalReinforcementTests.CreateLongitudinalReinforcements();
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(20, LengthUnit.Millimeter);
            var section = new ConcreteSection(profile, material, link, cover, rebars);

            // Act - governed by max aggrigate size + 5mm
            Length minSpacing = section.MinimumReinforcementSpacing.GetMinimumReinforcementSpacing(
                new Length(12, LengthUnit.Millimeter));
            Assert.Equal(25, minSpacing.Millimeters);

            // Act - governed by bar diameter
            minSpacing = section.MinimumReinforcementSpacing.GetMinimumReinforcementSpacing(
                new Length(32, LengthUnit.Millimeter));
            Assert.Equal(32, minSpacing.Millimeters);

            // Act - governed by absolute min spacing
            section.MinimumReinforcementSpacing.AbsoluteMinimumSpacing = new Length(50, LengthUnit.Millimeter);
            minSpacing = section.MinimumReinforcementSpacing.GetMinimumReinforcementSpacing(
                new Length(32, LengthUnit.Millimeter));
            Assert.Equal(50, minSpacing.Millimeters);
        }


        [Fact]
        public void ConcreteSectionWithInvalidMaterialTest()
        {
            // Assemble
            IEnRebarMaterial material = new EnRebarMaterial(EnRebarGrade.B500B, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IList<ILongitudinalReinforcement> rebars = LongitudinalReinforcementTests.CreateLongitudinalReinforcements();
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(20, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<InvalidMaterialTypeException>(() => new ConcreteSection(profile, material));
            Assert.Throws<InvalidMaterialTypeException>(() => new ConcreteSection(profile, material, link, cover));
            Assert.Throws<InvalidMaterialTypeException>(() => new ConcreteSection(profile, material, link, cover, rebars));
        }
    }
}
