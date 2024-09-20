using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Serialization.Materials.Extensions;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MaterialTests
{
    public class StandardMaterialTests
    {
        [Fact]
        public void CreateStandardENC30_37ConcreteMaterialTests()
        {
            // Assemble
            MaterialType type = MaterialType.Concrete;
            IStandard standard = new EN1992(EN1992Part.Part1_1, NationalAnnex.RecommendedValues);
            ENConcreteGrade grade = ENConcreteGrade.C30_37;

            // Act
            IStandardMaterial material = new StandardMaterial(type, standard, grade);

            // Assert
            Assert.Equal(MaterialType.Concrete, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1992, material.Standard.Code);
            Assert.Equal(
                "EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(ENConcreteGrade.C30_37, material.Grade);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            MaterialType type = MaterialType.Concrete;
            IStandard standard = new EN1992();
            ENConcreteGrade grade = ENConcreteGrade.C30_37;
            IStandardMaterial material = new StandardMaterial(type, standard, grade);

            // Act
            string json = material.ToJson();
            IStandardMaterial matDeserialized = json.FromJson<IStandardMaterial>();

            // Assert
            Assert.Equivalent(material, matDeserialized);
        }
    }
}
