using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Serialization;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MaterialTests.StandardMaterials.EN
{
    public class EnConcreteMaterialTests
    {
        [Fact]
        public void CreateStandardENC40_50UKNAConcreteMaterialTests()
        {
            // Assemble
            EnConcreteGrade grade = EnConcreteGrade.C40_50;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            IEnConcreteMaterial material = new EnConcreteMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Concrete, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1992, material.Standard.Code);
            Assert.Equal(
                "BS EN 1992-1-1: Eurocode 2: Design of Concrete Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(NationalAnnex.UnitedKingdom, material.Standard.NationalAnnex);
            Assert.Equal(EnConcreteGrade.C40_50, material.Grade);
            Assert.Equal(EnConcreteExposureClass.XC1, material.ExposureClasses[0]);
            Assert.Equal(20, material.MaximumAggregateSize.Millimeters);
            Assert.Equal(0.3, material.MaximumCrackWidth.Millimeters);
            Assert.Equal(30, material.MinimumCover.Millimeters);
        }

        [Fact]
        public void CreateStandardENC30_37GermanNAConcreteMaterialWithExposureClassAndMaxAggregateSizeTests()
        {
            // Assemble
            EnConcreteGrade grade = EnConcreteGrade.C30_37;
            NationalAnnex nationalAnnex = NationalAnnex.Germany;
            EnConcreteExposureClass exposureClass = EnConcreteExposureClass.XF2;
            EnCementClass cementClass = EnCementClass.S;
            Length maxAggregateSize = new Length(40, LengthUnit.Millimeter);
            Length crackWidth = new Length(0.2, LengthUnit.Millimeter);
            Length cover = new Length(55, LengthUnit.Millimeter);

            // Act
            IEnConcreteMaterial material = new EnConcreteMaterial(grade, nationalAnnex, exposureClass, maxAggregateSize, cementClass, crackWidth, cover);

            // Assert
            Assert.Equal(NationalAnnex.Germany, material.Standard.NationalAnnex);
            Assert.Equal(EnConcreteGrade.C30_37, material.Grade);
            Assert.Equal(EnConcreteExposureClass.XF2, material.ExposureClasses[0]);
            Assert.Equal(EnCementClass.S, material.CementClass);
            Assert.Equal(40, material.MaximumAggregateSize.Millimeters);
            Assert.Equal(0.2, material.MaximumCrackWidth.Millimeters);
            Assert.Equal(55, material.MinimumCover.Millimeters);
        }

        [Theory]
        [InlineData(NationalAnnex.RecommendedValues, 1.5, 1.2, 1.0, 1.0)]
        [InlineData(NationalAnnex.Germany, 1.5, 1.3, 0.85, 0.85)]
        [InlineData(NationalAnnex.UnitedKingdom, 1.5, 1.2, 0.85, 1.0)]
        public void PartialFactorsTest(NationalAnnex na, double expectedGammaC, double expectedGammaCAccidental, double expectedAlphaCC, double expectedAlphaCT)
        {
            // Assemble
            EnConcreteGrade grade = EnConcreteGrade.C40_50;

            // Act
            IEnConcreteMaterial material = new EnConcreteMaterial(grade, na);

            // Assert
            Assert.Equal(expectedGammaC, material.PartialFactor.DecimalFractions);
            Assert.Equal(expectedGammaCAccidental, material.AccidentalPartialFactor.DecimalFractions);
            Assert.Equal(expectedAlphaCC, material.LongTermCompressionFactor.DecimalFractions);
            Assert.Equal(expectedAlphaCT, material.LongTermTensionFactor.DecimalFractions);
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C40_50, NationalAnnex.UnitedKingdom);

            // Act
            string json = material.ToJson();
            IEnConcreteMaterial matDeserialized = json.FromJson<IEnConcreteMaterial>();

            // Assert
            Assert.Equivalent(material, matDeserialized);
        }
    }
}
