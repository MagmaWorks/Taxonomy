﻿using MagmaWorks.Taxonomy.Materials;
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
            IStandardMaterial material = ENConcreteFactory.CreateStandardMaterial(ENConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IList<ILongitudinalReinforcement> rebars = LongitudinalReinforcementTests.CreateLongitudinalReinforcements();
            IRebar link = RebarTests.CreateRebar(8);

            // Act
            IConcreteSection section = new ConcreteSection(material, profile, rebars, link);

            // Assert
            Assert.Equivalent(profile, section.Profile);
            Assert.Equivalent(material, section.Material);
            Assert.Equivalent(rebars, section.Rebars);
            Assert.Equivalent(link, section.Link);
        }


        // TO-DO: add custom JSON converter for IStandardMaterial grade enum
        //[Fact]
        //public void InterfaceSurvivesRoundtripDeserializationTest()
        //{
        //    // Assemble
        //    IStandardMaterial material = ENConcreteFactory.CreateStandardMaterial(ENConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
        //    IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
        //    IList<ILongitudinalReinforcement> rebars = LongitudinalReinforcementTests.CreateLongitudinalReinforcements();
        //    IRebar link = RebarTests.CreateRebar(8);
        //    IConcreteSection section = new ConcreteSection(material, profile, rebars, link);

        //    // Act
        //    string json = section.ToJson();
        //    IConcreteSection sectDeserialized = json.FromJson<IConcreteSection>();

        //    // Assert
        //    Assert.Equivalent(section, sectDeserialized);
        //}
    }
}
