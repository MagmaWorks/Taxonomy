using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.EN;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Sections;
using MagmaWorks.Taxonomy.Serialization.Sections.Extensions;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace SectionTests
{
    public class ConcreteSectionTests
    {
        [Fact]
        public void CreateConcreteSectionTest()
        {
            // Assemble
            IENConcreteMaterial material = new ENConcreteMaterial(ENConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IList<ILongitudinalReinforcement> rebars = LongitudinalReinforcementTests.CreateLongitudinalReinforcements();
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(20, LengthUnit.Millimeter);

            // Act
            IConcreteSection section = new ConcreteSection(profile, material, rebars, link, cover);

            // Assert
            Assert.Equivalent(profile, section.Profile);
            Assert.Equivalent(material, section.Material);
            Assert.Equivalent(rebars, section.Rebars);
            Assert.Equivalent(link, section.Link);
            Assert.Equivalent(cover, section.Cover);
        }


        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            IENConcreteMaterial material = new ENConcreteMaterial(ENConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IList<ILongitudinalReinforcement> rebars = LongitudinalReinforcementTests.CreateLongitudinalReinforcements();
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(20, LengthUnit.Millimeter);
            IConcreteSection section = new ConcreteSection(profile, material, rebars, link, cover);

            // Act
            string json = section.ToJson();
            IConcreteSection sectDeserialized = json.FromJson<IConcreteSection>();

            // Assert
            Assert.Equivalent(section, sectDeserialized);
        }
    }
}
