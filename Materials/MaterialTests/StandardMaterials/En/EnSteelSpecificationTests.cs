using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Serialization;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MaterialTests.StandardMaterials.En
{
    public class EnSteelSpecificationTests
    {
        [Fact]
        public void CreateSpecificationTests()
        {
            // Assemble
            EnSteelGrade grade = EnSteelGrade.S235;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;
            IEnSteelMaterial material = new EnSteelMaterial(grade, nationalAnnex);

            // Act
            IEnSteelSpecification spec = material.Specification;

            // Assert
            Assert.Equal(EnExecutionClass.EXC3, spec.ExecutionClassforStaticOrLowSeismicLoading);
            Assert.Equal(EnExecutionClass.EXC3, spec.ExecutionClassforFatigueOrHighSeismicLoading);
            Assert.Equal(EnSteelDeliveryCondition.AR, spec.DeliveryCondition);
            Assert.False(spec.HollowSection);
            Assert.Equal(EnSteelFormingTemperature.HotRolled, spec.FormingTemperature);
            Assert.Equal(EnSteelImpactTemperatureProperty.None, spec.ImpactTemperatureProperty);
            Assert.Equal(EnSteelCorrosionResistance.None, spec.CorrosionResistance);
            Assert.Equal(EnSteelQuality.None, spec.Quality);
        }

        [Fact]
        public void EditSpecificationTests()
        {
            // Assemble
            EnSteelGrade grade = EnSteelGrade.S235;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;
            IEnSteelMaterial material = new EnSteelMaterial(grade, nationalAnnex);
            IEnSteelSpecification spec = material.Specification;

            // Act
            spec.ExecutionClassforStaticOrLowSeismicLoading = EnExecutionClass.EXC1;
            spec.ExecutionClassforFatigueOrHighSeismicLoading = EnExecutionClass.EXC4;
            spec.DeliveryCondition = EnSteelDeliveryCondition.N;
            spec.HollowSection = true;
            spec.FormingTemperature = EnSteelFormingTemperature.ColdFormed;
            spec.ImpactTemperatureProperty = EnSteelImpactTemperatureProperty.L;
            spec.CorrosionResistance = EnSteelCorrosionResistance.W;
            spec.Quality = EnSteelQuality.JR;

            // Assert
            Assert.Equal(EnExecutionClass.EXC1, spec.ExecutionClassforStaticOrLowSeismicLoading);
            Assert.Equal(EnExecutionClass.EXC4, spec.ExecutionClassforFatigueOrHighSeismicLoading);
            Assert.Equal(EnSteelDeliveryCondition.N, spec.DeliveryCondition);
            Assert.True(spec.HollowSection);
            Assert.Equal(EnSteelFormingTemperature.ColdFormed, spec.FormingTemperature);
            Assert.Equal(EnSteelImpactTemperatureProperty.L, spec.ImpactTemperatureProperty);
            Assert.Equal(EnSteelCorrosionResistance.W, spec.CorrosionResistance);
            Assert.Equal(EnSteelQuality.JR, spec.Quality);
        }


        [Theory]
        [InlineData("S235", EnSteelGrade.S235,
            EnSteelDeliveryCondition.AR, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S275J0", EnSteelGrade.S275,
            EnSteelDeliveryCondition.AR, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.J0)]
        [InlineData("S355JR", EnSteelGrade.S355,
            EnSteelDeliveryCondition.AR, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.JR)]
        [InlineData("S450J2", EnSteelGrade.S450,
            EnSteelDeliveryCondition.AR, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.J2)]
        [InlineData("S275K2 N", EnSteelGrade.S275,
            EnSteelDeliveryCondition.N, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.K2)]
        [InlineData("S275 NL", EnSteelGrade.S275,
            EnSteelDeliveryCondition.N, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355 N", EnSteelGrade.S355,
            EnSteelDeliveryCondition.N, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355 NL", EnSteelGrade.S355,
            EnSteelDeliveryCondition.N, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S420 N", EnSteelGrade.S420,
            EnSteelDeliveryCondition.N, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S420 NL", EnSteelGrade.S420,
            EnSteelDeliveryCondition.N, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460 N", EnSteelGrade.S460,
            EnSteelDeliveryCondition.N, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460 NL", EnSteelGrade.S460,
            EnSteelDeliveryCondition.N, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S275 M", EnSteelGrade.S275,
            EnSteelDeliveryCondition.M, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S275 ML", EnSteelGrade.S275,
            EnSteelDeliveryCondition.M, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355 M", EnSteelGrade.S355,
            EnSteelDeliveryCondition.M, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355 ML", EnSteelGrade.S355,
            EnSteelDeliveryCondition.M, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S420 M", EnSteelGrade.S420,
            EnSteelDeliveryCondition.M, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S420 ML", EnSteelGrade.S420,
            EnSteelDeliveryCondition.M, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460 M", EnSteelGrade.S460,
            EnSteelDeliveryCondition.M, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460 ML", EnSteelGrade.S460,
            EnSteelDeliveryCondition.M, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S235 W", EnSteelGrade.S235,
            EnSteelDeliveryCondition.AR, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.W, EnSteelQuality.None)]
        [InlineData("S355 W", EnSteelGrade.S355,
            EnSteelDeliveryCondition.AR, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.W, EnSteelQuality.None)]
        [InlineData("S355 WP", EnSteelGrade.S355,
            EnSteelDeliveryCondition.AR, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.WP, EnSteelQuality.None)]
        [InlineData("S460 Q", EnSteelGrade.S460,
            EnSteelDeliveryCondition.Q, false, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460 QL", EnSteelGrade.S460,
            EnSteelDeliveryCondition.Q, false, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460 QL1", EnSteelGrade.S460,
            EnSteelDeliveryCondition.Q, false, EnSteelImpactTemperatureProperty.L1, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S235H", EnSteelGrade.S235,
            EnSteelDeliveryCondition.AR, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S275H", EnSteelGrade.S275,
            EnSteelDeliveryCondition.AR, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355H", EnSteelGrade.S355,
            EnSteelDeliveryCondition.AR, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S275NH", EnSteelGrade.S275,
            EnSteelDeliveryCondition.N, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S275NHL", EnSteelGrade.S275,
            EnSteelDeliveryCondition.N, true, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355NH", EnSteelGrade.S355,
            EnSteelDeliveryCondition.N, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355NHL", EnSteelGrade.S355,
            EnSteelDeliveryCondition.N, true, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S420NH", EnSteelGrade.S420,
            EnSteelDeliveryCondition.N, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S420NHL", EnSteelGrade.S420,
            EnSteelDeliveryCondition.N, true, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460NH", EnSteelGrade.S460,
            EnSteelDeliveryCondition.N, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460NHL", EnSteelGrade.S460,
            EnSteelDeliveryCondition.N, true, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S275MH", EnSteelGrade.S275,
            EnSteelDeliveryCondition.M, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S275MHL", EnSteelGrade.S275,
            EnSteelDeliveryCondition.M, true, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355MH", EnSteelGrade.S355,
            EnSteelDeliveryCondition.M, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S355MHL", EnSteelGrade.S355,
            EnSteelDeliveryCondition.M, true, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S420MH", EnSteelGrade.S420,
            EnSteelDeliveryCondition.M, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S420MHL", EnSteelGrade.S420,
            EnSteelDeliveryCondition.M, true, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460MH", EnSteelGrade.S460,
            EnSteelDeliveryCondition.M, true, EnSteelImpactTemperatureProperty.None, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        [InlineData("S460MHL", EnSteelGrade.S460,
            EnSteelDeliveryCondition.M, true, EnSteelImpactTemperatureProperty.L, EnSteelCorrosionResistance.None, EnSteelQuality.None)]
        public void SpecificationFromDesignationTests(string steelDesignation, EnSteelGrade expGrade,
            EnSteelDeliveryCondition expDeliveryCondition, bool expHollow, EnSteelImpactTemperatureProperty expTemp,
            EnSteelCorrosionResistance expCorr, EnSteelQuality expQuality)
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            Assert.True(EnSteelMaterial.TryCreateFromDesignition(steelDesignation, nationalAnnex, out EnSteelMaterial material));
            IEnSteelSpecification spec = material.Specification;

            // Assert
            Assert.Equal(expGrade, material.Grade);
            Assert.Equal(expDeliveryCondition, spec.DeliveryCondition);
            Assert.Equal(expHollow, spec.HollowSection);
            Assert.Equal(expTemp, spec.ImpactTemperatureProperty);
            Assert.Equal(expCorr, spec.CorrosionResistance);
            Assert.Equal(expQuality, spec.Quality);
        }

        [Theory]
        [InlineData("S235 WL")]
        [InlineData("S235 WP")]
        [InlineData("S275 W")]
        [InlineData("S355 MW")]
        [InlineData("S450 H")]
        [InlineData("S460")]
        [InlineData("S450 N")]
        [InlineData("S450 M")]
        [InlineData("S235 Q")]
        [InlineData("S460 QH")]
        [InlineData("S235 L1")]
        public void SpecificationFromInvalidDesignationTests(string steelDesignation)
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            // Assert
            Assert.False(EnSteelMaterial.TryCreateFromDesignition(steelDesignation, nationalAnnex, out EnSteelMaterial material));
        }

        [Theory]
        [InlineData("S 275 J2 AR", "Steel EN 10025-2 - S275J2+AR")]
        [InlineData("S 355 NL", "Steel EN 10025-3 - S355NL")]
        [InlineData("S 355 ML", "Steel EN 10025-4 - S355ML")]
        [InlineData("S355J0WN", "Steel EN 10025-5 - S355J0W+N")]
        [InlineData("S460QL", "Steel EN 10025-6 - S460QL")]
        public void GetSpecificationDesignationTests(string steelDesignation, string expected)
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;

            // Act
            Assert.True(EnSteelMaterial.TryCreateFromDesignition(steelDesignation, nationalAnnex, out EnSteelMaterial material));

            // Assert
            Assert.Equal(expected, material.GetDesignation());
        }

        [Fact]
        public void InterfaceSurvivesRoundtripDeserializationTest()
        {
            // Assemble
            EnSteelGrade grade = EnSteelGrade.S235;
            NationalAnnex nationalAnnex = NationalAnnex.UnitedKingdom;
            IEnSteelMaterial material = new EnSteelMaterial(grade, nationalAnnex);
            IEnSteelSpecification spec = material.Specification;

            // Act
            string json = spec.ToJson();
            IEnSteelSpecification matDeserialized = json.FromJson<IEnSteelSpecification>();

            // Assert
            Assert.Equivalent(spec, matDeserialized);
        }
    }
}
