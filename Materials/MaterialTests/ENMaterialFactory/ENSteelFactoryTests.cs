using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MaterialTests.StandardMaterials
{
    public class EnSteelFactoryTests
    {
        [Fact]
        public void CreateStandardS355ConcreteMaterialTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            EnSteelGrade grade = EnSteelGrade.S355;

            // Act
            IEnSteelMaterial material = new EnSteelMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Steel, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1993, material.Standard.Code);
            Assert.Equal(
                "EN 1993-1-1: Eurocode 3: Design of Steel Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(EnSteelGrade.S355, material.Grade);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticTests(EnSteelGrade grade)
        {
            // Assemble
            var material = new EnSteelMaterial(grade, NationalAnnex.RecommendedValues);
            string materialGrade = GetGradeName(material);

            // Act
            ILinearElasticMaterial analysisMaterial = EnSteelFactory.CreateLinearElastic(material);

            // Assert
            double expectedStrength = Table3_1[materialGrade].fy40;
            Assert.Equal(expectedStrength, analysisMaterial.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, analysisMaterial.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, analysisMaterial.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticThickPlatedTests(EnSteelGrade grade)
        {
            // Assemble
            var material = new EnSteelMaterial(grade, NationalAnnex.RecommendedValues);
            string materialGrade = GetGradeName(material);
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            ILinearElasticMaterial analysisMaterial = EnSteelFactory.CreateLinearElastic(material, thickness);

            // Assert
            double expectedStrength = Table3_1[materialGrade].fy80;
            Assert.Equal(expectedStrength, analysisMaterial.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, analysisMaterial.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, analysisMaterial.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateBiLinearTests(EnSteelGrade grade)
        {
            // Assemble
            var material = new EnSteelMaterial(grade, NationalAnnex.RecommendedValues);
            string materialGrade = GetGradeName(material);

            // Act
            IBiLinearMaterial analysisMaterial = EnSteelFactory.CreateBiLinear(material);

            // Assert
            double expectedYieldStrength = Table3_1[materialGrade].fy40;
            Assert.Equal(expectedYieldStrength, analysisMaterial.YieldStrength.Megapascals, 12);

            double expectedUltimateStrength = Table3_1[materialGrade].fu40;
            Assert.Equal(expectedUltimateStrength, analysisMaterial.UltimateStrength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, analysisMaterial.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, analysisMaterial.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateBiLinearThickPlatedTests(EnSteelGrade grade)
        {
            if ((int)grade > 21)
            {
                CreateBiLinearThrowsExpectionForSomeGradesTests(grade);
                return;
            }

            // Assemble
            var material = new EnSteelMaterial(grade, NationalAnnex.RecommendedValues);
            string materialGrade = GetGradeName(material);
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            IBiLinearMaterial analysisMaterial = EnSteelFactory.CreateBiLinear(material, thickness);

            // Assert
            double expectedYieldStrength = Table3_1[materialGrade].fy80;
            Assert.Equal(expectedYieldStrength, analysisMaterial.YieldStrength.Megapascals, 12);

            double expectedUltimateStrength = Table3_1[materialGrade].fu80;
            Assert.Equal(expectedUltimateStrength, analysisMaterial.UltimateStrength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, analysisMaterial.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, analysisMaterial.Type);
        }

        [Fact]
        public void CreateLinearElasticThrowsExpectionForTooThickPlateTests()
        {
            // Assemble
            var material = new EnSteelMaterial(EnSteelGrade.S235, NationalAnnex.RecommendedValues);
            Length thickness = new Length(81, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => EnSteelFactory.CreateLinearElastic(material, thickness));
        }

        [Theory]
        [InlineData(EnSteelGrade.S275)]
        [InlineData(EnSteelGrade.S355)]
        [InlineData(EnSteelGrade.S420)]
        [InlineData(EnSteelGrade.S460)]
        public void CreateBiLinearThrowsExpectionForSomeGradesTests(EnSteelGrade grade)
        {
            // Assemble
            var material = new EnSteelMaterial(grade, NationalAnnex.RecommendedValues);
            material.Specification.DeliveryCondition = EnSteelDeliveryCondition.M;
            material.Specification.HollowSection = true;
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => EnSteelFactory.CreateBiLinear(material, thickness));
        }

        public static IEnumerable<object[]> EnumValues()
        {
            foreach (var enumValue in Enum.GetValues(typeof(EnSteelGrade)))
            {
                yield return new object[] { enumValue };
            }
        }

        private static string GetGradeName(IEnSteelMaterial material)
        {
            string materialGrade = $"{material.Grade}{material.Specification.DeliveryCondition}";
            return materialGrade.Replace("AR", string.Empty) + (material.Specification.HollowSection ? "H" : string.Empty);
        }

        private static readonly Dictionary<string, (double fy40, double fu40, double fy80, double fu80)> Table3_1 = new()
        {
            { "S235", (235, 360, 215, 360) },
            { "S275", (275, 430, 255, 410) },
            { "S355", (355, 490, 335, 470) },
            { "S450", (440, 550, 410, 550) },

            { "S275N", (275, 390, 255, 370) },
            { "S355N", (355, 490, 335, 470) },
            { "S420N", (420, 520, 390, 520) },
            { "S460N", (460, 540, 430, 540) },

            { "S275M", (275, 370, 255, 360) },
            { "S355M", (355, 470, 335, 450) },
            { "S420M", (420, 520, 390, 500) },
            { "S460M", (460, 540, 430, 530) },

            { "S235W", (235, 360, 215, 340) },
            { "S355W", (355, 490, 335, 490) },

            { "S460Q", (460, 570, 440, 550) },

            { "S235H", (235, 360, 215, 340) },
            { "S275H", (275, 430, 255, 410) },
            { "S355H", (355, 510, 335, 490) },

            { "S275NH", (275, 390, 255, 370) },
            { "S355NH", (355, 490, 335, 470) },
            { "S420NH", (420, 540, 390, 520) },
            { "S460NH", (460, 560, 430, 550) },

            { "S275MH", (275, 360, 0, 0) },
            { "S355MH", (355, 470, 0, 0) },
            { "S420MH", (420, 500, 0, 0) },
            { "S460MH", (460, 530, 0, 0) },
        };
    }
}
